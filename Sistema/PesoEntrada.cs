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
    public partial class PesoEntrada : Form
    {
       
        BEL_PesoEntrada BEL_PesoEntrada = new BEL_PesoEntrada();
        BLL_PesoEntrada BLL_PesoEntrada = new BLL_PesoEntrada ();
        BEL_Productos BEL_Productos = new BEL_Productos();
        BLL_Productos BLL_Productos = new BLL_Productos();
         
       

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

        // variables globales de clase data bascula;
       
        //


        public PesoEntrada()
        {
            InitializeComponent();
            CargarTaras();
            CargarCajas();
            cargarproductos();
            Cargarprovedor();


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
                   
                    
                    bEL_Tara.Numerotara= dttara.Rows[CboTaras.SelectedIndex]["numerotara"].ToString();
                    bLL_Tara.mostrarpeso(bEL_Tara);
                    for( int i=0;i< bLL_Tara.mostrarpeso(bEL_Tara).Rows.Count; i++)
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

        private void CargarCajas(){
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
            fila["pesocaja"] = "seleccione caja";
            dtpesocaja.Rows.InsertAt(fila, 0);
            CboCajas.DataSource = dtpesocaja;
            CboCajas.SelectedIndex = 0;
        }
        private void Cargarprovedor()
        {
            BLL_Provedor bLL_Provedor = new BLL_Provedor();
            BEL_Provedor bEL_Provedor = new BEL_Provedor();
            DataTable dtprovedor = new DataTable();

            bEL_Provedor.Nombre = "";
            dtprovedor = bLL_Provedor.Listarprovedor(bEL_Provedor);
            CboProvedor.DisplayMember = "nombre";
            CboProvedor.ValueMember = "idprovedor";
            CboProvedor.DataSource = dtprovedor;
           
            DataTable dtableproveedores = dtprovedor;
            DataRow fila = dtableproveedores.NewRow();
            fila["nombre"] = "seleccione el provedor";
            dtprovedor.Rows.InsertAt(fila, 0);
            CboProvedor.DataSource = dtableproveedores;
            CboProvedor.SelectedIndex = 0;

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

       
        private void TxtTaras_KeyPress(object sender, KeyPressEventArgs e)
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

        private void CboProdructos_SelectedIndexChanged(object sender, EventArgs e)
        {
           



        }

        private void PesoEntrada_Load(object sender, EventArgs e)
        {
            
        }

        private void CboTaras_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

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

        private void txtpesotara_TextChanged(object sender, EventArgs e)
        {
            string datain = txtpesotara.Text;
            txtpesotara.Text = Convert.ToString(DataRecivida(datain));

            string dataon = TxtDatosRecibidos.Text;
            TxtDatosRecibidos.Text = Convert.ToString(DataRecivida(dataon));
            
            if (!TxtPesoneto.Text.Equals(null))
             {
                 decimal dif = Convert.ToDecimal(TxtDatosRecibidos.Text.Trim()) - Convert.ToDecimal( txtpesotara.Text.Trim())-(Convert.ToDecimal(CboCajas.Text.Trim())*Convert.ToDecimal(txtNocajas.Text.Trim()));
                
                TxtPesoneto.Text = dif.ToString();
                

            }

        }

        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                BEL_PesoEntrada.Fechahorapeso = DateTime.Now.ToString("yyyy-MM-dd HH:m:ss");
                BEL_PesoEntrada.Producto = CboProdructos.Text;
                BEL_PesoEntrada.Cajas = txtNocajas.Text;
                BEL_PesoEntrada.Pesocaja = CboCajas.Text;
                BEL_PesoEntrada.Provedor = CboProvedor.Text;
                BEL_PesoEntrada.Pesobruto = Convert.ToString(DataRecivida(TxtDatosRecibidos.Text));
                BEL_PesoEntrada.Pesotara = Convert.ToString(txtpesotara.Text);
                BEL_PesoEntrada.Pesoneto = Convert.ToString(TxtPesoneto.Text);
                

                BLL_PesoEntrada.InsertarPesoEntrada(BEL_PesoEntrada);

                MessageBox.Show("DATOS GUARDADOS", "ATENCION", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void TxtDatosRecibidos_TextChanged(object sender, EventArgs e)
        {
      
        }
    }
}
