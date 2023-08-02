using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Net.Mime;
using System.Text;
using System.Threading.Tasks;
using BEL;
using BLL;

namespace Sistema
{
    
    public class DatosTara
    {
        BEL_Tara BEL_Tara = new BEL_Tara();
        BLL_Tara BLL_Tara = new BLL_Tara();



        public DataTable datostara()
        {
            return traedatostara("");
        }

        private DataTable  traedatostara(string numerotara) {
            DataTable dttara;
            BEL_Tara.Numerotara = numerotara;
            return dttara = BLL_Tara.ListarTara(BEL_Tara);
        
        
        }
    }
}
