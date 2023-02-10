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
    public class cnDepartmentUser
    {
        cdDepartmentUser cdDepartmentUser = new cdDepartmentUser();
        public void addDepartmentUser(ceDepartment_User department_user, MySqlConnection conn)
        {
            cdDepartmentUser.addDepartmentUser(department_user, conn);
        }
    }
}
