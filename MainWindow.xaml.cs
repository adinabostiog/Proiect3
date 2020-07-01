using System.Windows;
using SiCuAstaPasta.Models;

namespace SiCuAstaPasta
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            Navigare.mainWindow = this;
        }
    }
}