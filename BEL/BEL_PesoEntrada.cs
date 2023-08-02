using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace BEL
{
    public class BEL_PesoEntrada
    {
        #region Declaracion de atributos de la tabla datapeso
        private int _Idpesoentrada;
        private string _Fechahorapeso;
        
        private string _Prodructo;
        private string _cajas;
        private string _Pesocaja;
        private string _provedor;
        private string _Pesobruto;
        private string _Pesotara;
        private string _Pesoneto;
  
       


        #endregion

        #region Encapsulamiento de datos
        public int Idpesoentrada { get => _Idpesoentrada; set => _Idpesoentrada = value; }
        public string Fechahorapeso { get => _Fechahorapeso; set => _Fechahorapeso = value; }
        public string Producto { get => _Prodructo; set => _Prodructo = value; }
        public string Cajas { get => _cajas; set => _cajas = value; }
        public string Pesocaja { get => _Pesocaja; set => _Pesocaja = value; }
public string Provedor { get => _provedor; set => _provedor = value; }
        public string Pesobruto { get => _Pesobruto; set => _Pesobruto = value; }
        public string Pesotara { get => _Pesotara; set => _Pesotara = value; }
        public string Pesoneto { get => _Pesoneto; set => _Pesoneto = value; }
        
      


        #endregion

        //Constructor por defecto
        public BEL_PesoEntrada()
        {
        }

        //Constructor con parámetros
        public BEL_PesoEntrada(int idpesoentrada, string fechahorapeso, string producto, string cajas, string pesocaja ,string provedor,  string pesobruto, string pesotara, string pesoneto)
        {
           Idpesoentrada = idpesoentrada;
            Fechahorapeso = fechahorapeso;
          
            Producto = producto;
            Cajas = cajas;
            Pesocaja = pesocaja;
            Provedor = provedor;
            Pesobruto = pesobruto;  
            Pesotara = pesotara;
            Pesoneto = pesoneto;
            
           

        }


    }
}
