using System;
using System.Windows;
using SiCuAstaPasta.ViewModels;

namespace SiCuAstaPasta.Models
{
    public class Produs : NotifyPropertyChangedBase
    {
        private bool disponibilitate;
        private double pret;

        public int Id { get; set; }
        public string Nume { get; set; }
        public string Descriere { get; set; }
        public string Alergeni { get; set; }
        public string Imagine { get; set; }
        public bool EsteMeniu { get; set; }

        public bool Disponibilitate
        {
            get => disponibilitate;
            set
            {
                if (disponibilitate == value) return;
                disponibilitate = value;
                OnPropertyChanged();
            }
        }

        public double Pret
        {
            get => Math.Round(pret, 1);
            set
            {
                if (pret == value) return;
                pret = value;
                OnPropertyChanged();
            }
        }

        public Visibility ButonAdauga => UtilizatorConectat.UtilizatorCurent == null || UtilizatorConectat.UtilizatorCurent.angajat ? Visibility.Hidden : Visibility.Visible;
    }
}
