using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BEL
{
    public class BEL_Tipousuario
    {
        #region Declaracion de atributos de la tabla tipousuario
        private int _Idtipousuario;
        private string _Tipo;
        

        #endregion

        #region Encapsulamiento de datos
      
        public int Idtipousuario { get => _Idtipousuario; set => _Idtipousuario = value; }
        public string Tipo { get => _Tipo; set => _Tipo = value; }

        #endregion

        //Constructor por defecto
        public BEL_Tipousuario()
        {
        }

        //Constructor con parámetros
        public BEL_Tipousuario(int idtipousuario, string tipo)
        {
           Idtipousuario = idtipousuario;
            Tipo = tipo;
        }


    }
}