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
    public partial class Insertarproductos : Form
    {
        BEL_Productos BEL_Productos = new BEL_Productos();
        BLL_Productos BILL_Productos = new BLL_Productos();
        public Insertarproductos()
        {
            InitializeComponent();
        }

        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            BEL_Productos productos = new BEL_Productos();
            productos.Nombre = TxtNombreProducto.Text;
            BILL_Productos.InsertarProductos(productos);

            MessageBox.Show("DATOS GUARDADOS", "ATENCION", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            
            
        }
    }
}
