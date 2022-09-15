using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class EntidadesTienda
    {
        public EntidadesTienda(int idProducto, string nombre, string descripcion, double precio)
        {
            this.idProducto = idProducto;
            Nombre = nombre;
            Descripcion = descripcion;
            Precio = precio;
        }

        public int idProducto { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public double Precio { get; set; }
    }
}
