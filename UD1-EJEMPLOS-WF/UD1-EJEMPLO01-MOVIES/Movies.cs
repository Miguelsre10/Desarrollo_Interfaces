using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UD1_EJEMPLO01_MOVIES
{
    public partial class Movies : Form
    {
        public Movies()
        {
            InitializeComponent();
        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                if (!string.IsNullOrEmpty(TxtMovie.Text))
                {
                    if (!CbMovies.Items.Contains(TxtMovie.Text))
                    {
                        CbMovies.Items.Add(TxtMovie.Text);
                        TxtMovie.Clear();
                        TxtMovie.Focus();
                    }
                    else
                    {
                        MessageBox.Show("Pelicuala repetida, escribe otra", "Advertencia del sistema");
                    }
                }
                else
                {
                    MessageBox.Show("Introduce una pelicula en la caja de texto", "Advertencia del sistema");
                }
            }
            catch (Exception ex) 
            {
                MessageBox.Show($"Error: {ex.Message}.","Error del sistema");
            }
        }

        private void CbMovies_SelectedIndexChanged(object sender, EventArgs e)
        {
            LblMovieR.Text = CbMovies.Text;
            LblMovieR.Visible = true;
        }
    }
}
