using Bunifu.UI.WinForms;
using MySql.Data.MySqlClient;
using System;
using System.Collections;
using System.Windows.Forms;

namespace capaDatos
{
    public class cdDgvReminder
    {
        string cadenaConexion = "Server=localhost;User=root;Password=TFG_ERP_C#;Port=3306;database=mydb;";

        //arraylist to getter and setter data  

        private static ArrayList idReminders = new ArrayList();
        private static ArrayList titles = new ArrayList();
        private static ArrayList observations = new ArrayList();
        private static ArrayList date = new ArrayList();
        private static ArrayList hours = new ArrayList();

        private void resetData()
        {
            idReminders.Clear();
            titles.Clear();
            observations.Clear();
            date.Clear();
            hours.Clear();
        }

        public void GetData()
        {
            try
            {
                resetData();
                MySqlConnection conn = new MySqlConnection(cadenaConexion);
                conn.Open();
                string query = "SELECT idReminder, title, reminder, date, hour FROM reminder;";

                MySqlCommand command = new MySqlCommand(query, conn);

                var row = command.ExecuteReader();

                if (row.HasRows)
                {
                    while (row.Read())
                    {
                        idReminders.Add(row["idReminder"].ToString());
                        titles.Add(row["title"].ToString());
                        observations.Add(row["reminder"].ToString());
                        date.Add(row["date"].ToString());
                        hours.Add(row["hour"].ToString());
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

        public void updateDatagrid(BunifuDataGridView dgvReminder)
        {
            dgvReminder.RowCount = 0;
            for (int i = 0; i < titles.Count; i++)
            {
                DataGridViewRow newRow = new DataGridViewRow();

                newRow.CreateCells(dgvReminder);
                newRow.Cells[0].Value = idReminders[i];
                newRow.Cells[1].Value = titles[i];
                newRow.Cells[2].Value = observations[i];
                newRow.Cells[4].Value = date[i];
                newRow.Cells[5].Value = hours[i];

                dgvReminder.Rows.Add(newRow);
            }
        }



    }
}
