using capaDatos;
using capaEntidad;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaNegocio
{
    public class cnDepartment
    {
        cdDepartment cdDepartment = new cdDepartment();

        public void addDepartment(ceDepartment department, MySqlConnection conn)
        {
            cdDepartment.addDepartment(department, conn);
        }

        public void getDepartments(ComboBox cbDeparment)
        {
            cdDepartment.getDepartments(cbDeparment);
        }

    }
}
