using System;
using System.Collections.ObjectModel;
using System.Linq;
using System.Windows;
using SiCuAstaPasta.Models;
using SiCuAstaPasta.Models.Actions;

namespace SiCuAstaPasta.ViewModels
{
    internal class RestaurantViewModel : NotifyPropertyChangedBase
    {
        private readonly ProductActions produsActions;

        private ObservableCollection<Produs> paste;
        private ObservableCollection<Produs> bauturi;
        private ObservableCollection<Produs> desert;

        private ObservableCollection<Produs> rezultateCautare;
        private string cautare = "";

        public RestaurantViewModel()
        {
            produsActions = new ProductActions();
            comandaActions = new ComandaActions();

            Paste = new ObservableCollection<Produs>();
            Bauturi = new ObservableCollection<Produs>();
            Desert = new ObservableCollection<Produs>();
            Cos = new ObservableCollection<Produs>();
            StergeTotCommand = new RelayCommand(StergeTotDinCos);
            PlaseazaComandaCommand = new RelayCommand(PlaseazaComanda);
        }

        public ObservableCollection<Produs> Paste
        {
            get => paste;
            set
            {
                if (paste == value) return;
                paste = value;
                OnPropertyChanged();
            }
        }

        public ObservableCollection<Produs> Bauturi
        {
            get => bauturi;
            set
            {
                if (bauturi == value) return;
                bauturi = value;
                OnPropertyChanged();
            }
        }

        public ObservableCollection<Produs> Desert
        {
            get => desert;
            set
            {
                if (desert == value) return;
                desert = value;
                OnPropertyChanged();
            }
        }

        public ObservableCollection<Produs> RezultateCautare
        {
            get => rezultateCautare;
            set
            {
                if (rezultateCautare == value) return;
                rezultateCautare = value;
                OnPropertyChanged();
            }
        }

        public string Cautare
        {
            get => System.Globalization.CultureInfo.CurrentCulture.TextInfo.ToTitleCase(cautare.ToLower());
            set
            {
                if (cautare == value) return;
                cautare = value;
                OnPropertyChanged();
            }
        }

        private ObservableCollection<Produs> cos;
        private double costLivrare;
        private double discount;
        private double pretTotal;
        private readonly ComandaActions comandaActions;

        public ObservableCollection<Produs> Cos
        {
            get => cos;
            set
            {
                if (cos == value) return;
                cos = value;
                OnPropertyChanged();
            }
        }

        public double CostLivrare
        {
            get => Math.Round(costLivrare, 1);
            set
            {
                if (costLivrare == value) return;
                costLivrare = value;
                OnPropertyChanged();
            }
        }

        public double Discount
        {
            get => Math.Round(discount, 1);
            set
            {
                if (discount == value) return;
                discount = value;
                OnPropertyChanged();
            }
        }

        public double PretTotal
        {
            get => Math.Round(pretTotal, 1);
            set
            {
                if (pretTotal == value) return;
                pretTotal = value;
                OnPropertyChanged();
            }
        }

        public RelayCommand StergeTotCommand { get; set; }
        public RelayCommand PlaseazaComandaCommand { get; set; }

        private ObservableCollection<Comanda> comenzi;
        public ObservableCollection<Comanda> Comenzi
        {
            get => comenzi;
            set
            {
                if (comenzi == value) return;
                comenzi = value;
                OnPropertyChanged();
            }
        }

        private void PlaseazaComanda(object obj)
        {
            try
            {
                comandaActions.PlaseazaComanda(Cos.ToList(), Discount, CostLivrare, PretTotal);
                MessageBox.Show("Comanda a fost inregistrata si plasata cu succes!\nVa multumim pentru comanda dvs.!\nSi Cu Asta Pasta!", "Comanda plasata", MessageBoxButton.OK, MessageBoxImage.Information);
                StergeTotDinCos(new object());
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "Eroare comanda", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        public void StergeDinCos(Produs produs)
        {
            Cos.Remove(produs);
            ActualizeazaPreturi();
        }

        private void StergeTotDinCos(object obj)
        {
            Cos = new ObservableCollection<Produs>();
            ActualizeazaPreturi();
        }

        public void IncarcaProduse()
        {
            Paste = new ObservableCollection<Produs>(produsActions.ReturneazaProduseDupaCategorie("Paste"));
            Bauturi = new ObservableCollection<Produs>(produsActions.ReturneazaProduseDupaCategorie("Bauturi"));
            Desert = new ObservableCollection<Produs>(produsActions.ReturneazaProduseDupaCategorie("Desert"));
        }

        public void IncarcaCos()
        {
            Cos = new ObservableCollection<Produs>(Cos);
            ActualizeazaPreturi();
        }

        public void IncarcaComenzi()
        {
            Comenzi = UtilizatorConectat.UtilizatorCurent.angajat ? new ObservableCollection<Comanda>(comandaActions.ReturneazaToateComenzile()) : new ObservableCollection<Comanda>(comandaActions.ReturneazaComenzileUtilizatorului(UtilizatorConectat.UtilizatorCurent.id));
        }

        public void AnuleazaComanda(Comanda comanda)
        {
            try
            {
                comandaActions.AnuleazaComanda(comanda.id);
                IncarcaComenzi();
                MessageBox.Show($"Comanda cu codul {comanda.id} a fost anulata cu succes!", "Comanda anulata", MessageBoxButton.OK, MessageBoxImage.Information);
            }
            catch (Exception)
            {
                MessageBox.Show($"Comanda cu codul {comanda.id} nu a putut fi anulata, incercati mai tarziu!", "Eroare la anulare comanda", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        private void ActualizeazaPreturi()
        {
            double pretComanda = Cos.Sum(produs => produs.Pret);

            if (pretComanda > Properties.Settings.Default.PragSuperiorComanda)
            {
                Discount = Properties.Settings.Default.DiscountComanda * pretComanda;
            }
            else
            {
                Discount = 0;
            }

            if ((int)pretComanda == 0 || pretComanda > Properties.Settings.Default.PragSuperiorLivrare)
            {
                CostLivrare = 0;
            }
            else
            {
                CostLivrare = Properties.Settings.Default.CostLivrare;
            }

            PretTotal = pretComanda - Discount + CostLivrare;
        }

        public void Cauta()
        {
            RezultateCautare = new ObservableCollection<Produs>();

            foreach (var produsCautat in Paste.Union(Bauturi).Union(Desert))
                if (produsCautat.Nume.Contains(Cautare))
                    RezultateCautare.Add(produsCautat);
        }
    }
}