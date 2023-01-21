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

            using (cmd = new MySqlCommand("insert into lead (name, date, stage, " +
                "amount, notes, assignedTo, createdAt) values(@name, " +
                "@date, @stage, @amount, @notes, @assignedTo, @createdAt);", conn))
            {
                cmd.Parameters.AddWithValue("@name", lead.Name);
                cmd.Parameters.AddWithValue("@phone", lead.Date);
                cmd.Parameters.AddWithValue("@email", lead.Stage);
                cmd.Parameters.AddWithValue("@department", lead.Amount);
                cmd.Parameters.AddWithValue("@city", lead.Notes);
                cmd.Parameters.AddWithValue("@state", lead.AssignedTo);
                cmd.Parameters.AddWithValue("@zip", lead.CreatedAt);
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
