using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BEL
{
    public  class BEL_PesoCaja
    {
        #region Declaracion de atributos de la tabla pesocaja
        private int _idpesocaja;
        private string _pesocaja;
        private string _activo;
        #endregion
        #region Encapsulamiento de datos
        public int Idpesocaja { get => _idpesocaja; set => _idpesocaja = value; }
        public string Pesocaja { get => _pesocaja;set=> _pesocaja = value; }
        public string Activo { get => _activo; set => _activo = value; }
        #endregion


        public BEL_PesoCaja() 
        {
            }
            
        public BEL_PesoCaja(int idpesocaja, string pesocaja, string activo)
        {
            Idpesocaja = idpesocaja;
            Pesocaja = pesocaja;
            Activo = activo;
        }

    }
}
