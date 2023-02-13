using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace capaDatos
{
    public class cdDeleteBBDD
    {
        cdUser cdUser = new cdUser();
        public void deleteBBDD(MySqlConnection conn) 
        {
            delRoleUsers(conn);
            delRoles(conn);
            delDepartmentUsers(conn);
            delDepartments(conn);
            delCompanies(conn);
            delLeads(conn);
            delCustomers(conn);
            delUsers(conn);
            delMileages(conn);
            delAllowances(conn);
            MessageBox.Show("Antes crear useradmin");
            cdUser.addAdminUser(conn);
            
        }

        private void delUsers(MySqlConnection conn) 
        {
            try
            {
                using (MySqlCommand cmd = new MySqlCommand("DELETE FROM User;", conn))
                {
                    cmd.ExecuteNonQuery();
                }
                
            }
            catch (Exception ex)
            {
                MessageBox.Show("Users: " + ex.Message);
            }

        }

        private void delCustomers(MySqlConnection conn)
        {
            try
            {
                using (MySqlCommand cmd = new MySqlCommand("DELETE FROM Customer;", conn))
                {
                    cmd.ExecuteNonQuery();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void delRoles(MySqlConnection conn)
        {
            try
            {
                using (MySqlCommand cmd = new MySqlCommand("DELETE FROM Role;", conn))
                {
                    cmd.ExecuteNonQuery();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void delCompanies(MySqlConnection conn)
        {
            try
            {
                using (MySqlCommand cmd = new MySqlCommand("DELETE FROM Company;", conn))
                {
                    cmd.ExecuteNonQuery();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void delDepartments(MySqlConnection conn)
        {
            try
            {
                using (MySqlCommand cmd = new MySqlCommand("DELETE FROM Department;", conn))
                {
                    cmd.ExecuteNonQuery();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void delLeads(MySqlConnection conn)
        {
            try
            {
                using (MySqlCommand cmd = new MySqlCommand("DELETE FROM mydb.lead;", conn))
                {
                    cmd.ExecuteNonQuery();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void delMileages(MySqlConnection conn)
        {
            try
            {
                using (MySqlCommand cmd = new MySqlCommand("DELETE FROM Mileage;", conn))
                {
                    cmd.ExecuteNonQuery();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void delAllowances(MySqlConnection conn)
        {
            try
            {
                using (MySqlCommand cmd = new MySqlCommand("DELETE FROM Allowance;", conn))
                {
                    cmd.ExecuteNonQuery();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void delRoleUsers(MySqlConnection conn)
        {
            try
            {
                using (MySqlCommand cmd = new MySqlCommand("DELETE FROM Role_User;", conn))
                {
                    cmd.ExecuteNonQuery();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void delDepartmentUsers(MySqlConnection conn)
        {
            try
            {
                using (MySqlCommand cmd = new MySqlCommand("DELETE FROM Department_User;", conn))
                {
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
