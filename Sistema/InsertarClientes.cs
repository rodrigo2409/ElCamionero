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
    public partial class InsertarClientes : Form
    {
        BEL_Cliente BEL_Cliente = new BEL_Cliente();
        BLL_Cliente BLL_Cliente = new BLL_Cliente();    
        public InsertarClientes()
        {
            InitializeComponent();
        }

        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                BEL_Cliente.Nombre = TxtCliente.Text;
                BLL_Cliente.Insertarcliente(BEL_Cliente);
                MessageBox.Show("DATOS GUARDADOS", "ATENCION", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            catch (Exception ex) { MessageBox.Show(ex.Message.ToString());  }

        }
    }
}
