using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BEL;
using BLL;

namespace Sistema
{
    public class Bascula
    {
        BEL_Bascula Belbascula = new BEL_Bascula();
        BLL_Bascula Bllbascula = new BLL_Bascula();
        public DataTable ConectarBascula()
        {
           return traedatosbascula("");
        }

        private DataTable traedatosbascula(string nombre)
        {
            DataTable dtbascula;
            Belbascula.Nombrebascula = nombre;
            return dtbascula = Bllbascula.ListarBascula(Belbascula);

        }
    }

    
}
