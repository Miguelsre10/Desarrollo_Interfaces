using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UD1_EJEMPLO05A_DATA_BIND;

namespace UD1_EJEMPLO06_SECOND_FORM
{
    public partial class MainForm : Form
    {
        // Declarar Las variables para los formularios
        private Form student_form, teacher_form, family_form;
        public MainForm()
        {
            InitializeComponent();
        }

        private void BtnNewForm_Click(object sender, EventArgs e)
        {
            if (RbStudent.Checked)
            {
                //isDisposed nos indica si la ventana fue cerrada y eliminada
                if (student_form == null || student_form.IsDisposed)
                {
                    student_form = new FormStudent();
                    student_form.Show();// al cerrar destruye el objeto
                }
                else
                {
                    student_form.BringToFront();
                }
            }
            else if (RbTeachers.Checked)
            {
                using (teacher_form = new FormTeachers())
                {
                    teacher_form.ShowDialog();//cuando se cierra, oculta el objeto.
                }
            }
            else if(RbFamily.Checked)
            {
                using (family_form = new UD1_EJEMPLO05A_DATA_BIND.Form1()) //para uar esta forma
                                                                           //referencias mb2 -> agregar referencia
                {
                    family_form.ShowDialog();
                }
            }

        }








        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
