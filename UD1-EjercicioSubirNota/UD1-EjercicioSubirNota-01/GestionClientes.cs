using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace UD1_EjercicioSubirNota_01
{
    public partial class GestionClientes : Form
    {
        public string[] ciudades = new string[] {
            "Sevilla","Córdoba", "Jaén",
            "Granada", "Almería", "Málaga", "Cádiz",
            "Huelva", "Antequera", "Jerez de la Frontera",
            "Ronda", "Nerja", "Algeciras", "Úbeda", "Baeza"
        };
        public List<Cliente> ClienteList;
        private int clienteSeleccionado = -1;
        private bool enModoModificacion = false;
        public GestionClientes()
        {
            InitializeComponent();
        }

        private void GestionClientes_Load(object sender, EventArgs e)
        {
            CBoxCity.DataSource = ciudades;
            ClienteList = new List<Cliente>();
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            if (!CamposRellenos())
            {
                MessageBox.Show("Porfavor, rellena todos los campos");
                return;
            }
            if (IdExistente())
            {
                MessageBox.Show("El id introducido ya existe");
                return;
            }

            // Crear nuevo cliente
            Cliente nuevoCliente = new Cliente
            {
                CodigoCliente = int.Parse(TxtbCode.Text),
                NombreCliente = TxtbName.Text.Trim(),
                ApellidoCliente = TxtbSurname.Text.Trim(),
                FechaNacimientoCliente = DtpkBirth.Value,
                Ciudad = CBoxCity.SelectedItem.ToString(),
                Telefono = (int)NudPhone.Value
            };

            // Agregar a la lista
            ClienteList.Add(nuevoCliente);

            // Refrescar DataGridView
            RefrescarDataGridView();

            // Limpiar campos
            LimpiarCampos();

            MessageBox.Show("Cliente agregado correctamente");
        }

        private void BtnModify_Click(object sender, EventArgs e)
        {
            if (clienteSeleccionado == -1)
            {
                MessageBox.Show("Selecciona un cliente de la lista para modificar");
                return;
            }

            if (!CamposRellenos())
            {
                MessageBox.Show("Porfavor, rellena todos los campos");
                return;
            }

            // Actualizar cliente
            ClienteList[clienteSeleccionado].NombreCliente = TxtbName.Text.Trim();
            ClienteList[clienteSeleccionado].ApellidoCliente = TxtbSurname.Text.Trim();
            ClienteList[clienteSeleccionado].FechaNacimientoCliente = DtpkBirth.Value;
            ClienteList[clienteSeleccionado].Ciudad = CBoxCity.SelectedItem.ToString();
            ClienteList[clienteSeleccionado].Telefono = (int)NudPhone.Value;

            // Refrescar DataGridView
            RefrescarDataGridView();

            // Limpiar campos
            LimpiarCampos();
            TxtbCode.Enabled = true;
            clienteSeleccionado = -1;
            enModoModificacion = false;

            MessageBox.Show("Cliente modificado correctamente");
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            if (clienteSeleccionado == -1)
            {
                MessageBox.Show("Selecciona un cliente de la lista para eliminar");
                return;
            }

            DialogResult resultado = MessageBox.Show("¿Estás seguro de que deseas eliminar este cliente?", "Confirmar eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (resultado == DialogResult.Yes)
            {
                // Eliminar cliente de la lista
                ClienteList.RemoveAt(clienteSeleccionado);

                // Refrescar DataGridView
                RefrescarDataGridView();

                // Limpiar campos
                LimpiarCampos();
                TxtbCode.Enabled = true;
                clienteSeleccionado = -1;

                MessageBox.Show("Cliente eliminado correctamente");
            }
        }

        private void BtnSaveJSON_Click(object sender, EventArgs e)
        {
            if (ClienteList.Count == 0)
            {
                MessageBox.Show("No hay clientes para guardar");
                return;
            }

            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Archivos JSON (*.json)|*.json";
            saveFileDialog.Title = "Guardar clientes como JSON";
            saveFileDialog.FileName = "clientes.json";

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    string json = GenerarJSON();
                    File.WriteAllText(saveFileDialog.FileName, json);
                    MessageBox.Show("Clientes guardados correctamente en: " + saveFileDialog.FileName);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al guardar el archivo: " + ex.Message);
                }
            }
        }

        private void BtnLoadJSON_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Archivos JSON (*.json)|*.json";
            openFileDialog.Title = "Cargar clientes desde JSON";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    string json = File.ReadAllText(openFileDialog.FileName);
                    List<Cliente> clientesCargados = ParserJSON(json);

                    if (clientesCargados != null && clientesCargados.Count > 0)
                    {
                        // Limpiar lista actual
                        ClienteList.Clear();

                        // Agregar clientes del JSON
                        ClienteList.AddRange(clientesCargados);

                        // Refrescar DataGridView
                        RefrescarDataGridView();

                        // Limpiar campos
                        LimpiarCampos();
                        clienteSeleccionado = -1;

                        MessageBox.Show("Clientes cargados correctamente: " + ClienteList.Count + " clientes");
                    }
                    else
                    {
                        MessageBox.Show("El archivo JSON no contiene clientes válidos");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al cargar el archivo: " + ex.Message);
                }
            }
        }

        private bool CamposRellenos()
        {
            if (String.IsNullOrWhiteSpace(TxtbCode.Text.Trim()))
            {
                return false;
            }
            if (String.IsNullOrWhiteSpace(TxtbName.Text.Trim()))
            {
                return false;
            }
            if (String.IsNullOrWhiteSpace(TxtbSurname.Text.Trim()))
            {
                return false;
            }
            if (CBoxCity.SelectedItem == null || String.IsNullOrWhiteSpace(CBoxCity.SelectedItem.ToString()))
            {
                return false;
            }
            if (NudPhone.Value == 0)
            {
                return false;
            }
            return true;
        }

        private bool IdExistente()
        {
            int codigo;
            if (!int.TryParse(TxtbCode.Text, out codigo))
            {
                return false;
            }
            foreach (Cliente cliente in ClienteList)
            {
                if (cliente.CodigoCliente == codigo)
                {
                    return true;
                }
            }
            return false;
        }

        private void LimpiarCampos()
        {
            TxtbCode.Clear();
            TxtbName.Clear();
            TxtbSurname.Clear();
            DtpkBirth.Value = DateTime.Now;
            CBoxCity.SelectedIndex = -1;
            NudPhone.Value = 0;
            TxtbCode.Focus();
        }

        private void RefrescarDataGridView()
        {
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = ClienteList;
        }

        private void CargarClienteEnCampos(int indice)
        {
            Cliente cliente = ClienteList[indice];
            TxtbCode.Text = cliente.CodigoCliente.ToString();
            TxtbName.Text = cliente.NombreCliente;
            TxtbSurname.Text = cliente.ApellidoCliente;
            DtpkBirth.Value = cliente.FechaNacimientoCliente;
            CBoxCity.SelectedItem = cliente.Ciudad;
            NudPhone.Value = cliente.Telefono;
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                clienteSeleccionado = e.RowIndex;
                CargarClienteEnCampos(clienteSeleccionado);
                TxtbCode.Enabled = false;
            }
        }

        private string GenerarJSON()
        {
            StringBuilder json = new StringBuilder();
            json.AppendLine("[");

            for (int i = 0; i < ClienteList.Count; i++)
            {
                Cliente cliente = ClienteList[i];
                json.AppendLine("    {");
                json.AppendLine("        \"CodigoCliente\": " + cliente.CodigoCliente + ",");
                json.AppendLine("        \"NombreCliente\": \"" + cliente.NombreCliente + "\",");
                json.AppendLine("        \"ApellidoCliente\": \"" + cliente.ApellidoCliente + "\",");
                json.AppendLine("        \"FechaNacimiento\": \"" + cliente.FechaNacimientoCliente + "\",");
                json.AppendLine("        \"Ciudad\": \"" + cliente.Ciudad + "\",");
                json.AppendLine("        \"Telefono\": " + cliente.Telefono);

                if (i < ClienteList.Count - 1)
                {
                    json.AppendLine("    },");
                }
                else
                {
                    json.AppendLine("    }");
                }
            }

            json.AppendLine("]");
            return json.ToString();
        }

        private List<Cliente> ParserJSON(string json)
        {
            List<Cliente> lista = new List<Cliente>();

            // Separar por objetos: cada bloque entre { y }
            int posicion = 0;
            while (true)
            {
                int inicio = json.IndexOf('{', posicion);
                if (inicio == -1) break;

                int fin = json.IndexOf('}', inicio);
                if (fin == -1) break;

                string bloque = json.Substring(inicio + 1, fin - inicio - 1);
                posicion = fin + 1;

                Cliente cliente = new Cliente();

                // Cada propiedad está en una línea: "Clave": valor,
                string[] lineas = bloque.Split(new[] { '\n', '\r' }, StringSplitOptions.RemoveEmptyEntries);
                foreach (string linea in lineas)
                {
                    int dosPuntos = linea.IndexOf(':');
                    if (dosPuntos == -1) continue;

                    string clave = linea.Substring(0, dosPuntos).Trim().Trim('"');
                    string valor = linea.Substring(dosPuntos + 1).Trim().TrimEnd(',').Trim().Trim('"');

                    switch (clave)
                    {
                        case "CodigoCliente":
                            cliente.CodigoCliente = int.Parse(valor);
                            break;
                        case "NombreCliente":
                            cliente.NombreCliente = valor;
                            break;
                        case "ApellidoCliente":
                            cliente.ApellidoCliente = valor;
                            break;
                        case "FechaNacimiento":
                            cliente.FechaNacimientoCliente = DateTime.Parse(valor);
                            break;
                        case "Ciudad":
                            cliente.Ciudad = valor;
                            break;
                        case "Telefono":
                            cliente.Telefono = int.Parse(valor);
                            break;
                    }
                }

                lista.Add(cliente);
            }

            return lista;
        }
    }
}
