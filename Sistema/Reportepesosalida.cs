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
    public partial class Reportepesosalida : Form
    {
        public Reportepesosalida()
        {
            InitializeComponent();
            cargarreportesalida();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                BEL_PesoSalida bEL_PesoSalida = new BEL_PesoSalida();
                BLL_PesoSalida bLL_PesoSalida = new BLL_PesoSalida();
                bEL_PesoSalida.Idpesosalida = Convert.ToInt32(CboReportes.SelectedValue.ToString());
                bEL_PesoSalida.Fechahorapeso = "";
                bEL_PesoSalida.Cajas = "";
                bEL_PesoSalida.Cliente = "";
                bEL_PesoSalida.Producto = "";
                bEL_PesoSalida.Pesotara = "";
                bEL_PesoSalida.Pesobruto = "";
                bEL_PesoSalida.Pesoneto = "";
                DataSet dspesosalida = new DataSet();
                dspesosalida.Tables.Add(bLL_PesoSalida.Reportepesosalida(bEL_PesoSalida));
                MemoryStream ms = new MemoryStream();
                using (Report reporte = new Report())
                {
                    reporte.Load("PesoSalida.frx");
                    reporte.RegisterData(dspesosalida);
                    reporte.Design();
                   ///reporte.Show();
                    reporte.Dispose();

                }
                ms.Position = 0;

            }
            catch (Exception)
            {

                throw;
            }
        }
        private void cargarreportesalida()
        {
            BLL_PesoSalida bLL_PesoSalida = new BLL_PesoSalida();
            BEL_PesoSalida bEL_PesoSalida = new BEL_PesoSalida();
            DataTable dtreportesalia = new DataTable();
            bEL_PesoSalida.Fechahorapeso = DateTime.Now.ToString("yyyy-MM-dd");

            dtreportesalia = bLL_PesoSalida.Listarpesosalida(bEL_PesoSalida);
            CboReportes.DisplayMember = "cliente";
            CboReportes.ValueMember = "idpesosalida";
            CboReportes.DataSource = dtreportesalia;
            DataRow fila = dtreportesalia.NewRow();
            fila["cliente"] = "seleccione el cliente";
            dtreportesalia.Rows.InsertAt(fila, 0);
            CboReportes.DataSource = dtreportesalia;
            CboReportes.SelectedIndex = 0;

        }
    }
}
