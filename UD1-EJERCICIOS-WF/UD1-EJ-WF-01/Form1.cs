using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UD1_EJ_WF_01
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int numSecreto;
        int trys = 5;

        private void BtnStart_Click(object sender, EventArgs e)
        {
            numSecreto = (int)NudJ1.Value;
            panelJ2.Visible = true;
            panelJ1.Visible = false;
        }

        private void BtnAdivinar_Click(object sender, EventArgs e)
        {
           int numAdv = (int)NudAdiv.Value;
            if (trys > 0)
            {
                trys--;
                if (numSecreto == numAdv)
                {
                    LblFin.Text = "Has acertado el numero secreto";
                }
                else
                {
                    if (trys == 0)
                    {
                        LblFin.Text = $"Te has quedado sin intentos\nEl numero secreto es {numSecreto}";
                    }
                    else if (numSecreto > numAdv)
                    {
                        LblFin.Text = $"El numero secreto es mayor que {numAdv}";
                    }
                    else
                    {
                        LblFin.Text = $"El numero secreto es menor que {numAdv}";
                    }
                }
                LblIntentos.Text = $"{trys}";   
            }
        }
    }
}
