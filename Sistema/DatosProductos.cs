using BEL;
using BLL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema
{
    public class DatosProductos
    {
       BEL_Productos BEL_Productos = new BEL_Productos();
        BLL_Productos BLL_Productos = new BLL_Productos();

        public DataTable datosproducto()
        {
            return traedatosproductos("");
        }
        private DataTable traedatosproductos (string nombre)
        {
            DataTable dtproductos;
            BEL_Productos.Nombre = nombre;
            return dtproductos = BLL_Productos.Productos(BEL_Productos);
        }
    }
}
