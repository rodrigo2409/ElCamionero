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
    public  class BLL_PesoCaja
    {
        public bool InsertarPesoCaja(BEL_PesoCaja pesocaja) 
        { 
           DAL_PesoCaja dAL_PesoCaja = new DAL_PesoCaja();
            return dAL_PesoCaja.InsertarPesoCaja(pesocaja);
        
        }

        public DataTable ListarCaja(BEL_PesoCaja pesocaja)
        {
            DAL_PesoCaja dAL_PesoCaja = new DAL_PesoCaja();
            return dAL_PesoCaja.Listarcaja(pesocaja);

        }
    }
}
