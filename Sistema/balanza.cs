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
using System.Drawing.Design;
using BEL;
using BLL;
using System.Text.RegularExpressions;

namespace Sistema
{

    public partial class Balanza : Form
    {
        BEL_Datapeso Beldatapeso = new BEL_Datapeso();
        BLL_Datapeso Blldatapeso = new BLL_Datapeso();

        BEL_Bascula Belbascula = new BEL_Bascula();
        BLL_Bascula Bilbascula = new BLL_Bascula();
        private delegate void DelegadoAcceso(string accion);

        private string strBufferIn;
        private string strBufferOut;

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





        public Balanza()
        {
            InitializeComponent();
        }
        private void AccesoForm(string accion)
        {

            strBufferIn = accion;
            TxtDatosRecibidos.Text = strBufferIn; ///
            Beldatapeso.Peso = TxtDatosRecibidos.Text.Trim();
        }

        private void AccesoInterruocion(string accion)
        {
            DelegadoAcceso Var_DelegadoAcceso;
            Var_DelegadoAcceso = new DelegadoAcceso(AccesoForm);
            object[] arg = { accion };
            base.Invoke(Var_DelegadoAcceso, arg);



        }

        private void balanza_Load(object sender, EventArgs e)
        {
            strBufferIn = "";
            strBufferOut = "";
            BtnConectar.Enabled = false;
            BtnGuardar.Enabled = false;
        }

        private void BtnbuscarPuertos_Click(object sender, EventArgs e)
        {
            string[] PuertosDisponibles = SerialPort.GetPortNames();
            CboPuertos.Items.Clear();

            foreach (string puerto_simple in PuertosDisponibles)
            {
                CboPuertos.Items.Add(puerto_simple);

            }
            if (CboPuertos.Items.Count > 0)
            {
                CboPuertos.SelectedIndex = 0;
                MessageBox.Show("SELECCIONE EL PUERTO");
                BtnConectar.Enabled = true;
            }
            else
            {
                MessageBox.Show("NO HAY PUERTOS DISPONIBLES");
                CboPuertos.Items.Clear();
                CboPuertos.Text = "                         ";
                strBufferIn = "";
                strBufferOut = "";
                BtnConectar.Enabled = false;

                BtnGuardar.Enabled = false;

            }
        }
        private void traedatosbascula(string nombrebascula)
        {
            DataTable dtbascula;
            Belbascula.Nombrebascula = nombrebascula;
            dtbascula = Bilbascula.ListarBascula(Belbascula);

            for (int i = 0; i < dtbascula.Rows.Count; i++)
            {
                nombrebascula = dtbascula.Rows[i][1].ToString();
                baudrate = dtbascula.Rows[i][2].ToString();
                puerto = dtbascula.Rows[i][3].ToString();
                bitdatos = dtbascula.Rows[i][4].ToString();
                paridad = dtbascula.Rows[i][5].ToString();
                bitparada = dtbascula.Rows[i][6].ToString();
                handskate = dtbascula.Rows[i][7].ToString();
                activo = dtbascula.Rows[i][8].ToString();

            }

        }

        private void BtnConectar_Click(object sender, EventArgs e)
        {
            try
            {
                if (BtnConectar.Text == "CONECTAR")
                {
                    traedatosbascula("");

                   

                    if (CboParidad.Text == "SIN PARIDAD")
                    {
                        SpPuertos.Parity = Parity.None;
                        TxtNombreBascula.Text = nombrebascula;
                        CboBaudRate.Text = baudrate;
                        SpPuertos.PortName = CboPuertos.Text;
                        SpPuertos.DataBits = Convert.ToInt32(bitdatos);
                        if (paridad == "Parity.None")
                            SpPuertos.Parity = Parity.None;
                        if (paridad == "Parity.Odd")
                            SpPuertos.Parity = Parity.Odd;
                        if (paridad == "Parity.Mark")
                            SpPuertos.Parity = Parity.Mark;
                        if (paridad == "Parity.Space")
                            SpPuertos.Parity = Parity.Space;
                        if (bitparada == "StopBits.One")
                            SpPuertos.StopBits = StopBits.One;
                        if (bitparada == "StopBits.Two")
                            SpPuertos.StopBits = StopBits.Two;
                        if (bitparada == "StopBits.None")
                            SpPuertos.StopBits = StopBits.None;
                        CboHandskate.Text = handskate;

                        TxtActivo.Text = activo;
                    }
                    try
                    {
                        SpPuertos.Open();
                        BtnConectar.Text = "DESCONECTAR";

                        BtnGuardar.Enabled = true;


                    }
                    catch (Exception exc)
                    {

                        MessageBox.Show(exc.Message.ToString());

                    }

                }
                else if (BtnConectar.Text == "DESCONECTAR")
                {

                    SpPuertos.Close();
                    BtnConectar.Text = "CONECTAR";


                }


            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message.ToString());

            }
        }



        private void DatoRecivido(object sender, SerialDataReceivedEventArgs e)
        {

            AccesoInterruocion(SpPuertos.ReadExisting());
            

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






        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                Beldatapeso.Fechahorapeso = DateTime.Now.ToString("yyyy-MM-dd HH:m:ss");
                Beldatapeso.Peso = Convert.ToString(DataRecivido(TxtDatosRecibidos.Text));
                Blldatapeso.Insertarpeso(Beldatapeso);

                MessageBox.Show("DATOS GUARDADOS", "ATENCION", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }


        }

        private void BtnGuardarBascula_Click(object sender, EventArgs e)
        {
            try
            {
                Belbascula.Nombrebascula = TxtNombreBascula.Text;
                Belbascula.Baudrate = CboBaudRate.Text;
                Belbascula.Puerto = CboPuertos.Text;
                Belbascula.Bitdedatos = CboBitsdatos.Text;
                Belbascula.Paridad = CboParidad.Text;
                Belbascula.Bitparada = CboBitsparada.Text;
                Belbascula.Handskate = CboHandskate.Text;
                Belbascula.Activo = TxtActivo.Text;

                Bilbascula.Insertarbascula(Belbascula);
                MessageBox.Show("DATOS GUARDADOS", "ATENCION", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }



        private void TxtDatosRecibidos_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
