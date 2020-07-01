using System;
using System.Windows;
using System.Windows.Controls;
using SiCuAstaPasta.Models;

namespace SiCuAstaPasta.Views
{
    /// <summary>
    /// Interaction logic for RestaurantCart.xaml
    /// </summary>
    public partial class RestaurantCosView : UserControl
    {
        public RestaurantCosView()
        {
            InitializeComponent();
        }

        private void InapoiClick(object sender, RoutedEventArgs e)
        {
            Navigare.NavigareIntreUC(Navigare.Views.Meniu);
        }

        private void StergeProdusClick(object sender, RoutedEventArgs e)
        {
            try
            {
                Produs produs = (sender as Button)?.DataContext as Produs;
                ViewModel.StergeDinCos(produs);
            }
            catch (Exception)
            {
                // empty
            }
        }
    }
}