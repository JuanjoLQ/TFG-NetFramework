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
    public class cdRoleUser
    {

        public void addRoleUser(ceRole_User role_user, MySqlConnection conn)
        {
            try
            {
                using (MySqlCommand cmd = new MySqlCommand("INSERT INTO Role_User (User_idUser, Role_idRole) VALUES (@User_idUser, @Role_idRole);", conn))
                {
                    cmd.Parameters.AddWithValue("@User_idUser", role_user.User_idUser);
                    cmd.Parameters.AddWithValue("@Role_idRole", role_user.Role_idRole);

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
