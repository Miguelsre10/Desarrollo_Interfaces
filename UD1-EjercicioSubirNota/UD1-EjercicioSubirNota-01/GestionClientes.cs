using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UD1_EjercicioSubirNota_01
{
    public partial class GestionClientes : Form
    {
        public List<Cliente> ClienteList;
        public GestionClientes()
        {
            InitializeComponent();
        }

        private void GestionClientes_Load(object sender, EventArgs e)
        {
            ClienteList = new List<Cliente>();
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            if (!CamposRellenos())
            {
                MessageBox.Show("Porfavor, rellena todos los campos");
            }
            if (IdExistente())
            {
                MessageBox.Show("El id introducido ya existe");
            }

            

        }

        private void BtnModify_Click(object sender, EventArgs e)
        {

        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {

        }

        private void BtnSaveJSON_Click(object sender, EventArgs e)
        {

        }

        private void BtnLoadJSON_Click(object sender, EventArgs e)
        {

        }

        private bool CamposRellenos()
        {
            if (String.IsNullOrWhiteSpace(TxtbCode.Text.Trim()))
            {
                return false;
            }
            return true;
        }

        private bool IdExistente()
        {
            return false;
        }
    }
}
