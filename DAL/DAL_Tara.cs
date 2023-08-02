using BEL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DAL_Tara : DAL_DataBase
    {

        public bool InsertarTara(BEL_Tara tara)
        {
            string strSQL = "INSERT INTO tara(numerotara, pesotara) VALUES ('" + tara.Numerotara + "', '" + tara.Pesotara + "')";
            return ExecTransacction(strSQL);
        }

        public DataTable ListarTara(BEL_Tara tara)
        {
            string strSQL = "select idtara,numerotara from tara where numerotara like '%" + tara.Numerotara + "%'";
            return GetDataTable(strSQL);
        }
        public DataTable mostrarpeso(BEL_Tara tara)
        {
            string strSQL = "select numerotara, pesotara from tara where numerotara like '%" + tara.Numerotara + "%'";
            return GetDataTable(strSQL);
        }


    }

 }
    

