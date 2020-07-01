using System.Windows;
using System.Windows.Controls;
using SiCuAstaPasta.Models;

namespace SiCuAstaPasta.Views
{
    /// <summary>
    /// Interaction logic for RestaurantNavbar.xaml
    /// </summary>
    public partial class RestaurantBaraCautareView : UserControl
    {
        public RestaurantBaraCautareView()
        {
            InitializeComponent();
        }

        public void Acutalizeaza()
        {
            if (UtilizatorConectat.UtilizatorCurent != null)
            {
                ButonComenzi.IsEnabled = true;
                ButonCos.IsEnabled = !UtilizatorConectat.UtilizatorCurent.angajat;
                NumeUtilizator.Content = UtilizatorConectat.UtilizatorCurent.prenume + " "+ UtilizatorConectat.UtilizatorCurent.nume;
            }
            else
            {
                NumeUtilizator.Content = "Vizitator";
                ButonCos.IsEnabled = ButonComenzi.IsEnabled = false;
            }
        }

        private void ComenziClick(object sender, RoutedEventArgs e)
        {
            Navigare.NavigareIntreUC(Navigare.Views.Comenzi);
        }

        private void CosClick(object sender, RoutedEventArgs e)
        {
            Navigare.NavigareIntreUC(Navigare.Views.Cos);
        }

        private void DeconectareClick(object sender, RoutedEventArgs e)
        {
            Navigare.NavigareIntreUC(Navigare.Views.Conectare);
        }
    }
}
