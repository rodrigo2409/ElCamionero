using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using BEL;
using System.Data;

namespace BLL
{
    public class BLL_Usuario
    {
        public DataTable ListarUsuario(BEL_Usuario usuario)
        {
            DAL_Usuario dalusuario = new DAL_Usuario();
            return dalusuario.ListarUsuario(usuario);
        }

        public bool insertarusuario(BEL_Usuario usuario) { 
            DAL_Usuario dAL_Usuario = new DAL_Usuario();
            return dAL_Usuario.Insertarusuario(usuario);
        }

       


    }
   
}
