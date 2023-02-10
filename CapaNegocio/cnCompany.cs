using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using capaDatos;
using capaEntidad;

using MySql.Data.MySqlClient;

namespace CapaNegocio
{
    public class cnCompany
    {
        cdCompany cdCompany = new cdCompany();

        public void addCompany(ceCompany company, MySqlConnection conn) 
        {
            cdCompany.addCompany(company, conn);
        }

    }
}
