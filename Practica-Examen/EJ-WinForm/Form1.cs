using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EJ_WinForm
{
    public partial class Form1 : Form
    {

        private const decimal PRECIO_5KM = 8;
        private const decimal PRECIO_10KM = 12;
        private const decimal PRECIO_MEDIA = 18;
        private const decimal SOCIO = 3;


        //public string[] Tallas = { "S", "M", "L", "XL"};
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //CBTallas.DataSource = Tallas;
        }

        private void BtnResumen_Click(object sender, EventArgs e)
        {
            if (!Validacion_Datos()) return;

            //MessageBox.Show(string.Join(Environment.NewLine, ObtenerResumen()));

            using (Form resumen = new FormResumen(ObtenerResumen()))
            {
                resumen.ShowDialog();
            }
        }

        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            if (!Validacion_Datos()) return;
        }

        private bool Validacion_Datos()
        {
            //Conprobar la validez de los datos
            if (TxtNombre.Text == "")
            {
                MessageBox.Show("Debe ingresar un nombre", "Alerta");
                return false;
            }

            if (CBTallas.SelectedIndex == -1)
            {
                MessageBox.Show("Debe seleccionar una talla", "Alerta");
                return false;
            }
            return true;
        }

        private decimal Calcular_Precio()
        {
            decimal precio = 0;

            if (RBtnDistancia5.Checked) precio = PRECIO_5KM;

            if (RBtnDistancia10.Checked) precio = PRECIO_10KM;

            if (RBtnDistanciaMM.Checked) precio = PRECIO_MEDIA;
       
            if (ChkSocio.Checked) precio -= SOCIO;

            return precio;
        }

        private string DistanciaElegida()
        {
            if (RBtnDistancia5.Checked) return "5Km";

            if (RBtnDistancia10.Checked) return "10Km";

            if (RBtnDistanciaMM.Checked) return "Media Maraton";

            return "";
        }

        private List<String> ObtenerResumen()
        {
            return new List<String>
            {
                "Corredor: " + TxtNombre.Text.Trim(),
                "Edad: " + NubEdad.Value.ToString(),
                "Distancia: " + DistanciaElegida(),
                "Talla de camiseta: " + CBTallas.SelectedText.Trim(),
                "Socio del Club: " + (ChkSocio.Checked ? "Si":"No"),
                "Precio: " + Calcular_Precio()
            };
        }
    }
}
