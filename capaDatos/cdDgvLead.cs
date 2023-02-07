using capaEntidad;
using MySql.Data.MySqlClient;
using Org.BouncyCastle.Utilities;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using System.Xml.Linq;

namespace capaDatos
{
    public class cdDgvLead
    {
        string cadenaConexion = "Server=localhost;User=root;Password=TFG_ERP_C#;Port=3306;database=mydb;";

        ArrayList arrayLeads_Customer = new ArrayList();

        private void resetData()
        {
            arrayLeads_Customer.Clear();
        }

        public void GetData(int idCustomer)
        {
            try
            {
                resetData();
                MySqlConnection conn = new MySqlConnection(cadenaConexion);
                conn.Open();
                string query = "SELECT idLead, name, date, stage, amount, assignedTo, createdAt " +
                    "FROM mydb.lead " +
                    "WHERE Customer_idCustomer = ?idCustomer;";

                MySqlCommand command = new MySqlCommand(query, conn);
                command.Parameters.AddWithValue("?idCustomer", idCustomer);

                var row = command.ExecuteReader();

                var idLead = string.Empty;
                var name = string.Empty;
                var date = string.Empty;
                var stage = string.Empty;
                var amount = string.Empty;
                var assignedTo = string.Empty;
                var createdAt = string.Empty;

                if (row.HasRows)
                {
                    while (row.Read())
                    {
                        idLead = row["idLead"].ToString();
                        name = row["name"].ToString();
                        date = row["date"].ToString();
                        stage = row["stage"].ToString();
                        amount = row["amount"].ToString();
                        assignedTo = row["assignedTo"].ToString();
                        createdAt = row["createdAt"].ToString();

                        ceLead lead = new ceLead(int.Parse(idLead), name, date, stage, int.Parse(amount), assignedTo, createdAt);

                        arrayLeads_Customer.Add(lead);
                    }
                }
                else
                {
                    //MessageBox.Show("Data not found");
                }

                row.Close();// Close reader.
                conn.Close();// Close connection.
            }
            catch (Exception err)
            {
                MessageBox.Show(err.ToString());
            }
        }

        public void updateDatagrid(DataGridView dgvCustomer_Lead)
        {
            dgvCustomer_Lead.RowCount = 0;
            ceLead lead = null;

            for (int i = 0; i < arrayLeads_Customer.Count; i++)
            {
                DataGridViewRow newRow = new DataGridViewRow();

                lead = null;
                lead = (ceLead) arrayLeads_Customer[i];

                newRow.CreateCells(dgvCustomer_Lead);

                newRow.Cells[0].Value = lead.Idlead;
                newRow.Cells[1].Value = lead.Name;
                newRow.Cells[2].Value = lead.Date;
                newRow.Cells[3].Value = lead.Stage;
                newRow.Cells[4].Value = lead.Amount;
                newRow.Cells[5].Value = lead.AssignedTo;
                newRow.Cells[6].Value = lead.CreatedAt;

                dgvCustomer_Lead.Rows.Add(newRow);
            }
        }

    }
}
