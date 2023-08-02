using BEL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DAL_PesoCaja : DAL_DataBase
    {
        public bool InsertarPesoCaja(BEL_PesoCaja pesocaja) {
            string strSQL = "INSERT INTO pesocaja(pesocaja, activo) VALUES ('"+pesocaja.Pesocaja+"', '"+pesocaja.Activo+"')";
            return ExecTransacction(strSQL);
        }
        public DataTable Listarcaja(BEL_PesoCaja pesoCaja)
        {
            string strSQL = "select idpesocaja,pesocaja from pesocaja where activo like '%" + pesoCaja.Pesocaja + "%'";
            return GetDataTable(strSQL);
        }


    }
}
