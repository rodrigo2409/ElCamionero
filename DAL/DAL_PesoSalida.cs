using BEL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DAL_PesoSalida : DAL_DataBase
    {
        public DataTable Listarpesosalida(BEL_PesoSalida pesoSalida)
        {
            string strSQL = "select idpesosalida,  cliente from pesosalida  where  date(fechahorapeso)='"+ pesoSalida.Fechahorapeso +"'";
            //string strSQL = "select idpesosalida,  pesoneto from pesosalida  where date(fechahorapeso)="+ pesoSalida.Fechahorapeso +" and pesoneto like '%" + pesoSalida.Pesoneto + "%'";
            return GetDataTable(strSQL);
        }
        public bool InsertarPesoSalida(BEL_PesoSalida pesosalida)
        {
            string strSQL = "INSERT INTO pesosalida (fechahorapeso, cajas, pesocaja ,cliente ,producto, pesotara, pesobruto, pesoneto) VALUES ('" + pesosalida.Fechahorapeso + "', '" + pesosalida.Cajas + "','"+pesosalida.Pesocaja+"','"+pesosalida.Cliente+"' ,'" + pesosalida.Producto + "','"+pesosalida.Pesotara+"','"+pesosalida.Pesobruto+"','"+pesosalida.Pesoneto+"')";
            return ExecTransacction(strSQL);
        }
        public DataTable Reportepesosalida (BEL_PesoSalida pesoSalida) { 
        
        string strSQL = "select * from pesosalida  where idpesosalida = '" + pesoSalida.Idpesosalida + "'";
            return GetDataTable(strSQL);
        }
    }
}
