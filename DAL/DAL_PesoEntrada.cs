using BEL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DAL_PesoEntrada:DAL_DataBase
    {
        public DataTable listarpesoentrada(BEL_PesoEntrada pesoentrada)
        {
            string strSQL = "select idpesoentrada, provedor from pesoentrada where  date(fechahorapeso)='" + pesoentrada.Fechahorapeso + "'";
            return GetDataTable(strSQL);
        }

        public DataTable Reportepesoentrada(BEL_PesoEntrada pesoentrada)
        {
            string strSQL = "select * from pesoentrada  where idpesoentrada = '" + pesoentrada.Idpesoentrada + "'";
            return GetDataTable(strSQL);
        }

        public bool InsertarPesoEntrada(BEL_PesoEntrada pesoentrada)
        {
            string strSQL = "INSERT INTO pesoentrada ( fechahorapeso, producto,cajas, pesocaja, provedor, pesobruto, pesotara, pesoneto) VALUES ('"+pesoentrada.Fechahorapeso+"','"+pesoentrada.Producto+"','"+pesoentrada.Cajas+"', '"+pesoentrada.Pesocaja+"','"+pesoentrada.Provedor+"','"+pesoentrada.Pesobruto+"','"+pesoentrada.Pesotara+"','"+pesoentrada.Pesoneto+"')";
            return ExecTransacction(strSQL);
        }


       
    }

    
}
