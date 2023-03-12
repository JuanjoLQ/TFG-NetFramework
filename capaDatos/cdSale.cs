using capaEntidad;
using MySql.Data.MySqlClient;
using Org.BouncyCastle.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace capaDatos
{
    public class cdSale
    {
        string cadenaConexion = "Server=localhost;User=root;Password=TFG_ERP_C#;Port=3306;database=mydb;";

        public void addSale(int idProduct, int idSale)
        {
            try
            {
                MySqlConnection conn = new MySqlConnection(cadenaConexion);
                MySqlCommand cmd;
                conn.Open();

                using (cmd = new MySqlCommand("UPDATE Product SET Sales_idSale1 = @idSale, State = @state WHERE idProduct = @idProduct;", conn))
                {
                    cmd.Parameters.AddWithValue("@idSale", idSale);
                    cmd.Parameters.AddWithValue("@state", "Sold");
                    cmd.Parameters.AddWithValue("@idProduct", idProduct);
                    cmd.ExecuteNonQuery();
                }
                MessageBox.Show("Producto añadido a venta.", "Juanjo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void createSale(string datetime)
        {
            try
            {
                MySqlConnection conn = new MySqlConnection(cadenaConexion);
                MySqlCommand cmd;
                conn.Open();

                using (cmd = new MySqlCommand("insert into Sales (Date) values(@date);", conn))
                {
                    cmd.Parameters.AddWithValue("@date", datetime);

                    cmd.ExecuteNonQuery();
                }
                MessageBox.Show("Sale añadido", "Juanjo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public int idSale(string datetime)
        {
            int identSale = 0;
            try
            {                
                MySqlConnection conn = new MySqlConnection(cadenaConexion);
                conn.Open();
                string query = "SELECT idSale FROM Sales WHERE Date = ?datetime;";

                MySqlCommand command = new MySqlCommand(query, conn);
                command.Parameters.AddWithValue("?datetime", datetime);

                var row = command.ExecuteReader();

                if (row.HasRows)
                {
                    while (row.Read())
                    {
                        identSale = int.Parse(row["idSale"].ToString());
                    }
                }
                else
                {
                    MessageBox.Show("No hay Sales.");
                }

                row.Close();// Close reader.
                conn.Close();// Close connection.
                return identSale;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return identSale;
        }

        public int getidSaleFromIdLead(int idLead)
        {
            int idSale = 0;
            try
            {
                MySqlConnection conn = new MySqlConnection(cadenaConexion);
                conn.Open();
                string query = "SELECT Sales_idSale FROM mydb.lead WHERE idLead = ?idLead;";

                MySqlCommand command = new MySqlCommand(query, conn);
                command.Parameters.AddWithValue("?idLead", idLead);

                var row = command.ExecuteReader();

                if (row.HasRows)
                {
                    while (row.Read())
                    {
                        idSale = int.Parse(row["Sales_idSale"].ToString());
                    }
                }
                else
                {
                    MessageBox.Show("No hay Sales.");
                }

                row.Close();// Close reader.
                conn.Close();// Close connection.
                return idSale;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return idSale;
        }

        public string datetimeSale(int idSale)
        {
            string datetime = string.Empty;
            try
            {
                MySqlConnection conn = new MySqlConnection(cadenaConexion);
                conn.Open();
                string query = "SELECT Date FROM Sales WHERE idSale = ?idSale;";

                MySqlCommand command = new MySqlCommand(query, conn);
                command.Parameters.AddWithValue("?idSale", idSale);

                var row = command.ExecuteReader();

                if (row.HasRows)
                {
                    while (row.Read())
                    {
                        datetime = row["Date"].ToString();
                    }
                }
                else
                {
                    MessageBox.Show("No hay Sales.");
                }

                row.Close();// Close reader.
                conn.Close();// Close connection.
                return datetime;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return datetime;
        }

    }
}
