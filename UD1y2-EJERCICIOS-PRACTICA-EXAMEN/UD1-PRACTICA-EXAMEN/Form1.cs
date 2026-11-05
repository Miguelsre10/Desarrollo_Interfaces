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
    public partial class Form1 : Form
    {
        //Declarar datos para el enlace del binding
        public string[] tallas = new string[] { "S", "M", "L", "XL" };
        Resumen resumen;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            CbTallas.DataSource = tallas;
        }

        private bool ValidacionFormulario()
        {
            // Validar que el nombre no esté vacío
            if (string.IsNullOrWhiteSpace(TxtNombre.Text))
            {
                MessageBox.Show("El nombre no puede estar vacío.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            // Validar que se haya elegido una talla (verificar si es null)
            if (CbTallas.SelectedIndex == -1)
            {
                MessageBox.Show("Debe seleccionar una talla.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            // Validar que se haya elegido una distancia
            if (!RbtnDistancia5.Checked && !RbtnDistancia10.Checked && !RbtnDistanciaMM.Checked)
            {
                MessageBox.Show("Debe seleccionar una distancia.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            return true;
        }

        private int CalculoPrecio()
        {
            int descuento = 0;
            int precio = 0;
            if (ChkSocio.Checked)
            {
                descuento = 3;
            }

            if (RbtnDistancia5.Checked)
            {
                precio = 8;
            }
            if (RbtnDistancia10.Checked)
            {
                precio = 12;
            }
            if (RbtnDistancia5.Checked)
            {
                precio = 18;
            }
            return precio - descuento;
        }

        private void BtnResumen_Click(object sender, EventArgs e)
        {
            if (ValidacionFormulario())
            {
                // Si todas las validaciones pasan, abrir el formulario Resumen de forma modal
                
                using (resumen = new Resumen())
                {
                    // Pasar los datos de Form1 a Resumen usando string interpolation
                    // pasamos todo el contenido de las etiquetas
                    resumen.Nombre = $"Corredor: {TxtNombre.Text}";
                    resumen.Edad = $"Edad: {NumEdad.Value}";
                    resumen.Talla = $"Talla de camiseta: {CbTallas.SelectedItem}";
                    resumen.Socio = $"Socio del club: {(ChkSocio.Checked ? "Sí" : "No")}";
                    resumen.Precio = $"Precio: {CalculoPrecio()} €";

                    // Distania
                    if (RbtnDistancia5.Checked)
                        resumen.Distancia = "Distancia: 5 Km";
                    else if (RbtnDistancia10.Checked)
                        resumen.Distancia = "Distancia: 10 Km";
                    else if (RbtnDistanciaMM.Checked)
                        resumen.Distancia = "Distancia: Media Maratón";

                    // Mostrar el formulario modal
                    resumen.ShowDialog(this);
                }
                /*
                 * imlpica crear etiquetas con los nombre de los campos
                 * y etiquetas con los valores de los campos
                 * implica cambiar los tipo de 
                 *      edad a int
                 *      Socio a bool
                 *      Precio a int
                 *      
                 *  pasamos solo los valores de las etiquetas
                */
                /*
                using (resumen = new Resumen())
                {
                    // Pasar los datos de Form1 a Resumen
                    resumen.Nombre = TxtNombre.Text;
                    resumen.Edad = (int)NumEdad.Value;
                    resumen.Talla = CbTallas.SelectedItem.ToString();
                    resumen.Socio = ChkSocio.Checked;
                    resumen.Precio = CalculoPrecio();

                    // Determinar qué distancia se eligió
                    if (RbtnDistancia5.Checked)
                        resumen.Distancia = "5 Km";
                    else if (RbtnDistancia10.Checked)
                        resumen.Distancia = "10 Km";
                    else if (RbtnDistanciaMM.Checked)
                        resumen.Distancia = "Media Maratón";

                    // Mostrar el formulario modal
                    resumen.ShowDialog(this);
                }
                */
            }

        }

        private void BtnInscripcion_Click(object sender, EventArgs e)
        {
            if (ValidacionFormulario())
            {
                // Abrir cuadro de diálogo para guardar fichero
                SaveFileDialog saveFileDialog = new SaveFileDialog();
                saveFileDialog.Filter = "Ficheros de texto (*.txt)|*.txt|Todos los ficheros (*.*)|*.*";
                saveFileDialog.DefaultExt = "txt";
                saveFileDialog.FileName = $"Inscripcion {TxtNombre.Text}";

                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        // Preparar los datos para escribir en el fichero
                        string[] lineas = new string[]
                        {
                            $"Corredor: {TxtNombre.Text}",
                            $"Edad: {NumEdad.Value}",
                            $"Distancia: {ObtenerDistancia()}",
                            $"Talla de camiseta: {CbTallas.SelectedItem}",
                            $"Socio del club: {(ChkSocio.Checked ? "Sí" : "No")}",
                            $"Precio: {CalculoPrecio()} €"
                        };

                        // Escribir los datos en el fichero
                        System.IO.File.WriteAllLines(saveFileDialog.FileName, lineas);

                        // Mostrar mensaje con la ruta del fichero
                        MessageBox.Show(
                            $"Inscripción guardada correctamente en:\n{saveFileDialog.FileName}",
                            "Éxito",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Information
                        );
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(
                            $"Error al guardar el fichero:\n{ex.Message}",
                            "Error",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Error
                        );
                    }
                }
            }
        }

        private string ObtenerDistancia()
        {
            if (RbtnDistancia5.Checked)
                return "5 Km (8 €)";
            else if (RbtnDistancia10.Checked)
                return "10 Km (12 €)";
            else if (RbtnDistanciaMM.Checked)
                return "Media Maratón (18 €)";
            return "";
        }
    }
}
