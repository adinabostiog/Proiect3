using System;
using System.Collections.Generic;
using System.Linq;

namespace SiCuAstaPasta.Models.Actions
{
    internal class ProductActions
    {
        private readonly RestaurantMVPEntities dbContext = new RestaurantMVPEntities();

        private string ReturneazaStringAlergeni(IReadOnlyCollection<PreparatAlergeni> alergeni)
        {
            if (alergeni.Count == 0)
                return "-";

            // Linq
            string str = alergeni.Aggregate("", (current, alergen) => current + (alergen.Alergeni.name + ", "));

            // scriere normala
            //string str = "";

            //foreach (var alergen in alergeni)
            //{
            //    str += alergen.Alergeni.name + ", ";
            //}

            str = str.Remove(str.Length - 2);
            return str;
        }

        public List<Produs> ReturneazaProduseDupaCategorie(string numeCategorie)
        {
            List<Produs> produseDeReturnat = new List<Produs>();

            try
            {
                var preparate = (from preparat in dbContext.Preparats
                                            where preparat.Categorie.nume.Equals(numeCategorie)
                                            select preparat).ToList();

                // Linq
                produseDeReturnat.AddRange(preparate.Select(preparat => new Produs()
                {
                    Id = preparat.id,
                    Nume = preparat.nume,
                    Descriere = $"{preparat.cantitate_per_portie}{preparat.unitate_masura}",
                    Alergeni = ReturneazaStringAlergeni(preparat.PreparatAlergenis.ToList()),
                    Disponibilitate = preparat.cantitate_per_portie < preparat.cantitate_totala,
                    EsteMeniu = false,
                    Imagine = $"../External/PozeProduse/{preparat.nume}.png",
                    Pret = preparat.pret
                }));

                //foreach (var preparat in preparate)
                //{
                //    produseDeReturnat.Add(new Produs()
                //    {
                //        Id = preparat.id,
                //        Nume = preparat.nume,
                //        Descriere = $"{preparat.cantitate_per_portie}{preparat.unitate_masura}",
                //        Alergeni = ReturneazaStringAlergeni(preparat.PreparatAlergenis.ToList()),
                //        Disponibilitate = preparat.cantitate_per_portie < preparat.cantitate_totala,
                //        EsteMeniu = false,
                //        Imagine = $"../External/PozeProduse/{preparat.nume}.png",
                //        Pret = preparat.pret
                //    });
                //}
            }
            catch (Exception)
            {
                // empty
            }

            try
            {
                var meniuri = (from meniu in dbContext.Menius
                    where meniu.Categorie.nume.Equals(numeCategorie)
                    select meniu).ToList();

                foreach (var meniu in meniuri)
                {
                    var produs = new Produs()
                    {
                        Id = meniu.id,
                        Nume = meniu.nume,
                        EsteMeniu = true,
                        Imagine = $"../External/PozeProduse/{meniu.nume}.png",
                        Descriere = "",
                        Alergeni = "",
                        Pret = dbContext.spReturneazaCostTotalMeniu(meniu.id).First() ?? 0,
                        Disponibilitate = dbContext.spReturneazaStocMaximMeniu(meniu.id).First() > 0
                    };

                    var preparate = dbContext.spReturneazaPreparateleMeniului(meniu.id)?.ToList();

                    if (preparate != null)
                        foreach (var preparat in preparate)
                        {
                            var dbPreparat = (from p in dbContext.Preparats
                                              where p.id.Equals(preparat.id)
                                              select p).First();

                            produs.Descriere += $"{dbPreparat.nume} {preparat.cantitate}{preparat.unitate_masura}, ";

                            if (string.IsNullOrEmpty(produs.Alergeni))
                                produs.Alergeni += ReturneazaStringAlergeni(dbPreparat.PreparatAlergenis.ToList());
                        }

                    produs.Pret -= produs.Pret * Properties.Settings.Default.DiscountMeniu;
                    produs.Descriere = produs.Descriere.Remove(produs.Descriere.Length - 2);
                    produseDeReturnat.Add(produs);
                }
            }
            catch (Exception)
            {
                // empty
            }

            return produseDeReturnat;
        }
    }
}