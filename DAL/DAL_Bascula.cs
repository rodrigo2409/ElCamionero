using BEL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DAL_Bascula:DAL_DataBase
    {
        public DataTable ListarBascula(BEL_Bascula bascula
            ) {

            string strSQL = "select * from bascula where nombrebascula like '%" + bascula.Nombrebascula + "%' and activo=1";
            return GetDataTable(strSQL);




        }


        public bool Insertarbascula(BEL_Bascula bascula)
        {
            string strSQL = "INSERT INTO bascula (nombrebascula, baudrate ,puerto, bitdedatos, paridad, bitparada, handskate ,activo ) VALUES ('" +bascula.Nombrebascula + "','"+bascula.Baudrate+"','"+bascula.Puerto+"','"+bascula.Bitdedatos+"','"+bascula.Paridad+"','"+bascula.Bitparada+"', '"+bascula.Handskate+"','"+bascula.Activo+"')";
            return ExecTransacction(strSQL);
        }

    }
}
