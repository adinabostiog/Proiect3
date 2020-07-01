using System.Windows;
using System.Windows.Controls;
using SiCuAstaPasta.Models;

namespace SiCuAstaPasta.Views
{
    /// <summary>
    /// Interaction logic for LoginView.xaml
    /// </summary>
    public partial class ConectareView : UserControl
    {
        public ConectareView()
        {
            InitializeComponent();
        }

        private void IngregistrareClick(object sender, RoutedEventArgs e)
        {
            Navigare.NavigareIntreUC(Navigare.Views.Inregistrare);
        }

        private void ContinuareClick(object sender, RoutedEventArgs e)
        {
            Navigare.NavigareIntreUC(Navigare.Views.Meniu);
        }

        private void ConectareClick(object sender, RoutedEventArgs e)
        {
            ViewModel.Conectare(Email.Text, Parola.Password);
        }
    }
}