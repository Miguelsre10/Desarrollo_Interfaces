using System;
using System.Collections.Generic;
using System.Text;

namespace Ej_MAUI.Models
{
    public sealed class Pizza
    {
        public string? Tipo { get; set; }
        public int Cantidad { get; set; }

        public bool Jamon { get; set; }
        public bool Champinones { get; set; }
        public bool Aceitunas { get; set; }
        public bool Pina { get; set; }
        public bool domicilio { get; set; }
        public decimal p_domicilio { get; set; }
        public decimal total { get; set; }


        public Pizza ()
        {
            Jamon = false;
            Champinones = false;
            Aceitunas = false;
            Pina = false;
            domicilio = false;
        }

    }
}
