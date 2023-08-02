using BEL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DAL_Productos : DAL_DataBase
    {
        public DataTable ListarProductos(BEL_Productos productos)
        {
            string strSQL = "select idproductos,nombre from productos where nombre like '%" + productos.Nombre + "%'";
            return GetDataTable(strSQL);
        }
        public bool Insertarproductos (BEL_Productos productos)
        {
            string strSQL = "INSERT INTO productos (nombre)VALUES('"+productos.Nombre+"')";
            return ExecTransacction(strSQL);
        }


    }
}
