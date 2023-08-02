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
    public partial class Registrar : Form
    {
        BEL_Usuario BEL_Usuario = new BEL_Usuario();
        BLL_Usuario BLL_Usuario = new BLL_Usuario();
        public Registrar()
        {
            InitializeComponent();
        }

        private void Registrar_Load(object sender, EventArgs e)
        {

        }

        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                BEL_Usuario usuario = new BEL_Usuario();
                usuario.Nombre = TxtNombre.Text;
                usuario.Apellidopaterno = TxtapellidoPaterno.Text;
                usuario.Apellidomaterno = TxtapellidoMaterno.Text;
                usuario.Usuario = TxtUsusario.Text;
                usuario.Contraseña = TxtContraseña.Text;
                usuario.Idtipousuario = Convert.ToInt32(CboTipoUsuario.Text);
                usuario.Activo = TxtActivo.Text;


                BLL_Usuario.insertarusuario(usuario);

                MessageBox.Show("DATOS GUARDADOS", "ATENCION", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }

        private void TxtContraseña_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
