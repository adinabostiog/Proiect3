using System.Text.RegularExpressions;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using SiCuAstaPasta.Models;

namespace SiCuAstaPasta.Views
{
    /// <summary>
    /// Interaction logic for RegisterView.xaml
    /// </summary>
    public partial class InregistrareView : UserControl
    {
        public InregistrareView()
        {
            InitializeComponent();
        }

        private void InapoiClick(object sender, RoutedEventArgs e)
        {
            Navigare.NavigareIntreUC(Navigare.Views.Conectare);
        }

        private void NumberValidationTextBox(object sender, TextCompositionEventArgs e)
        {
            Regex regex = new Regex("[^0-9]+");
            e.Handled = regex.IsMatch(e.Text);
        }
    }
}
