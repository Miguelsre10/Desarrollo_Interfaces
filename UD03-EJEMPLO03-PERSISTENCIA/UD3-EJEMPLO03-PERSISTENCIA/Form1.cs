using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UD3_EJEMPLO03_PERSISTENCIA
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            LoadData();
        }

        private void LoadData()
        {
            //Cargamos los datos de la configuracion de nuestra aplicacion
            this.BackColor = Properties.Settings.Default.BackColor;
            this.TxtUser.Text = Properties.Settings.Default.User;
        }

        private void BtnBackground_Click(object sender, EventArgs e)
        {
            //Mostramos el dialogo del color y lo asignamos a nuestro formulario
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                this.BackColor = colorDialog1.Color;
            }
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            //Guardamos el color del fondo en nuestra variable de configuracion
            Properties.Settings.Default.BackColor = this.BackColor;
            Properties.Settings.Default.User = this.TxtUser.Text;
            
            Properties.Settings.Default.Save();

        }
    }
}
