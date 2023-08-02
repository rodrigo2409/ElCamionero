using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace BEL
{
    public class BEL_PesoSalida
    {
        #region Declaracion de atributos de la tabla datapeso
        private int _Idpesosalida;
        private string _Fechahorapeso;
        private string _Cajas;
        private string _Pesocaja;
        private string _Cliente;
        private string _Prodrcto;
        private string _Pesotara;
        private string _Pesobruto;
        private string _Pesoneto;

        #endregion

        #region Encapsulamiento de datos
        public int Idpesosalida { get => _Idpesosalida; set => _Idpesosalida = value; }
        public string Fechahorapeso { get => _Fechahorapeso; set => _Fechahorapeso = value; }
        public string Cajas { get => _Cajas; set => _Cajas = value; }  
        public string Pesocaja { get => _Pesocaja; set => _Pesocaja = value; }
        public string Cliente { get => _Cliente; set => _Cliente = value; }
        public string Producto { get => _Prodrcto; set => _Prodrcto = value; }
        public string Pesotara { get => _Pesotara; set => _Pesotara = value; }
        public string Pesobruto { get => _Pesobruto; set => _Pesobruto = value; }
        public string Pesoneto { get => _Pesoneto; set => _Pesoneto = value; }
        


        #endregion

        //Constructor por defecto
        public BEL_PesoSalida()
        {
        }

        //Constructor con parámetros
        public BEL_PesoSalida(int idpesosalida, string fechahorapeso, string cajas, string pesocaja ,string cliente ,string producto, string pesotara, string pesobruto, string pesoneto)
        {
            Idpesosalida = idpesosalida;
            Fechahorapeso = fechahorapeso;
            Cajas = cajas;
            Pesocaja = pesocaja;
            Cliente = cliente;
            Producto = producto;
            Pesotara = pesotara;
            Pesobruto = pesobruto;
            Pesoneto = pesoneto;

        }


    }
}
