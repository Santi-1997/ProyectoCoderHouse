using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoIntegrador
{
    public class Venta
    {
        public int Id { get; set; }
        public string Comentarios { get; set; }

        public string GetDataVenta()
        {
            return $"Id:{Id} Comentarios:{Comentarios}";
        }
    }
}
