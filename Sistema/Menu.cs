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
    public partial class Menu : Form
    {
        BEL_Usuario bEL_Usuario = new BEL_Usuario();
        BLL_Usuario bLL_Usuario = new BLL_Usuario();

        public Menu()
        {
            InitializeComponent();
            AccesoUsuario(Login.Tipousuario);

        }

        private void AccesoUsuario(int tipo)
        {
            switch (tipo)
            {
                case 2:
                    AccesoLimitado();
                    break;
            }
        }

        

        private void AccesoLimitado()
        {
            basculaToolStripMenuItem.Enabled = false;
            catalogosToolStripMenuItem.Enabled = false;
            configuracionToolStripMenuItem.Enabled = false;
        }

        private void registrarUsuarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Registrar registro = new Registrar();
            registro.MdiParent = this;
            registro.Show();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pesarEntradaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Balanza balanza = new Balanza();
            balanza.MdiParent = this;
            balanza.Show();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void tarasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Tara Tara = new Tara();
            Tara.MdiParent = this;
            Tara.Show();

        }

        private void cajasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Cajas Cajas = new Cajas();
            Cajas.MdiParent = this;
            Cajas.Show();


        }

        private void insertarProductoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Insertarproductos insertarproductos = new Insertarproductos();
            insertarproductos.MdiParent = this;
            insertarproductos.Show();

        }

        private void pesoEntradaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PesoEntrada pesoEntrada = new PesoEntrada();
            pesoEntrada.MdiParent = this;
            pesoEntrada.Show();
        }

        private void pesoSalidaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PesoSalida pesoSalida = new PesoSalida();
            pesoSalida.MdiParent = this;
            pesoSalida.Show();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void archivoToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void herramientasToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void personalizarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Reportepesosalida reportepesosalida = new Reportepesosalida();
            reportepesosalida.MdiParent = this;
            reportepesosalida.Show();
        }

        private void opcionesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Reporte reporte = new Reporte();
            reporte.MdiParent = this;
            reporte.Show();
        }

        private void clienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            InsertarClientes insertarClientes = new InsertarClientes();
            insertarClientes.MdiParent = this;
            insertarClientes.Show();
        }

        private void provedorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Provedor provedor = new Provedor();
            provedor.MdiParent = this;
            provedor.Show();
        }

        private void prodructosToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
