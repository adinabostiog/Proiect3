using System;
using System.Linq;

namespace SiCuAstaPasta.Models.Actions
{
    internal class UtilizatorActions
    {
        private readonly RestaurantMVPEntities dbContext = new RestaurantMVPEntities();

        public bool ConectareUtilizatorAction(string email, string parola)
        {
            try
            {
                var dateConectare = dbContext.spAutentificareUtilizator(email, parola).First();

                if (!dateConectare.email.Equals(email) || !dateConectare.parola.Equals(parola))
                    return false;

                UtilizatorConectat.UtilizatorCurent = new Utilizator()
                {
                    id = dateConectare.id,
                    prenume = dateConectare.prenume,
                    nume = dateConectare.nume,
                    email = dateConectare.email,
                    parola = dateConectare.parola,
                    telefon = dateConectare.telefon,
                    adresa = dateConectare.adresa,
                    angajat = dateConectare.angajat
                };

                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public bool InregistrareUtilizatorAction(Utilizator utilizator)
        {
            try
            {
                dbContext.spInregistrareUtilizator(
                    utilizator.prenume,
                    utilizator.nume,
                    utilizator.email,
                    utilizator.parola,
                    utilizator.telefon,
                    utilizator.adresa
                    );

                dbContext.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
    }
}