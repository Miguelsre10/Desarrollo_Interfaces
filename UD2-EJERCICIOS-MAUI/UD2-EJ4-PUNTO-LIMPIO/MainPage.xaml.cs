using System.Collections.ObjectModel;
using UD2_EJ4_PUNTO_LIMPIO.Models;

namespace UD2_EJ4_PUNTO_LIMPIO
{
    public partial class MainPage : ContentPage
    {
        public ObservableCollection<Residuo> Residuos { get; set; } = new ObservableCollection<Residuo>
        {
            new Residuo() {Nombre="Escombro", Tipo="Obra", Cantidad=0},
            new Residuo() {Nombre="Muebles", Tipo="Reutilizable", Cantidad=0},
            new Residuo() {Nombre="Aceites", Tipo="Peligrosos", Cantidad=0},
            new Residuo() {Nombre="Madera", Tipo="Reciclable", Cantidad=0},
        };

        public MainPage()
        {
            InitializeComponent();
            BindingContext = this;
            Residuos.CollectionChanged += Residuos_CollectionChanged;

        }


        private async void AddResidue_Clicked(object sender, EventArgs e)
        {
            if (ValidateEntrys())
            {
                bool found = false;
                foreach ( Residuo r in Residuos)
                {
                    if (r.Nombre.Equals(ResidueName.Text.Trim(), StringComparison.OrdinalIgnoreCase) && 
                        r.Tipo.Equals(ResidueType.Text.Trim(), StringComparison.OrdinalIgnoreCase))
                    {
                        r.Cantidad += int.Parse(ResidueAmount.Text);
                        found = true;
                        break;
                    }
                }
                if(!found) {
                    Residuos.Add(new Residuo()
                    {
                        Nombre = ResidueName.Text.Trim(),
                        Tipo = ResidueType.Text.Trim(),
                        Cantidad = int.Parse(ResidueAmount.Text)
                    });
                }
               
            }
            else
            {
                await DisplayAlertAsync("Error", "Hay errores en el formulario", "Continuar");
            }
        }

        private bool ValidateEntrys()
        {
            if (String.IsNullOrWhiteSpace(ResidueName.Text))
            {
                return false;
            }
            if (String.IsNullOrWhiteSpace(ResidueType.Text))
            {
                return false;
            }
            int num;
            if (!(int.TryParse(ResidueAmount.Text, out num)) && num < 1)
            {
                return false;
            }
            return true;
        }

        private void RemoveResidue_Clicked(object sender, EventArgs e)
        {
            if (listaResiduos.SelectedItem != null)
            {
                Residuo residuo = (Residuo)listaResiduos.SelectedItem;

                Residuos.Remove(residuo);

                listaResiduos.SelectedItem = null;
            }
        }
        private void Residuos_CollectionChanged(object sender, System.Collections.Specialized.NotifyCollectionChangedEventArgs e)
        {
            if (e.NewItems != null)
            {
                foreach (Residuo r in e.NewItems)
                {
                    r.PropertyChanged += Residuo_PropertyChanged;
                }
            }

            if (e.OldItems != null)
            {
                foreach (Residuo r in e.OldItems)
                {
                    r.PropertyChanged -= Residuo_PropertyChanged;
                }
            }

            ActualizarTotal();
        }

        // Detectar cuando cambia la cantidad de un residuo
        private void Residuo_PropertyChanged(object sender, System.ComponentModel.PropertyChangedEventArgs e)
        {
            if (e.PropertyName == nameof(Residuo.Cantidad))
            {
                ActualizarTotal();
            }
        }

        // Calcular la suma de todas las cantidades
        private void ActualizarTotal()
        {
            int total = 0;

            foreach (Residuo r in Residuos)
            {
                total += r.Cantidad;
            }

            TotalResiduos.Text = "Cantidad total: " + total;
        }

    }
}

