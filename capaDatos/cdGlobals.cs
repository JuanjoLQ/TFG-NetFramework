using capaEntidad;
using MySql.Data.MySqlClient;
using System;
using System.IO;
using System.Windows.Forms;

namespace capaDatos
{
    public class cdGlobals
    {
        string cadenaConexion = "Server=localhost;User=root;Password=TFG_ERP_C#;Port=3306;database=mydb;";

        public void setId(String email)
        {
            try
            {
                MySqlConnection conn = new MySqlConnection(cadenaConexion);
                conn.Open();
                string query = "select idUser from user where email ='" + email + "';";

                MySqlCommand command = new MySqlCommand(query, conn);

                var row = command.ExecuteReader();

                if (row.HasRows)
                {
                    while (row.Read())
                    {
                        ceGlobals.id = row["idUser"].ToString();
                    }
                }
                else
                {
                    MessageBox.Show("Data not found");
                }

                row.Close();// Close reader.
                conn.Close();// Close connection.
            }
            catch (Exception err)
            {
                MessageBox.Show(err.ToString());
            }
        }

        public void newLogEntry(string user, string logEntry)
        {
            string timeStamp = DateTime.Now.ToString("dd.MM.yyyy HH.mm.ss");

            StreamWriter file = new StreamWriter("C:\\Users\\Jesus\\Tfg Net Framework\\Tfg NetFramework\\" + "log.txt", append: true);
            file.WriteLine("[" + timeStamp + "] [" + user + "] " + logEntry);
            file.Close();
        }

        public int getId(string email)
        {
            int idUser = 0;
            try
            {
                MySqlConnection conn = new MySqlConnection(cadenaConexion);
                conn.Open();
                string query = "SELECT idUser FROM User WHERE email = ?email;";

                MySqlCommand command = new MySqlCommand(query, conn);
                command.Parameters.AddWithValue("?email", email);

                var row = command.ExecuteReader();

                if (row.HasRows)
                {
                    while (row.Read())
                    {
                        idUser = int.Parse(row["idUser"].ToString());

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

            return idUser;
        }


    }
}
