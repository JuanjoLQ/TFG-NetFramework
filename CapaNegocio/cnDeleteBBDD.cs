using System;
using capaDatos;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace CapaNegocio
{
    public class cnDeleteBBDD
    {
        cdDeleteBBDD cdDeleteBBDD = new cdDeleteBBDD();
        cdUser cdUser = new cdUser();

        public void deleteBBDD(MySqlConnection conn)
        {
            cdDeleteBBDD.deleteBBDD(conn);
        }

        public void deleteBBDDWithUserAdmin(MySqlConnection conn) 
        {
            deleteBBDD(conn);

        }


    }
}
