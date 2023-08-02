using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BEL
{
    public  class BEL_Provedor
    {

        #region Declaracion de atributos de la tabla Provedor 

        private int _Idprovedor;
        private string _Nombre;
        #endregion


        #region Encapsulamiento de datos
        public int Idprovedor { get => _Idprovedor; set=> _Idprovedor = value; }    
        public string Nombre { get => _Nombre; set => _Nombre = value; }
        #endregion

        public BEL_Provedor() { }

        public BEL_Provedor(int idprovedor, string nombre)
        {
            Idprovedor = idprovedor;
            Nombre = nombre;
            
        }
    }
}
