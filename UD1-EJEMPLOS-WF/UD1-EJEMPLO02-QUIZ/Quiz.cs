using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UD1_EJEMPLO02_QUIZ
{
    public partial class Quiz : Form
    {
        public Quiz()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void GbxEspecialidad_Enter(object sender, EventArgs e)
        {

        }

        private void BtnInforme_Click(object sender, EventArgs e)
        {
            //Creamos una variable para guradar toda la informacion del usuario
            string message_user = "Tú sistema operativo preferido es: ";
            //comprobamos si los radio button estans seleccionados
            message_user += CheckMyRadioButton(RbtnWin);
            message_user += CheckMyRadioButton(RbtnLinux);
            message_user += CheckMyRadioButton(RbtnMacos);

            message_user += ", tus especialidades elegidas son ";
            message_user += CheckMyChekBox(ChkbProgram);
            message_user += CheckMyChekBox(ChkbDesign);
            message_user += CheckMyChekBox(ChkbNetwork);

            //metodo para quitar la ultima coma y espacio en blanco
            message_user = message_user.TrimEnd(' ', ',');

            message_user += " y tus horas de uso son " + NudHours.Value;

            MessageBox.Show(message_user, "Informe");

        }

        private string CheckMyChekBox(CheckBox chkb)
        {
            if (chkb.Checked) return chkb.Text + ", ";
            return "";
        }

        private string CheckMyRadioButton(RadioButton rbtn)
        {
            if (rbtn.Checked) return rbtn.Text;
            return "";
        }
    }
}
