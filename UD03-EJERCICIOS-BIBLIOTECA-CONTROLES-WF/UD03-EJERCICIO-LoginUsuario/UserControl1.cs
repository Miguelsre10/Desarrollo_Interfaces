using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UD03_EJERCICIO_LoginUsuario
{
    
    public partial class UserControl1: UserControl
    {
        public string user => TxbUser.Text;
        public string pass => TxbPass.Text;
        public UserControl1()
        {
            InitializeComponent();
        }

        private void TxbUser_TextChanged(object sender, EventArgs e)
        {
            if(!String.IsNullOrWhiteSpace(TxbUser.Text) && TxbUser.Text.Length <= 15)
            {
                TxbPass.Enabled = true;
            }
            else
            {
                TxbPass.Enabled = false;
            }
        }
    }
}
