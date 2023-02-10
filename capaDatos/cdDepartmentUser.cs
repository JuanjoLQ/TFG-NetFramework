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
    public class cdDepartmentUser
    {
        public void addDepartmentUser(ceDepartment_User department_user, MySqlConnection conn)
        {
            try
            {
                using (MySqlCommand cmd = new MySqlCommand("INSERT INTO Department_Dser (Department_idDepartment, User_idUser) VALUES " +
                    "(@Department_idDepartment, @User_idUser);", conn))
                {
                    cmd.Parameters.AddWithValue("@Department_idDepartment", department_user.Department_idDepartment);
                    cmd.Parameters.AddWithValue("@User_idUser", department_user.User_idUser);

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
