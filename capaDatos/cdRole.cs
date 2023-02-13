using capaEntidad;
using MySql.Data.MySqlClient;
using Org.BouncyCastle.Utilities;
using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.PropertyGridInternal;

namespace capaDatos
{
    public class cdRole
    {
        string cadenaConexion = "Server=localhost;User=root;Password=TFG_ERP_C#;Port=3306;database=mydb;";

        // Comprobar si funka
        public bool CheckRole(String role)
        {
            Debug.WriteLine("Capa datos logUser");
            MySqlConnection conn = new MySqlConnection(cadenaConexion);
            conn.Open();
            string query = "SELECT COUNT(*) FROM role where nameRole='" + role + "';";
            MySqlCommand command = new MySqlCommand(query, conn);

            int count = Convert.ToInt32(command.ExecuteScalar());

            if (count == 1)
            {
                return true;
            }
            else
            {
                return false;
            }

        }

        // Comprobar si funka
        public bool CrearRole(String role)
        {

            if (CheckRole(role) == false)
            {
                MySqlConnection conn = new MySqlConnection(cadenaConexion);
                conn.Open();
                string query = "INSERT INTO role (nameRole) VALUES " +
                    "('" + role + "');";
                MySqlCommand command = new MySqlCommand(query, conn);
                command.ExecuteNonQuery();
                conn.Close();
                MessageBox.Show("Registro de user creado");
                return true;
            }
            else
            {
                MessageBox.Show("Email ya existente.");
                return false;
            }

        }

        public void addRole(ceRole role, MySqlConnection conn)
        {
            try
            {
                using (MySqlCommand cmd = new MySqlCommand("insert into role (idRole, nameRole, privileges) " +
                "values(@idRole, @nameRole, @privileges);", conn))
                {
                    cmd.Parameters.AddWithValue("@idRole", role.idRole);
                    cmd.Parameters.AddWithValue("@nameRole", role.nameRole);
                    cmd.Parameters.AddWithValue("@privileges", role.privileges);

                    cmd.ExecuteNonQuery();
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        public int addAdminRole(MySqlConnection conn)
        {
            int idRole = 0;

            conn.Close();

            MySqlConnection con = new MySqlConnection(cadenaConexion);
            con.Open();

            
            using (MySqlCommand cmd = new MySqlCommand("insert into role (nameRole, privileges) " +
                "values(@nameRole, @privileges);", con))
            {
                cmd.Parameters.AddWithValue("@nameRole", "adminadmin");
                cmd.Parameters.AddWithValue("@privileges", "1111");

                cmd.ExecuteNonQuery();
            }
            
            
            string query = "SELECT idRole FROM role WHERE nameRole = ?nameRole;";

            MySqlCommand command = new MySqlCommand(query, con);
            command.Parameters.AddWithValue("?nameRole", "adminadmin");

            var row = command.ExecuteReader();

            

            if (row.HasRows)
            {
                while (row.Read())
                {
                    idRole = int.Parse(row["idRole"].ToString());
                }
            }
            else
            {
                MessageBox.Show("No hay users admins correspondientes al email indicado.");
            }
            
            return idRole;

        }

        public void getRoles(ComboBox cbRole)
        {
            try
            {
                MySqlConnection conn = new MySqlConnection(cadenaConexion);
                conn.Open();
                string query = "SELECT nameRole FROM role;";

                MySqlCommand command = new MySqlCommand(query, conn);

                var row = command.ExecuteReader();

                if (row.HasRows)
                {
                    while (row.Read())
                    {
                        string nameRole = row["nameRole"].ToString();
                        
                        cbRole.Items.Add(nameRole);
                    }
                }
                else
                {
                    MessageBox.Show("No hay leads correspondientes al fechado indicado.");
                }

                row.Close();// Close reader.
                conn.Close();// Close connection.
            }
            catch (Exception err)
            {
                MessageBox.Show(err.ToString());
            }
        }


    }
}
