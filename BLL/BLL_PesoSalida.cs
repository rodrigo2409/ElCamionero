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
    public class BLL_PesoSalida
    {
        public bool InsertarPesoSalida(BEL_PesoSalida pesoSalida)
        {
            DAL_PesoSalida dAL_PesoSalida = new DAL_PesoSalida();
            return dAL_PesoSalida.InsertarPesoSalida(pesoSalida);
        }

        public DataTable Listarpesosalida (BEL_PesoSalida pesoSalida)
        {
            DAL_PesoSalida dAL_PesoSalida = new DAL_PesoSalida();
            return dAL_PesoSalida.Listarpesosalida(pesoSalida);
        }

        public DataTable Reportepesosalida (BEL_PesoSalida pesoSalida)
        {
            DAL_PesoSalida dAL_PesoSalida = new DAL_PesoSalida();
            return dAL_PesoSalida.Reportepesosalida(pesoSalida);
        }
    }
}
