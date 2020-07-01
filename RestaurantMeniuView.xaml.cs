using System;
using System.Windows;
using System.Windows.Controls;
using SiCuAstaPasta.Models;

namespace SiCuAstaPasta.Views
{
    /// <summary>
    /// Interaction logic for RestaurantMenu.xaml
    /// </summary>
    public partial class RestaurantMeniuView : UserControl
    {
        public RestaurantMeniuView()
        {
            InitializeComponent();
        }

        private void SchimbaCategoriaClick(object sender, RoutedEventArgs e)
        {
            try
            {
                switch ((sender as Button)?.Content)
                {
                    case "Paste":
                        ListaProduse.ItemsSource = ViewModel.Paste;
                        break;
                    case "Bauturi":
                        ListaProduse.ItemsSource = ViewModel.Bauturi;
                        break;
                    case "Desert":
                        ListaProduse.ItemsSource = ViewModel.Desert;
                        break;
                    default:
                        return;
                }
            }
            catch (Exception)
            {
                // empty
            }
        }

        private void CautaClick(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrEmpty(Cautare.Text))
            {
                ListaProduse.ItemsSource = ViewModel.Paste;
            }
            else
            {
                ViewModel.Cauta();
                ListaProduse.ItemsSource = ViewModel.RezultateCautare;
            }
        }

        private void AdaugaClick(object sender, RoutedEventArgs e)
        {
            try
            {
                var produs = (sender as Button)?.DataContext as Produs;
                (Application.Current.MainWindow as MainWindow)?.CosUC.ViewModel.Cos.Add(produs);
            }
            catch (Exception)
            {
                // empty
            }
        }
    }
}