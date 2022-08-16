using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoIntegrador
{
    public class Producto
    {
        public int Id { get; set; }
        public string? Descripciones { get; set; }
        public double Costo { get; set; }
        public double PrecioVenta { get; set; }
        public int Stock { get; set; }
        public int IdUsuario { get; set; }

        public string GetDataProducto()
        {
            return $"Id:{Id} Descripciones:{Descripciones} Costo:{Costo} PrecioVenta:{PrecioVenta} Stock:{Stock} IdUsuario: {IdUsuario}";
        }

    }

}
