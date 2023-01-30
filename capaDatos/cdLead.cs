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
    public class cdLead
    {
        string cadenaConexion = "Server=localhost;User=root;Password=TFG_ERP_C#;Port=3306;database=mydb;";
        public bool addLead(ceLead lead)
        {
            MySqlConnection conn = new MySqlConnection(cadenaConexion);
            MySqlCommand cmd;
            conn.Open();
            

                using (cmd = new MySqlCommand("insert into mydb.lead (name, date, stage, " +
                "amount, notes, assignedTo, createdAt, customer_idcustomer, user_iduser) " +
                "values(@name, @date, @stage, @amount, @notes, @assignedTo, @createdAt, @customeridcustomer, @useriduser);", conn))
                {
                cmd.Parameters.AddWithValue("@name", lead.Name);
                cmd.Parameters.AddWithValue("@date", lead.Date);
                cmd.Parameters.AddWithValue("@stage", lead.Stage);
                cmd.Parameters.AddWithValue("@amount", lead.Amount);
                cmd.Parameters.AddWithValue("@notes", lead.Notes);
                cmd.Parameters.AddWithValue("@assignedTo", lead.AssignedTo);
                cmd.Parameters.AddWithValue("@createdAt", lead.CreatedAt);
                cmd.Parameters.AddWithValue("@customeridcustomer", lead.idCustomer);
                cmd.Parameters.AddWithValue("@useriduser", lead.idUser);


                //
                // Enlazar User y Customer con Lead
                //


                cmd.ExecuteNonQuery();
            }
            MessageBox.Show("Lead añadido", "Juanjo", MessageBoxButtons.OK, MessageBoxIcon.Information);

            conn.Close();

            return true;
        }

    }
}
