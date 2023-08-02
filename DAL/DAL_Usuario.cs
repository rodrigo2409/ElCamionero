using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BEL;

namespace DAL
{
    public class DAL_Usuario:DAL_DataBase {
        public DataTable ListarUsuario(BEL_Usuario usuario)
        {
            string strSQL = "select * from usuario where usuario = '" + usuario.Usuario + "' and contraseña= '" +usuario.Contraseña+ "' and activo=1";
            return GetDataTable(strSQL);
        }
        public bool Insertarusuario(BEL_Usuario usuario)
        {
            string strSQL = "INSERT INTO usuario (nombre, apellidopaterno, apellidomaterno, usuario, contraseña, idtipousuario , activo) VALUES ('"+usuario.Nombre + "','"+usuario.Apellidopaterno +"', '"+usuario.Apellidomaterno+"','"+usuario.Usuario+"','"+usuario.Contraseña+"','" + usuario.Idtipousuario + "','"+usuario.Activo+"')";
            return ExecTransacction(strSQL);
        }

    }
}
