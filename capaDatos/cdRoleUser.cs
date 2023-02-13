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

        public void addRoleUserAdmin(int idUser, int idRole, MySqlConnection conn)
        {
            MySqlTransaction tr = null;
            try
            {
                tr = conn.BeginTransaction();

                using (MySqlCommand cmd = new MySqlCommand("INSERT INTO Role_User (User_idUser, Role_idRole) VALUES (@User_idUser, @Role_idRole);", conn))
                {
                    cmd.Transaction = tr;

                    cmd.Parameters.AddWithValue("@User_idUser", idUser);
                    cmd.Parameters.AddWithValue("@Role_idRole", idRole);

                    cmd.ExecuteNonQuery();
                }

                tr.Commit();
            }
            catch (MySqlException ex)
            {
                try
                {
                    tr.Rollback();
                }
                catch (MySqlException ex1)
                {
                    MessageBox.Show(ex1.ToString());
                }

                MessageBox.Show(ex.ToString());
            }
        }
    }
}
