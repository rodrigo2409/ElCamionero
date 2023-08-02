using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using MySql.Data.MySqlClient;
using System.Data;

namespace DAL
{
    public class DAL_DataBase
    {
        #region Conexion a base de datos
        private string Conexion()
        {
            string cadena;
            cadena = ConfigurationManager.ConnectionStrings["ConexionMysql"].ConnectionString;
            return cadena;
        }
        #endregion

        #region Regresa un Datatable a partir de una consulta (query) select
        public DataTable GetDataTable(string strSQL)
        {
            try
            {
                using (MySqlConnection cn = new MySqlConnection(Conexion()))
                {
                    cn.Open();
                    using (MySqlCommand cmd = new MySqlCommand(strSQL, cn))
                    {
                        using (MySqlDataReader dr = cmd.ExecuteReader())
                        {
                            DataTable dt = new DataTable();
                            dt.Load(dr);
                            return dt;
                        }

                    }
                }
            }
            catch (Exception)
            {

                throw;
            }
        }
        #endregion

        #region Operaciones CRUD Transacction
        public bool ExecTransacction(string strSQL)
        {
            bool resultado = false;
            try
            {
                using(MySqlConnection cn = new MySqlConnection(Conexion()))
                {
                    cn.Open();
                    using (MySqlTransaction trx = cn.BeginTransaction())
                    {
                        try
                        {
                            using(MySqlCommand cmd= new MySqlCommand(strSQL, cn))
                            {
                                cmd.Transaction = trx;
                                cmd.ExecuteNonQuery();
                            }
                            trx.Commit();
                            resultado = true;
                        }
                        catch (Exception)
                        {
                            trx.Rollback();
                            resultado = false;
                            throw;
                        }
                    }
                }
            }
            catch (Exception)
            {

                throw;
            }
            return resultado;
        }
        #endregion

    }
}
