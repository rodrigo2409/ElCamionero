using BEL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public  class DAL_Cliente:DAL_DataBase
    {

        public DataTable Listarcliente (BEL_Cliente cliente )
        {
            string strSQL = "select * from cliente where nombre like '%" + cliente.Nombre + "%'  ";
            return GetDataTable( strSQL );
        }

        public bool Insertarcliente(BEL_Cliente cliente) {
            string strSQL = "INSERT INTO cliente (nombre) VALUES ('" + cliente.Nombre + "')";
            return ExecTransacction(strSQL);
        
        
        }
    }
}
