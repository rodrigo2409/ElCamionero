using BEL;
using DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class BLL_Productos
    {


        public DataTable Productos(BEL_Productos productos)
        {
            DAL_Productos dalproductos = new DAL_Productos();
            return dalproductos.ListarProductos(productos);
        }

        public bool InsertarProductos(BEL_Productos productos)
        {
            DAL_Productos dAL_Productos = new DAL_Productos();
            return dAL_Productos.Insertarproductos(productos);
        }

        
    }
 }


