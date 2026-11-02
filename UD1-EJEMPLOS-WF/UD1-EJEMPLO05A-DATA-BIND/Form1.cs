using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UD1_EJEMPLO05A_DATA_BIND
{
    public partial class Form1 : Form
    {
        //Declarar datos para el enlace del binding
        public string[] myCities = new string[] { "Lucena", "Cordoba", "Rute", "Cabra", "Montilla" };

        public List<City> CitiesList;
        public City cityLucena = new City()
        {
            CityName = "Lucena",
            PopulationName = 45000,
            CountryName = "España"
        };

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            CbCity.DataSource = myCities;
            //inicializamos la lista de ciudades
            CitiesList = new List<City>()
            {
                new City()
                {
                    CityName = "Sevilla",
                    PopulationName = 300000,
                    CountryName = "España"
                },
                new City()
                {
                    CityName = "Huelva",
                    PopulationName = 143000,
                    CountryName = "España"
                }
            };
            cityBindingSource.DataSource = CitiesList;
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                if (!CitiesList.Contains(cityLucena))
                {
                    CitiesList.Add(cityLucena);
                    cityBindingSource.DataSource = null;
                    cityBindingSource.DataSource = CitiesList;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error en el borrado:" + ex.Message);
            }
        }

        private void BtnDel_Click(object sender, EventArgs e)
        {
            try
            {
                foreach (City ciudad in CitiesList.ToList())
                {
                    if (ciudad.CityName == "Sevilla")
                    {
                        CitiesList.Remove(ciudad);
                        cityBindingSource.DataSource = null;
                        cityBindingSource.DataSource = CitiesList;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error en el borrado:" + ex.Message);
            }
        }
    }
}
