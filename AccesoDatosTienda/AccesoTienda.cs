using ConectarRedReal;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccesoDatosTienda
{
    public class AccesoTienda : IEntidades
    {
        Base b = new Base("localhost", "root", "", "ajedrez");
        public void Borrar(dynamic Entidad)
        {
            string.Format("call insertarproductos({0},'{1}','{2}',{3});", Entidad.idProducto,Entidad.Nombre,Entidad.Descripcion,Entidad.Precio);
        }

        public void Guardar(dynamic Entidad)
        {
            string.Format("call insertarproductos({0});",Entidad.idProducto);
        }

        public DataSet Mostrar(string filtro)
        {
            return b.Obtener(string.Format("call showproductos('%{0}%')",filtro),"producto");
        }
    }
}
