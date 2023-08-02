using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FastReport;
using FastReport.Export.Pdf;
using BEL;
using BLL;
using System.IO;

namespace Sistema
{
    public partial class Reporte : Form
    {
        public Reporte()
        {
            InitializeComponent();
            cargarReporte();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                BEL_PesoEntrada bEL_PesoEntrada = new BEL_PesoEntrada();
                BLL_PesoEntrada bLL_PesoEntrada = new BLL_PesoEntrada();
                bEL_PesoEntrada.Idpesoentrada = Convert.ToInt32(CboReportes.SelectedValue.ToString());
                bEL_PesoEntrada.Fechahorapeso = "";
                bEL_PesoEntrada.Producto = "";
                bEL_PesoEntrada.Cajas = "";
                bEL_PesoEntrada.Provedor = "";
                bEL_PesoEntrada.Pesobruto = "";
                bEL_PesoEntrada.Pesotara = "";
                bEL_PesoEntrada.Pesoneto = "";
                DataSet dspesoentrada = new DataSet();
                dspesoentrada.Tables.Add(bLL_PesoEntrada.Reportepesoentrada(bEL_PesoEntrada));
                
                
                MemoryStream ms = new MemoryStream();
                using (Report reporte = new Report())

               
                {
                    reporte.Load("EntradaPeso.frx");
                    reporte.RegisterData(dspesoentrada);
                    reporte.Design();// Cuando estes agregando cosas a tu reporte
                    //reporte.Show(); //Cuando este en produccion 
                    reporte.Dispose();


                    /* 
                     reporte.Design(); 
                     //reporte.Show(); 
                     reporte.Dispose();*/
                }
                ms.Position = 0;
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void cargarReporte()
        {
            BLL_PesoEntrada bLL_PesoEntrada = new BLL_PesoEntrada();
            BEL_PesoEntrada bEL_PesoEntrada = new BEL_PesoEntrada();
            DataTable dtreportes = new DataTable();
            bEL_PesoEntrada.Fechahorapeso = DateTime.Now.ToString("yyyy-MM-dd");

            dtreportes = bLL_PesoEntrada.listarpesoentrada(bEL_PesoEntrada);
            CboReportes.DisplayMember = "provedor";
            CboReportes.ValueMember = "idpesoentrada";
            CboReportes.DataSource = dtreportes;
            DataRow fila = dtreportes.NewRow();
            fila["provedor"] = "seleccione el provedor";
            dtreportes.Rows.InsertAt(fila, 0);
            CboReportes.DataSource = dtreportes;
            CboReportes.SelectedIndex = 0;
        }

        private void CboReportes_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
