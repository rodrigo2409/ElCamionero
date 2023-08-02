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
    public class BLL_Cliente
    {

        public DataTable Listarcliente(BEL_Cliente cliente)
        {
            DAL_Cliente dAL_Cliente = new DAL_Cliente();
            return dAL_Cliente.Listarcliente(cliente);
        }

        public bool Insertarcliente (BEL_Cliente cliente) {
            DAL_Cliente dAL_Cliente = new DAL_Cliente();
            return dAL_Cliente.Insertarcliente(cliente);
        
        
        }
    }
}
