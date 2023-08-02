using BEL;
using BLL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema
{

    public  class Session
    {
        BEL_Usuario bEL_Usuario = new BEL_Usuario();
        BLL_Usuario bLL_Usuario = new BLL_Usuario();

        public static int idusuaario, idtipousuario;
        public static string usuario, nombre;

    }
}
