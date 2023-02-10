using System;
using capaDatos;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using capaEntidad;

namespace CapaNegocio
{
    public class cnRoleUser
    {
        cdRoleUser cdRoleUser = new cdRoleUser();

        public void addRoleUser(ceRole_User role_user, MySqlConnection conn)
        {
            cdRoleUser.addRoleUser(role_user, conn);
        }

    }
}
