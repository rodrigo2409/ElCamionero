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
    public partial class Login : Form
    {
        public static int Tipousuario; 
        public Login()
        {
            InitializeComponent();
            
        }

        private void BtnLogin_Click(object sender, EventArgs e)
        {
            try
            {
                BEL_Usuario Belusuario = new BEL_Usuario();
                BLL_Usuario Bllusuario = new BLL_Usuario();
                DataTable dtusuario = new DataTable();

                Belusuario.Usuario = TxtUsuario.Text.Trim();
                Belusuario.Contraseña = TxtContraseña.Text.Trim();
                

                dtusuario = Bllusuario.ListarUsuario(Belusuario);

                for(int i = 0; i < dtusuario.Rows.Count; i++)
                {
                    Tipousuario = Convert.ToInt32(dtusuario.Rows[i][6].ToString());
                }

                if (dtusuario.Rows.Count > 0)
                {
                   
                    Menu menuprincipal = new Menu();
                    menuprincipal.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("No existen usuarios");
                }

               
            }
            catch (Exception)
            {

                throw;
            }
            
            
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }
    }
}
