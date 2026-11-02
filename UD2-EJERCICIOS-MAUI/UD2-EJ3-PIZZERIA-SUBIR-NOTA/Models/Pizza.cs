using System;
using System.Collections.Generic;
using System.Text;

namespace UD2_EJ3_PIZZERIA_SUBIR_NOTA.Models
{
    public sealed class Pizza
    {
        public string? Tipo { get; set; }
        public int Cantidad { get; set; }

        public bool QuesoExtra { get; set; }
        public bool Jamon { get; set; }
        public bool Champinones { get; set; }
        public bool Aceitunas { get; set; }
        public bool Pimientos { get; set; }
        public DateTime? FechaEntraga { get; set; }
        private static Pizza? instancia;

        public static Pizza Instancia
        {
            get
            {
                if (instancia == null)
                {
                    instancia = new Pizza();
                }
                return instancia;
            }
        }
    }
}
