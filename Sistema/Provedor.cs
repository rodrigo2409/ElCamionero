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

namespace Sistema
{
    public partial class Provedor : Form
    {
        BEL_Provedor BEL_Provedor = new BEL_Provedor();
        BLL_Provedor BLL_Provedor = new BLL_Provedor();
        public Provedor()
        {
            InitializeComponent();
        }

        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                
                BEL_Provedor.Nombre = TxtProvedor.Text;
                BLL_Provedor.Insertarprovedor(BEL_Provedor);

                MessageBox.Show("DATOS GUARDADOS", "ATENCION", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);


            }
            catch (Exception ex) { MessageBox.Show(ex.Message.ToString()); }
        }

        private void TxtProvedor_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
