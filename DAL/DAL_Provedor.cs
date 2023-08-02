using BEL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public  class DAL_Provedor : DAL_DataBase 
    {
        public DataTable Listarprovedor (BEL_Provedor provedor)
        {
            string strSQL = "select idprovedor, nombre from provedor where nombre like '%" +provedor.Nombre+ "%' ";
            return GetDataTable(strSQL);
        }
        public bool Insertarprovedor(BEL_Provedor provedor) {
            string strSQL = " INSERT INTO provedor (nombre) VALUES ('" + provedor.Nombre + "')";
            return ExecTransacction (strSQL);
        
        }
    }
}
