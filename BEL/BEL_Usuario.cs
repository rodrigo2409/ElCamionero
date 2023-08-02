using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BEL
{
    public class BEL_Usuario
    {
        #region Declaracion de atributos de la tabla usuario
        private int _Idusuario;
        private string _Nombre;
        private string _Apellidopaterno;
        private string _Apellidomaterno;
        private string _usuario;
        private string _Contraseña;
        private int _Idtipousuario;
        private string _Activo;
        #endregion

        #region Encapsulamiento de datos
        public int Idusuario { get => _Idusuario; set => _Idusuario = value; }
        public string Nombre { get => _Nombre; set => _Nombre = value; }
        public string Apellidopaterno { get => _Apellidopaterno; set => _Apellidopaterno = value; }
        public string Apellidomaterno { get => _Apellidomaterno; set => _Apellidomaterno = value; }
        public string Usuario { get => _usuario; set => _usuario = value; }
        public string Contraseña { get => _Contraseña; set => _Contraseña = value; }
        public int Idtipousuario { get => _Idtipousuario; set => _Idtipousuario = value; }
        public string Activo { get => _Activo; set => _Activo = value; }
        #endregion

        //Constructor por defecto
        public BEL_Usuario()
        {
        }
        //Constructor con parámetros
        public BEL_Usuario(int idusuario, string nombre, string apellidopaterno, string apellidomaterno, string usuario, string contraseña, int idtipousuario ,string activo)
        {
            Idusuario = idusuario;
            Nombre = nombre;
            Apellidopaterno = apellidopaterno;
            Apellidomaterno = apellidomaterno;
            Usuario = usuario;
            Contraseña = contraseña;
            Idtipousuario = idtipousuario;
            Activo = activo;
        }

       
    }

    
}
