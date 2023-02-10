using capaDatos;
using capaEntidad;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio
{
    public class cnDepartment
    {
        cdDepartment cdDepartment = new cdDepartment();

        public void addDepartment(ceDepartment department, MySqlConnection conn)
        {
            cdDepartment.addDepartment(department, conn);
        }

    }
}
