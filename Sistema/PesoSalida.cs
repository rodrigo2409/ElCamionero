using BEL;
using BLL;

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.Ports;
using System.Data.SqlClient;
using System.Text.RegularExpressions;

namespace Sistema
{
    public partial class PesoSalida : Form
    {
        BEL_PesoSalida BEL_PesoSalida =  new BEL_PesoSalida();
        BLL_PesoSalida bLL_PesoSalida = new BLL_PesoSalida();

        // variables globales de clase data bascula;
        private string nombrebascula = "";
        private string baudrate = "";
        private string puerto = "";
        private string bitdatos = "";
        private string paridad = "";
        private string bitparada = "";
        private string handskate = "";
        private string activo = "";
        //
        public PesoSalida()
        {
            InitializeComponent();
            CargarTaras();
            CargarCajas();
            cargarproductos();
            CargarClientes();

        }

        private void DatoRecivido(object sender, SerialDataReceivedEventArgs e)
        {
            
            string datain = SpPuertos.ReadExisting();
            TxtDatosRecibidos.Text = datain;
        }


        private void CargarTaras()
        {
            BLL_Tara bLL_Tara = new BLL_Tara();
            BEL_Tara bEL_Tara = new BEL_Tara();
            DataTable dttara = new DataTable();
            bEL_Tara.Numerotara = "";
            bEL_Tara.Pesotara = "";
            dttara = bLL_Tara.ListarTara(bEL_Tara);
            CboTaras.DisplayMember = "numerotara";
            CboTaras.ValueMember = "idtara";
            CboTaras.DataSource = dttara;
            

            DataTable dtmtarapeso = dttara;
            DataRow fila = dtmtarapeso.NewRow();
            fila["numerotara"] = "seleccione la tara";

            dtmtarapeso.Rows.InsertAt(fila, 0);

            CboTaras.DataSource = dtmtarapeso;
            CboTaras.SelectedIndex = 0;

            CboTaras.SelectedIndexChanged += (sender, e) =>
            {
                if (CboTaras.SelectedIndex >= 0 && CboTaras.SelectedIndex < dttara.Rows.Count)
                {

                   
                    bEL_Tara.Numerotara = dttara.Rows[CboTaras.SelectedIndex]["numerotara"].ToString();
                    bLL_Tara.mostrarpeso(bEL_Tara);
                    for (int i = 0; i < bLL_Tara.mostrarpeso(bEL_Tara).Rows.Count; i++)
                    {
                        txtpesotara.Text = bLL_Tara.mostrarpeso(bEL_Tara).Rows[i][1].ToString();
                    }
                }
                else
                {

                    txtpesotara.Text = "";
                }
            };



           


        }

        private string DataRecivida(String cadena)
        {
            string pattern = @"(\d+(?:\.\d+)?\s*)";
            MatchCollection matches = Regex.Matches(cadena, pattern);
            foreach (Match match in matches)
            {
                cadena = match.Value;
            }
            return cadena;
        }

        private string DataRecivido(String cadena)
        {
            string pattern = @"(\d+(?:\.\d+)?\s*(?:KG|kg|KGM|KGM))";
            MatchCollection matches = Regex.Matches(cadena, pattern);
            foreach (Match match in matches)
            {
                cadena = match.Value;
            }
            return cadena;
        }
        private void CargarCajas()
        {
            BLL_PesoCaja bLL_PesoCaja = new BLL_PesoCaja();
            BEL_PesoCaja bEL_PesoCaja = new BEL_PesoCaja();
            DataTable dtcajas = new DataTable();
            bEL_PesoCaja.Activo = "";
            dtcajas = bLL_PesoCaja.ListarCaja(bEL_PesoCaja);
            CboCajas.DisplayMember = "pesocaja";
            CboCajas.ValueMember = "idpesocaja";
            CboCajas.DataSource = dtcajas;
            DataTable dtpesocaja = dtcajas;
            DataRow fila = dtpesocaja.NewRow();
            fila["pesocaja"] = "seleccione el peso de la caja";
            dtpesocaja.Rows.InsertAt(fila, 0);
            CboCajas.DataSource = dtpesocaja;
            CboCajas.SelectedIndex = 0;
        }

