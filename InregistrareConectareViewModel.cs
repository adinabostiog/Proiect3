using System.Windows;
using SiCuAstaPasta.Models;
using SiCuAstaPasta.Models.Actions;

namespace SiCuAstaPasta.ViewModels
{
    internal class InregistrareConectareViewModel : NotifyPropertyChangedBase
    {
        private readonly UtilizatorActions utilizatorActions;
        private Utilizator inregistrareUtilizator;

        public InregistrareConectareViewModel()
        {
            utilizatorActions = new UtilizatorActions();

            InregistrareUtilizator = new Utilizator();
            InregistrareUtilizatorCommand = new RelayCommand(Inregistrare);
        }

        public Utilizator InregistrareUtilizator
        {
            get => inregistrareUtilizator;
            set
            {
                if (inregistrareUtilizator == value) return;
                inregistrareUtilizator = value;
                OnPropertyChanged();
            }
        }

        public RelayCommand InregistrareUtilizatorCommand { get; set; }

        private void Inregistrare(object param)
        {
            if (string.IsNullOrEmpty(InregistrareUtilizator.nume) || string.IsNullOrEmpty(InregistrareUtilizator.prenume) || string.IsNullOrEmpty(InregistrareUtilizator.telefon) ||
                string.IsNullOrEmpty(InregistrareUtilizator.email) || string.IsNullOrEmpty(InregistrareUtilizator.adresa) || string.IsNullOrEmpty(InregistrareUtilizator.parola))
            {
                MessageBox.Show("Toate campurile sunt obligatorii!", "Eroare la inregistrare", MessageBoxButton.OK, MessageBoxImage.Error);
            }
            else
            {
                if (!utilizatorActions.InregistrareUtilizatorAction(InregistrareUtilizator))
                {
                    MessageBox.Show("Email-ul este deja utilizat!\nVa rugam alegeti alt email!", "Eroare la inregistrare", MessageBoxButton.OK, MessageBoxImage.Error);
                }
                else
                {
                    MessageBox.Show("Contul de client a fost creat cu scucces!", "Cont inregistrat", MessageBoxButton.OK, MessageBoxImage.Information);
                    InregistrareUtilizator = new Utilizator();
                    Navigare.NavigareIntreUC(Navigare.Views.Conectare);
                }
            }
        }

        public void Conectare(string email, string parola)
        {
            if (utilizatorActions.ConectareUtilizatorAction(email, parola))
            {
                Navigare.NavigareIntreUC(Navigare.Views.Meniu);
            }
            else
            {
                MessageBox.Show("Date de autentificare gresite!\nVa rugam reincercati!", "Eroare la autentificare", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }
    }
}
