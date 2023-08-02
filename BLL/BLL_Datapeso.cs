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
    public class BLL_Datapeso
    {

        public DataTable ListarDatapeso(BEL_Datapeso datapeso)
        {
            DAL_Datapeso daldatapeso = new DAL_Datapeso();
            return daldatapeso.ListarDatapeso(datapeso);
        }

        public bool Insertarpeso(BEL_Datapeso datapeso)
        {
            DAL_Datapeso dAL_Datapeso = new DAL_Datapeso();
            return dAL_Datapeso.Insertarpeso(datapeso);
        }



    }
}
