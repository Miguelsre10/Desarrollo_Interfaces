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
    public partial class FormResumen : Form
    {
        public FormResumen(List<String> resumen)
        {
            InitializeComponent();
            TxtResumen.Text = string.Join(Environment.NewLine, resumen);
        }

        private void BtnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
