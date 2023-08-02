using BEL;
using DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class BLL_Tara
    {
        public bool InsertarTara(BEL_Tara tara)
        {

            DAL_Tara dAL_Tara = new DAL_Tara();
            return  dAL_Tara.InsertarTara(tara);
        }

        public DataTable ListarTara(BEL_Tara tara) {
            DAL_Tara dAL_Tara = new DAL_Tara();
            return dAL_Tara.ListarTara(tara);
        
        }
        public DataTable mostrarpeso (BEL_Tara tara)
        {
            DAL_Tara dAL_Tara=new DAL_Tara();
            return  dAL_Tara.mostrarpeso(tara);
        }
    }
}
