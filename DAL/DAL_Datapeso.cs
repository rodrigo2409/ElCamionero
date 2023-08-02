    using BEL;
    using System;
    using System.Collections.Generic;
    using System.Data;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

namespace DAL
{
    public class DAL_Datapeso : DAL_DataBase
    {
        public DataTable ListarDatapeso(BEL_Datapeso datapeso)
        {
            string strSQL = "select * from datapeso where nombre like '%" + datapeso.Peso + datapeso.Fechahorapeso;
            return GetDataTable(strSQL);
        }

        public bool Insertarpeso(BEL_Datapeso datapeso)
        {
            string strSQL= "INSERT INTO datapeso (peso, fechahorapeso) VALUES ('" + datapeso.Peso + "', '" + datapeso.Fechahorapeso + "')";
            return ExecTransacction(strSQL);
        }

    }
    
}
