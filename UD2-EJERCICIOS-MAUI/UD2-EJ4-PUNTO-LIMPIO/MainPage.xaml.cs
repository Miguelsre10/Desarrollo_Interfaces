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
        }


        private void AddResidue_Clicked(object sender, EventArgs e)
        {
            if (ValidateEntrys())
            {
                Residuos.Add(new Residuo()
                {
                    Nombre = ResidueName.Text,
                    Tipo = ResidueType.Text,
                    Cantidad = int.Parse(ResidueAmount.Text)
                });
            }
            else
            {

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
            if (int.Parse(ResidueAmount.Text) < 1)
            {
                return false;
            }
            return true;
        }

        private void RemoveResidue_Clicked(object sender, EventArgs e)
        {

        }
    }
}

