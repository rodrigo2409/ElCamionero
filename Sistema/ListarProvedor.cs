using BEL;
using BLL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema
{
    public class ListarProvedor
    {
        BEL_Provedor BEL_Provedor = new BEL_Provedor();
        BLL_Provedor BLL_Provedor = new BLL_Provedor();

        public DataTable listarprovedor()
        {
            return traeprovedor("");
        }

        private DataTable traeprovedor (string nombre)
        {
            DataTable dtprovedor;
            BEL_Provedor.Nombre = nombre;
            return dtprovedor = BLL_Provedor.Listarprovedor(BEL_Provedor);
        }
    }
}
