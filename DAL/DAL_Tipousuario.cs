using BEL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DAL_Tipousuario : DAL_DataBase
    {
        public DataTable ListarTipousuario(BEL_Tipousuario tipousuario)
        {
            string strSQL = "select * from tipousuario where nombre like '%" + tipousuario.Tipo;
            return GetDataTable(strSQL);
        }
    }
}