using System;
using System.Windows;
using System.Windows.Controls;
using SiCuAstaPasta.Models;

namespace SiCuAstaPasta.Views
{
    /// <summary>
    /// Interaction logic for RestaurantOrders.xaml
    /// </summary>
    public partial class RestaurantComenziView : UserControl
    {
        public RestaurantComenziView()
        {
            InitializeComponent();
        }

        private void InapoiClick(object sender, RoutedEventArgs e)
        {
            Navigare.NavigareIntreUC(Navigare.Views.Meniu);
        }

        private void AnuleazaClick(object sender, RoutedEventArgs e)
        {
            try
            {
                Comanda comanda = (sender as Button)?.DataContext as Comanda;
                ViewModel.AnuleazaComanda(comanda);
            }
            catch (Exception)
            {
                // empty
            }
        }
    }
}