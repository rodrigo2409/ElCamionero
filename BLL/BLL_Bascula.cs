using BEL;
using DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class BLL_Bascula
    {
        public DataTable ListarBascula(BEL_Bascula bascula)
        {
            DAL_Bascula dalbascula = new DAL_Bascula();
            return dalbascula.ListarBascula(bascula);
        }





        public bool Insertarbascula(BEL_Bascula bascula)
        {
            DAL_Bascula dAL_Bascula = new DAL_Bascula();
            return dAL_Bascula.Insertarbascula(bascula);

        }
    }


   
}
