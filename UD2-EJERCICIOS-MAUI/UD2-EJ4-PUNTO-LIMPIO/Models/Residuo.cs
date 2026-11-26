using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Text;

namespace UD2_EJ4_PUNTO_LIMPIO.Models
{
    public class Residuo : INotifyPropertyChanged
    {
        public string? Nombre { get; set; }
        public string? Tipo { get; set; }
        public int cantidad;

        public int Cantidad
        {
            get { return cantidad; }
            set
            {
                cantidad = value;
                OnPropertyChanged();
            }
        }

        public Residuo()
        {

        }

        public event PropertyChangedEventHandler PropertyChanged;

        protected void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
