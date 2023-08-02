using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BEL
{
    public class BEL_Cliente
    {
        #region Declaracion de atributos de la tabla Cliente

        private int _Idcliente;
        private string _Nombre;
        #endregion


        #region     

        public int Idcliente { get => _Idcliente; set => _Idcliente = value; }
        public string Nombre { get => _Nombre; set => _Nombre = value; }
        #endregion

        public BEL_Cliente() { }

        public BEL_Cliente(int idcliente, string nombre ) {
            Idcliente = idcliente;
            Nombre = nombre;
        
        }




    }
}
