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
    public class BLL_PesoEntrada
    {
        public bool InsertarPesoEntrada(BEL_PesoEntrada pesoEntrada)
        {
            DAL_PesoEntrada dAL_PesoEntrada = new DAL_PesoEntrada();
            return dAL_PesoEntrada.InsertarPesoEntrada(pesoEntrada);
        }

        public DataTable Reportepesoentrada(BEL_PesoEntrada pesoentrada)
        {
            DAL_PesoEntrada dAL_PesoEntrada = new DAL_PesoEntrada();
            return dAL_PesoEntrada.Reportepesoentrada(pesoentrada);
        }

        public DataTable listarpesoentrada(BEL_PesoEntrada pesoentrada)
        {
            DAL_PesoEntrada dAL_PesoEntrada = new DAL_PesoEntrada();
            return dAL_PesoEntrada.listarpesoentrada(pesoentrada);


        }
    }
}
