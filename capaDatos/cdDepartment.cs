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
        string cadenaConexion = "Server=localhost;User=root;Password=TFG_ERP_C#;Port=3306;database=mydb;";

        public void addDepartment(ceDepartment department, MySqlConnection conn)
        {
            try
            {
                using (MySqlCommand cmd = new MySqlCommand("insert into department (idDepartment, name, Company_idCompany) " +
                "values(@idDepartment, @name, @Company_IdCompany);", conn))
                {
                    cmd.Parameters.AddWithValue("@idDepartment", department.idDepartment);
                    cmd.Parameters.AddWithValue("@name", department.name);
                    cmd.Parameters.AddWithValue("@Company_IdCompany", department.Company_idCompany);

                    cmd.ExecuteNonQuery();
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.ToString());
            }

        }

        public void getDepartments(ComboBox cbDepartment)
        {
            try
            {
                MySqlConnection conn = new MySqlConnection(cadenaConexion);
                conn.Open();
                string query = "SELECT name FROM Department;";

                MySqlCommand command = new MySqlCommand(query, conn);

                var row = command.ExecuteReader();

                if (row.HasRows)
                {
                    while (row.Read())
                    {
                        string nameRole = row["name"].ToString();

                        cbDepartment.Items.Add(nameRole);
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
