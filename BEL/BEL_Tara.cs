using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BEL
{
    public class BEL_Tara
    {
        #region Declaracion de atributos de la tabla tara
        private int _idtara;
        private string _numerotara;
        private string _pesotara;
        #endregion


        #region Encapsulamiento de datos
        public int Idtara { get => _idtara; set => _idtara = value; }
        public string Numerotara { get => _numerotara; set => _numerotara = value; }
        public string Pesotara { get => _pesotara; set => _pesotara = value; }

        #endregion

        public BEL_Tara()
        {

        }
        public BEL_Tara(int idtara, string numerotara, string pesotara)
        {
            Idtara = idtara;
            Numerotara = numerotara;
            Pesotara = pesotara;

        }
    }
}
