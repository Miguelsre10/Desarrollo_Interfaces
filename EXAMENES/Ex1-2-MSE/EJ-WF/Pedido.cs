using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EJ_WF
{
    public class Pedido
    {
        public string Descripcion{ get; set; }
        public DateTime Fecha { get; set; }
        public string Codigo_Pedido { get; set; }


        public Pedido(string descripcion, DateTime fecha, string codigo_pedido)
        {
            this.Descripcion = descripcion;
            this.Fecha = fecha;
            this.Codigo_Pedido = codigo_pedido;
        }

    }
}
