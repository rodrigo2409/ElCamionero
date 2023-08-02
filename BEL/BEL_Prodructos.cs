using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace BEL
{
    public class BEL_Productos
    {
        #region Declaracion de atributos de la tabla usuario
        private int _Idproducto;
        private string _Nombre;
        

        #endregion

        #region Encapsulamiento de datos
        public int Idproducto { get => _Idproducto; set => _Idproducto = value; }
        public string Nombre { get => _Nombre; set => _Nombre = value; }

        #endregion

        //Constructor por defecto
        public BEL_Productos()
        {
        }

        //Constructor con parámetros
        public BEL_Productos(int idproductos, string nombre)
        {
           Idproducto = idproductos;
            Nombre = nombre;
        }


    }
}
