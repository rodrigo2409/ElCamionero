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
using System.Text.RegularExpressions;

namespace Sistema
{
    public partial class Tara : Form

    {
        BEL_Tara BEL_Tara= new BEL_Tara();
        BLL_Tara BLL_Tara = new BLL_Tara();
       

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
        public Tara()
        {
            InitializeComponent();
           
        }
       
        private string DataRecivida(String cadena)
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
                BEL_Tara.Numerotara = TxtNumeroTara.Text;
                BEL_Tara.Pesotara = TxtDatosRecibidos.Text;

                BLL_Tara.InsertarTara(BEL_Tara);


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
        private void DatoRecivido(object sender, SerialDataReceivedEventArgs e)
        {
            //AccesoInterruocion(SpPuertos.ReadExisting());
                string datain = SpPuertos.ReadExisting();
            TxtDatosRecibidos.Text = Convert.ToString(DataRecivida(datain));
            //
        }

        private void TxtNumeroTara_KeyPress(object sender, KeyPressEventArgs e)
        {
            Bascula basc = new Bascula();
            DataTable databascula = new DataTable();
            databascula = basc.ConectarBascula();

            
            if (e.KeyChar== Convert.ToChar(Keys.Enter))
            {
                

                for(int i = 0;i< databascula.Rows.Count;)
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

                
                SpPuertos.DataBits =Convert.ToInt32(bitdatos);
                if (paridad == "None")
                {
                    SpPuertos.Parity = Parity.None;
                }
                if (bitparada == "One")
                {
                    SpPuertos.StopBits = StopBits.One;
                }
                if (handskate == "None") { 
                SpPuertos.Handshake = Handshake.None;
                }
                if (handskate == "XOnXOff") {
                    SpPuertos.Handshake = Handshake.XOnXOff;
                }
                
                SpPuertos.PortName = puerto;

                SpPuertos.Open();

            }
        }
    }
}