        private void CargarClientes()
        {
            BLL_Cliente bLL_Cliente = new BLL_Cliente();
            BEL_Cliente bEL_Cliente = new BEL_Cliente();
            DataTable dtcliente = new DataTable();
            bEL_Cliente.Nombre = "";
            dtcliente = bLL_Cliente.Listarcliente(bEL_Cliente);
            CboCliente.DisplayMember = "nombre";
            CboCliente.ValueMember = "idcliente";
            CboCliente.DataSource = dtcliente;
            DataTable dtclientes = dtcliente;
            DataRow fila = dtclientes.NewRow();
            fila["nombre"] = "seleccione el cliente";
            dtclientes.Rows.InsertAt(fila, 0);
            CboCliente.DataSource = dtclientes;
            CboCliente.SelectedIndex = 0;

        }

        private void cargarproductos()
        {
            BLL_Productos bLL_Productos = new BLL_Productos();
            BEL_Productos bEL_Productos = new BEL_Productos();
            DataTable dtprodructos = new DataTable();

            dtprodructos = bLL_Productos.Productos(bEL_Productos);
            CboProdructos.DisplayMember = "nombre";
            CboProdructos.ValueMember = "idproductos";
            CboProdructos.DataSource = dtprodructos;
            DataTable dtproductos = dtprodructos;
            DataRow fila = dtprodructos.NewRow();
            fila["nombre"] = "seleccione el producto";
            dtprodructos.Rows.InsertAt(fila, 0);
            CboProdructos.DataSource = dtprodructos;
            CboProdructos.SelectedIndex = 0;
        }
        private void TxtNumeroTara_KeyPress(object sender, KeyPressEventArgs e)
        {
            Bascula basc = new Bascula();
            DataTable databascula = new DataTable();
            databascula = basc.ConectarBascula();

            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {


                for (int i = 0; i < databascula.Rows.Count;)
                {
                    nombrebascula = databascula.Rows[i][1].ToString();
                    baudrate = databascula.Rows[i][2].ToString();
                    puerto = databascula.Rows[i][3].ToString();
                    bitdatos = databascula.Rows[i][4].ToString();
                    paridad = databascula.Rows[i][5].ToString();
                    bitparada = databascula.Rows[i][6].ToString();
                    handskate = databascula.Rows[i][7].ToString();
                    activo = databascula.Rows[i][8].ToString();
                    
                    break;
                }

                
                SpPuertos.DataBits = Convert.ToInt32(bitdatos);
                if (paridad == "None")
                {
                    SpPuertos.Parity = Parity.None;
                }
                if (bitparada == "One")
                {
                    SpPuertos.StopBits = StopBits.One;
                }
                if (handskate == "None")
                {
                    SpPuertos.Handshake = Handshake.None;
                }
                if (handskate == "XOnXOff")
                {
                    SpPuertos.Handshake = Handshake.XOnXOff;
                }

                SpPuertos.PortName = puerto;

                SpPuertos.Open();

            }
        }



        private void txtpesotara_TextChanged(object sender, EventArgs e)
        {
            string datain = txtpesotara.Text;
            txtpesotara.Text = Convert.ToString(DataRecivida(datain));
            string dataon = TxtDatosRecibidos.Text;
            TxtDatosRecibidos.Text = Convert.ToString(DataRecivida(dataon));

            if (!TxtPesoneto.Text.Equals(null))
            {
                decimal dif = Convert.ToDecimal(TxtDatosRecibidos.Text.Trim()) - Convert.ToDecimal(txtpesotara.Text.Trim()) - (Convert.ToDecimal(CboCajas.Text.Trim()) * Convert.ToDecimal(txtNocajas.Text.Trim()));
                TxtPesoneto.Text = dif.ToString();

            }

        }
       
        private void PesoSalida_Load(object sender, EventArgs e)
        {

        }

        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                

                BEL_PesoSalida.Fechahorapeso = DateTime.Now.ToString("yyyy-MM-dd HH:m:ss");
                BEL_PesoSalida.Cajas = txtNocajas.Text;
                BEL_PesoSalida.Pesocaja = CboCajas.Text;
                BEL_PesoSalida.Cliente = CboCliente.Text;
                BEL_PesoSalida.Producto = CboProdructos.Text;
                BEL_PesoSalida.Pesotara = Convert.ToString(txtpesotara.Text);
                BEL_PesoSalida.Pesobruto = Convert.ToString(DataRecivida(TxtDatosRecibidos.Text));
                BEL_PesoSalida.Pesoneto = Convert.ToString(TxtPesoneto.Text);
                bLL_PesoSalida.InsertarPesoSalida(BEL_PesoSalida);
                MessageBox.Show("DATOS GUARDADOS", "ATENCION", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void TxtDatosRecibidos_TextChanged(object sender, EventArgs e)
        {
            
        }
    }
}
