using capaEntidad;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Lifetime;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace capaDatos
{
    public class cdCustomer
    {
        string cadenaConexion = "Server=localhost;User=root;Password=TFG_ERP_C#;Port=3306;database=mydb;";
        public bool addCustomer(ceCustomer customer)
        {
            MySqlConnection conn = new MySqlConnection(cadenaConexion);
            MySqlCommand cmd;
            conn.Open();

            using (cmd = new MySqlCommand("insert into customer (name, phone, email, " +
                "department, city, state, zip, country, adress1, adress2, type, notes, date) values(@name, " +
                "@phone, @email, @department, @city, @state, @zip, @country, @adress1, @adress2, @type, @notes, @date);", conn))
            {
                cmd.Parameters.AddWithValue("@name", customer.Name);
                cmd.Parameters.AddWithValue("@phone", customer.Phone);
                cmd.Parameters.AddWithValue("@email", customer.Email);
                cmd.Parameters.AddWithValue("@department", customer.Department);
                cmd.Parameters.AddWithValue("@city", customer.City);
                cmd.Parameters.AddWithValue("@state", customer.State);
                cmd.Parameters.AddWithValue("@zip", customer.Zip);
                cmd.Parameters.AddWithValue("@country", customer.Country);
                cmd.Parameters.AddWithValue("@adress1", customer.Adress1);
                cmd.Parameters.AddWithValue("@adress2", customer.Adress2);
                cmd.Parameters.AddWithValue("@type", customer.Type);
                cmd.Parameters.AddWithValue("@notes", customer.Notes);
                cmd.Parameters.AddWithValue("@date", customer.Date);

                cmd.ExecuteNonQuery();
            }
            MessageBox.Show("Customer añadido", "Juanjo", MessageBoxButtons.OK, MessageBoxIcon.Information);

            conn.Close();

            return true;
        }

    }
}
