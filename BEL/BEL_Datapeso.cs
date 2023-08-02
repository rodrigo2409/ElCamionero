using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace BEL
{
    public class BEL_Datapeso
    {
        #region Declaracion de atributos de la tabla datapeso
        private int _Iddatapeso;
        private string _Peso;
        private string _Fechahorapeso;
     

        #endregion

        #region Encapsulamiento de datos
        public int Iddatapeso { get => _Iddatapeso; set => _Iddatapeso = value; }
        public string Peso { get => _Peso; set => _Peso = value; }
        public string Fechahorapeso { get => _Fechahorapeso; set => _Fechahorapeso = value; }
     


        #endregion

        //Constructor por defecto
        public BEL_Datapeso()
        {
        }

        //Constructor con parámetros
        public BEL_Datapeso(int iddatapeso, string peso, string fechahorapeso, string tipopeso, string idusuario)
        {
           Iddatapeso = iddatapeso;
            Peso = peso;
            Fechahorapeso= fechahorapeso;
            
        }

       
    }
}
