using System;
using System.Windows;

namespace SiCuAstaPasta.Models
{
    public static class Navigare
    {
        public static MainWindow mainWindow;

        public enum Views
        {
            Conectare,
            Inregistrare,
            Meniu,
            Cos,
            Comenzi
        }

        public static void NavigareIntreUC(Views navigareViews)
        {
            switch (navigareViews)
            {
                case Views.Conectare:
                    if (mainWindow.BaraNavigareUC.Visibility == Visibility.Visible)
                    {
                        mainWindow.MeniuUC.Visibility = Visibility.Hidden;
                        mainWindow.CosUC.Visibility = Visibility.Hidden;
                        mainWindow.ComenziUC.Visibility = Visibility.Hidden;
                        mainWindow.BaraNavigareUC.Visibility = Visibility.Hidden;
                        UtilizatorConectat.UtilizatorCurent = null;
                    }
                    mainWindow.InregistrareUC.Visibility = Visibility.Hidden;
                    mainWindow.ConectareUC.Visibility = Visibility.Visible;
                    break;

                case Views.Inregistrare:
                    mainWindow.ConectareUC.Visibility = Visibility.Hidden;
                    mainWindow.InregistrareUC.Visibility = Visibility.Visible;
                    break;

                case Views.Meniu:
                    if (mainWindow.BaraNavigareUC.Visibility == Visibility.Hidden)
                    {
                        mainWindow.ConectareUC.Visibility = Visibility.Hidden;
                        mainWindow.BaraNavigareUC.Acutalizeaza();
                        mainWindow.BaraNavigareUC.Visibility = Visibility.Visible;
                    }
                    mainWindow.MeniuUC.ViewModel.IncarcaProduse();
                    mainWindow.ComenziUC.Visibility = Visibility.Hidden;
                    mainWindow.CosUC.Visibility = Visibility.Hidden;
                    mainWindow.MeniuUC.Visibility = Visibility.Visible;
                    break;

                case Views.Cos:
                    mainWindow.CosUC.ViewModel.IncarcaCos();
                    mainWindow.MeniuUC.Visibility = Visibility.Hidden;
                    mainWindow.ComenziUC.Visibility = Visibility.Hidden;
                    mainWindow.CosUC.Visibility = Visibility.Visible;
                    break;

                case Views.Comenzi:
                    mainWindow.ComenziUC.ViewModel.IncarcaComenzi();
                    mainWindow.CosUC.Visibility = Visibility.Hidden;
                    mainWindow.MeniuUC.Visibility = Visibility.Hidden;
                    mainWindow.ComenziUC.Visibility = Visibility.Visible;
                    break;

                default:
                    throw new ArgumentOutOfRangeException(nameof(navigareViews), navigareViews, null);
            }
        }
    }
}
