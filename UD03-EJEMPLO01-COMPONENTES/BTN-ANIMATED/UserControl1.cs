using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BTN_ANIMATED
{
    public partial class UserControl1: UserControl
    {
        private int _contador = 0;
        public int Contador { 
            get => _contador; 
            set => _contador = value; 
        }
        public UserControl1()
        {
            InitializeComponent();
        }

        private void BtnAnimated_MouseHover(object sender, EventArgs e)
        {
            BtnAnimated.ForeColor = Color.White;
            BtnAnimated.BackColor = Color.Teal;
        }

        private void BtnAnimated_MouseLeave(object sender, EventArgs e)
        {
            BtnAnimated.ForeColor = Control.DefaultForeColor;
            BtnAnimated.BackColor = Control.DefaultBackColor;
        }

        private void BtnAnimated_Click(object sender, EventArgs e)
        {
            LbAnimated.Text = Contador == 0 ? $"Has clickado {++Contador} vez" : $"Has clickado {++Contador} veces";
        }
    }
}
