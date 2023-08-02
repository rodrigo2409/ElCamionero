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
    public  class BLL_Provedor
    {
        public DataTable Listarprovedor (BEL_Provedor provedor)
        {
            DAL_Provedor dAL_Provedor = new DAL_Provedor();
            return dAL_Provedor.Listarprovedor(provedor);
        }
        public bool Insertarprovedor (BEL_Provedor provedor)
        {
            DAL_Provedor dAL_Provedor = new DAL_Provedor();
            return dAL_Provedor.Insertarprovedor(provedor);
        }
    }
}
