using capaEntidad;
using MySql.Data.MySqlClient;
using System;
using System.Collections;
using System.Windows.Forms;

namespace capaDatos
{
    public class cdLead
    {
        string cadenaConexion = "Server=localhost;User=root;Password=TFG_ERP_C#;Port=3306;database=mydb;";

        public bool addLead(ceLead lead)
        {
            try
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

                    cmd.ExecuteNonQuery();
                }
                MessageBox.Show("Lead añadido", "Juanjo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            return true;
        }

        public void addLead(ceLead lead, MySqlConnection conn)
        {
            try
            {
                using (MySqlCommand cmd = new MySqlCommand("insert into mydb.lead (idLead, name, date, stage, " +
                "amount, notes, assignedTo, createdAt, customer_idcustomer, user_iduser) " +
                "values(@idLead, @name, @date, @stage, @amount, @notes, @assignedTo, @createdAt, @customeridcustomer, @useriduser);", conn))
                {
                    cmd.Parameters.AddWithValue("@idLead", lead.Idlead);
                    cmd.Parameters.AddWithValue("@name", lead.Name);
                    cmd.Parameters.AddWithValue("@date", lead.Date);
                    cmd.Parameters.AddWithValue("@stage", lead.Stage);
                    cmd.Parameters.AddWithValue("@amount", lead.Amount);
                    cmd.Parameters.AddWithValue("@notes", lead.Notes);
                    cmd.Parameters.AddWithValue("@assignedTo", lead.AssignedTo);
                    cmd.Parameters.AddWithValue("@createdAt", lead.CreatedAt);
                    cmd.Parameters.AddWithValue("@customeridcustomer", lead.idCustomer);
                    cmd.Parameters.AddWithValue("@useriduser", lead.idUser);

                    cmd.ExecuteNonQuery();
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.ToString());
            }

        }

        public ArrayList getLeads (ArrayList array)
        {
            try
            {
                MySqlConnection conn = new MySqlConnection(cadenaConexion);
                conn.Open();
                string query = "select name, date, stage, amount, notes, assignedTo, createdAt, Customer_idCustomer, User_idUser from lead;";

                MySqlCommand command = new MySqlCommand(query, conn);

                var row = command.ExecuteReader();

                if (row.HasRows)
                {
                    while (row.Read())
                    {
                        string name = row["name"].ToString();
                        string date = row["date"].ToString();
                        string stage = row["stage"].ToString();
                        int amount = int.Parse(row["amount"].ToString());
                        string notes = row["notes"].ToString();
                        string assignedTo = row["assignedTo"].ToString();
                        string createdAt = row["createdAt"].ToString();
                        int Customer_idCustomer = int.Parse(row["Customer_idCustomer"].ToString());
                        int User_idUser = int.Parse(row["User_idUser"].ToString());

                        array.Add(new ceLead(name, date, stage, amount, notes, assignedTo, createdAt, Customer_idCustomer, User_idUser));
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

            return array;
        }

        public void updateStageLead(int idLead, string newStage)
        {
            try
            {
                MySqlConnection conn = new MySqlConnection(cadenaConexion);
                MySqlCommand cmd;
                conn.Open();

                using (cmd = new MySqlCommand("UPDATE mydb.lead SET stage = @newStage WHERE idLead = @idLead;", conn))
                {
                    cmd.Parameters.AddWithValue("@idLead", idLead);
                    cmd.Parameters.AddWithValue("@newStage", newStage);
                    cmd.ExecuteNonQuery();
                }
                MessageBox.Show("Lead Actualizado", "Juanjo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void deleteLead(int idLead)
        {
            try
            {
                MySqlConnection conn = new MySqlConnection(cadenaConexion);
                MySqlCommand cmd;
                conn.Open();

                using (cmd = new MySqlCommand("DELETE FROM mydb.lead WHERE idLead = @idLead;", conn))
                {
                    cmd.Parameters.AddWithValue("@idLead", idLead);
                    cmd.ExecuteNonQuery();
                }
                MessageBox.Show("Lead Eliminado", "Juanjo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                conn.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void leadsByDate(DataGridView dgvLeadsByLead, int idCustomer, DateTime startDate, DateTime endDate)
        {
            dgvLeadsByLead.RowCount = 0;
            ArrayList array = new ArrayList();
            try
            {
                array.Clear();
                MySqlConnection conn = new MySqlConnection(cadenaConexion);
                conn.Open();
                string query = "SELECT idLead, name, date, stage, amount, notes, assignedTo, createdAt FROM mydb.lead WHERE Customer_idCustomer = ?idCustomer and date >= ?startDate and date <= ?endDate;";

                MySqlCommand command = new MySqlCommand(query, conn);
                command.Parameters.AddWithValue("?idCustomer", idCustomer);
                command.Parameters.AddWithValue("?startDate", startDate);
                command.Parameters.AddWithValue("?endDate", endDate);

                var row = command.ExecuteReader();

                if (row.HasRows)
                {
                    while (row.Read())
                    {
                        int idLead = int.Parse(row["idLead"].ToString());
                        string name = row["name"].ToString();
                        string date = row["date"].ToString();
                        string stage = row["stage"].ToString();
                        int amount = int.Parse(row["amount"].ToString());
                        string notes = row["notes"].ToString();
                        string assignedTo = row["assignedTo"].ToString();
                        string createdAt = row["createdAt"].ToString();

                        array.Add(new ceLead(idLead, name, date, stage, amount, notes, assignedTo, createdAt));
                    }
                }
                else
                {
                    MessageBox.Show("No hay leads correspondientes al fechado indicado.");
                }

                row.Close();// Close reader.
                conn.Close();// Close connection.

                ceLead lead = null;
                for (int i = 0; i < array.Count; i++)
                {
                    DataGridViewRow newRow = new DataGridViewRow();

                    lead = null;
                    lead = (ceLead) array[i];

                    newRow.CreateCells(dgvLeadsByLead);

                    newRow.Cells[0].Value = lead.Idlead;
                    newRow.Cells[1].Value = lead.Name;
                    newRow.Cells[2].Value = lead.Date;
                    newRow.Cells[3].Value = lead.Stage;
                    newRow.Cells[4].Value = lead.Amount;
                    newRow.Cells[5].Value = lead.AssignedTo;
                    newRow.Cells[6].Value = lead.CreatedAt;

                    dgvLeadsByLead.Rows.Add(newRow);
                }
            }
            catch (Exception err)
            {
                MessageBox.Show(err.ToString());
            }

        }

    }
}
