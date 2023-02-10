using capaEntidad;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace capaDatos
{
    public class cdDepartment
    {

        public void addDepartment(ceDepartment department, MySqlConnection conn)
        {
            try
            {
                using (MySqlCommand cmd = new MySqlCommand("insert into company (idDepartment, name, Company_idCompany) " +
                "values(@idDepartment, @name, @Company_IdCompany);", conn))
                {
                    cmd.Parameters.AddWithValue("@idDepartment", department.idDepartment);
                    cmd.Parameters.AddWithValue("@name", department.name);
                    cmd.Parameters.AddWithValue("@Company_IdCompany", department.Company_idCompany);

                    cmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

    }
}
