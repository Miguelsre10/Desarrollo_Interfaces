using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UD1_PRACTICA_EXAMEN
{
    public partial class Resumen : Form
    {
        // Propiedades públicas para recibir datos de Form1
        public string Nombre { get; set; }
        public string Edad { get; set; }
        public string Distancia { get; set; }
        public string Talla { get; set; }
        public string Socio { get; set; }
        public string Precio { get; set; }

        public Resumen()
        {
            InitializeComponent();
        }

        private void Resumen_Load(object sender, EventArgs e)
        {
            // Asignar los valores recibidos a los labels
            this.TxtCorredor.Text = Nombre;
            this.TxtEdad.Text = Edad;
            this.TxtDistancia.Text = Distancia;
            this.TxtTalla.Text = Talla;
            this.TxtSocio.Text = Socio;
            this.TxtPrecio.Text = Precio;
        }

        private void BtnCerrar_Click(object sender, EventArgs e)
        {
            //cierra la ventana
            this.Close();
        }
    }
}
