using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BEL
{
    public class BEL_Bascula
    {
        #region Declaracion de atributos de la tabla bascula
        private int _Idbascula;
        private string _Nombrebascula;
        private string _Baudrate;
        private string _Puerto;
        
        private string _Bitdedatos;
        private string _Paridad;
        private string _Bitparada;
       
        private string _Handskate;
        private string _Activo;
        #endregion

        #region Encapsulamiento de datos
        public int Idbascula { get => _Idbascula; set => _Idbascula = value; }
        public string Nombrebascula { get => _Nombrebascula; set => _Nombrebascula = value; }
        public string Baudrate { get => _Baudrate; set => _Baudrate = value; }
        public string Puerto { get => _Puerto; set => _Puerto = value; }
        
        public string Bitdedatos { get => _Bitdedatos; set => _Bitdedatos = value; }
        public string Paridad { get => _Paridad; set => _Paridad = value; }
        public string Bitparada { get => _Bitparada; set => _Bitparada = value; }
        public string Handskate { get => _Handskate; set => _Handskate = value; }

      


        public string Activo { get => _Activo; set => _Activo = value; }
        #endregion

        //Constructor por defecto
        public BEL_Bascula()
        {
        }

        //Constructor con parámetros
        public BEL_Bascula(int idbascula, string nombrebascula,  string baudrate, string puerto, string bitdedatos, string paridad, string bitparada ,string handskate , string activo)
        {
            Idbascula = idbascula;
            Nombrebascula = nombrebascula;
            Baudrate = baudrate;
            Puerto = puerto;
            Bitdedatos = bitdedatos;
            Paridad = paridad;
            Bitparada = bitparada;
            Handskate = handskate;
            Activo = activo;
        }
    }
}
