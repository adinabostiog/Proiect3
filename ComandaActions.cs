using System;
using System.Collections.Generic;
using System.Linq;

namespace SiCuAstaPasta.Models.Actions
{
    internal class ComandaActions
    {
        private readonly RestaurantMVPEntities dbContext = new RestaurantMVPEntities();
        private Dictionary<int, int> produseCantitateMeniuri;
        private Dictionary<int, int> produseCantitatePreparate;

        private void PoatePlasaComanda(IReadOnlyCollection<Produs> cos)
        {
            if (cos.Count == 0)
                throw new Exception($"Cosul de cumparaturi este gol!");

            produseCantitateMeniuri = new Dictionary<int, int>();
            produseCantitatePreparate = new Dictionary<int, int>();

            foreach (var produs in cos)
            {
                if (produs.EsteMeniu)
                {
                    if (produseCantitateMeniuri.ContainsKey(produs.Id))
                        produseCantitateMeniuri[produs.Id] += 1;
                    else
                        produseCantitateMeniuri[produs.Id] = 1;
                }
                else
                {
                    if (produseCantitatePreparate.ContainsKey(produs.Id))
                        produseCantitatePreparate[produs.Id] += 1;
                    else
                        produseCantitatePreparate[produs.Id] = 1;
                }
            }

            var produseUnice = cos.Distinct();

            foreach (var produs in produseUnice)
            {
                if (produs.EsteMeniu)
                {
                    var rezultat = dbContext.spReturneazaStocMaximMeniu(produs.Id).First();

                    if (rezultat < produseCantitateMeniuri[produs.Id])
                        throw new Exception($"Stocul este insuficient pentru produsul: {produs.Nume}!");
                }
                else
                {
                    var rezultat = dbContext.spReturneazaStocMaximPreparat(produs.Id).First();

                    if (rezultat < produseCantitatePreparate[produs.Id])
                        throw new Exception($"Stocul este insuficient pentru produsul: {produs.Nume}!");
                }
            }
        }

        public void PlaseazaComanda(List<Produs> cos, double comandaDiscount, double comandaCostLivrare, double comandaPretTotal)
        {
            PoatePlasaComanda(cos);

            Comanda comanda = new Comanda

            {
                fk_utilizator = UtilizatorConectat.UtilizatorCurent.id,
                stare = "inregistrata",
                timp_inregistrare = DateTime.Now,
                ora_estimativa_livrare = DateTime.Now + TimeSpan.FromHours(1),
                discount = comandaDiscount,
                cost_transport = comandaCostLivrare,
                pret_total = comandaPretTotal,
                ComandaMenius = new List<ComandaMeniu>(),
                ComandaPreparats = new List<ComandaPreparat>()
            };

            dbContext.Comandas.Add(comanda);

            foreach (var produs in cos)
            {
                if (produs.EsteMeniu)
                {
                    var meniu = (from m in dbContext.Menius
                                 where m.id.Equals(produs.Id)
                                 select m).First();

                    comanda.ComandaMenius.Add(new ComandaMeniu()
                    {
                        cantitate = produseCantitateMeniuri[produs.Id],
                        Comanda = comanda,
                        Meniu = meniu
                    });

                    foreach (var meniuPreparat in meniu.MeniuPreparats)
                        meniuPreparat.Preparat.cantitate_totala -= meniuPreparat.cantitate * produseCantitateMeniuri[meniu.id];
                }
                else
                {
                    var preparat = (from p in dbContext.Preparats
                                    where p.id.Equals(produs.Id)
                                    select p).First();

                    comanda.ComandaPreparats.Add(new ComandaPreparat()
                    {
                        cantitate = produseCantitatePreparate[produs.Id],
                        Comanda = comanda,
                        Preparat = preparat
                    });

                    preparat.cantitate_totala -= preparat.cantitate_per_portie * produseCantitatePreparate[preparat.id];
                }
            }

            dbContext.SaveChanges();
        }

        public List<Comanda> ReturneazaToateComenzile()
        {
            return dbContext.Comandas.ToList().OrderByDescending(c => c.timp_inregistrare).ToList();
        }

        public List<Comanda> ReturneazaComenzileUtilizatorului(int idUtilizator)
        {
            return (from c in dbContext.Comandas
                    where c.fk_utilizator.Equals(idUtilizator)
                    orderby c.timp_inregistrare descending
                    select c).ToList();
        }

        public void AnuleazaComanda(int idComanda)
        {
            var comanda = (from c in dbContext.Comandas
                           where c.id.Equals(idComanda)
                           select c).First();

            comanda.stare = "anulata";
            dbContext.SaveChanges();
        }
    }
}