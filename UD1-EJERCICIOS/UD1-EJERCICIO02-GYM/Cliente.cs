using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UD1_EJERCICIO02_GYM
{
    internal class Cliente
    {
        public int CodigoCliente {  get; set; }
        public string NombreCliente { get; set; }
        public string ApellidoCliente { get; set; }

        public Cliente(int codigo, string nombre, string apellido)
        {
            CodigoCliente = codigo;
            NombreCliente = nombre;
            ApellidoCliente = apellido;
        }
    }
}
