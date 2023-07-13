using Bunifu.UI.WinForms;
using capaEntidad;
using MySql.Data.MySqlClient;
using System;
using System.Collections;
using System.Windows.Forms;

namespace capaDatos
{
    public class cdReminder
    {
        string cadenaConexion = "Server=localhost;User=root;Password=TFG_ERP_C#;Port=3306;database=mydb;";

        public void addReminder(int idUser, ceReminder reminder)
        {
            try
            {
                MySqlConnection conn = new MySqlConnection(cadenaConexion);
                MySqlCommand cmd;
                conn.Open();

                using (cmd = new MySqlCommand("insert into Reminder (title, reminder, date, " +
                "hour, User_idUser) values(@title, @reminder, @date, @hour, @User_idUser);", conn))
                {
                    cmd.Parameters.AddWithValue("@title", reminder.title);
                    cmd.Parameters.AddWithValue("@reminder", reminder.reminder);
                    cmd.Parameters.AddWithValue("@date", reminder.date);
                    cmd.Parameters.AddWithValue("@hour", reminder.hour);
                    cmd.Parameters.AddWithValue("@User_idUser", idUser);

                    cmd.ExecuteNonQuery();
                }
                MessageBox.Show("Recordatorio añadido", "Juanjo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void removeReminder(int idUser, int idReminder)
        {
            try
            {
                MySqlConnection conn = new MySqlConnection(cadenaConexion);
                MySqlCommand cmd;
                conn.Open();

                using (cmd = new MySqlCommand("DELETE FROM Reminder WHERE idReminder = @idReminder and User_idUser = @idUser;", conn))
                {
                    cmd.Parameters.AddWithValue("@idReminder", idReminder);
                    cmd.Parameters.AddWithValue("@idUser", idUser);
                    cmd.ExecuteNonQuery();
                }
                MessageBox.Show("Recordatorio Eliminado", "Juanjo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                conn.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void updateReminder(ceReminder reminder)
        {
            try
            {
                MySqlConnection conn = new MySqlConnection(cadenaConexion);
                MySqlCommand cmd;
                conn.Open();

                using (cmd = new MySqlCommand("UPDATE Reminder SET title = @title, reminder = @reminder, date = @date, hour = @hour WHERE idReminder = @idReminder;", conn))
                {
                    cmd.Parameters.AddWithValue("@title", reminder.title);
                    cmd.Parameters.AddWithValue("@reminder", reminder.reminder);
                    cmd.Parameters.AddWithValue("@date", reminder.date);
                    cmd.Parameters.AddWithValue("@hour", reminder.hour);
                    cmd.Parameters.AddWithValue("@idReminder", reminder.idReminder);
                    cmd.ExecuteNonQuery();
                }
                MessageBox.Show("Recordatorio Actualizado", "Juanjo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void checkReminder(int idUser, NotifyIcon notifyIcon)
        {
            try
            {
                MySqlConnection conn = new MySqlConnection(cadenaConexion);
                conn.Open();
                string query = "SELECT idReminder, title, reminder, hour FROM Reminder WHERE date <= NOW()";

                MySqlCommand command = new MySqlCommand(query, conn);

                var row = command.ExecuteReader();

                if (row.HasRows)
                {
                    while (row.Read())
                    {
                        int idReminder = 0;
                        idReminder = int.Parse(row["idReminder"].ToString());
                        
                        if (idReminder != 0)
                        {
                            string title = row["title"].ToString();
                            string reminder = row["reminder"].ToString();
                            string hour = row["hour"].ToString();

                            notifyIcon.BalloonTipTitle = title + " " + hour;
                            notifyIcon.BalloonTipText = reminder;
                            notifyIcon.ShowBalloonTip(5000);
                        }                        
                    }
                }                

                row.Close();// Close reader.
                conn.Close();// Close connection.
            }
            catch (Exception err)
            {
                MessageBox.Show(err.ToString());
            }
        }

        public void updateDgvReminders(BunifuDataGridView dgvReminder, int idUser)
        {
            dgvReminder.RowCount = 0;
            ArrayList array = new ArrayList();
            try
            {
                array.Clear();
                MySqlConnection conn = new MySqlConnection(cadenaConexion);
                conn.Open();
                string query = "SELECT idReminder, title, reminder, date, hour FROM Reminder WHERE User_idUser = ?idUser;";

                MySqlCommand command = new MySqlCommand(query, conn);
                command.Parameters.AddWithValue("?idUser", idUser);

                var row = command.ExecuteReader();

                if (row.HasRows)
                {
                    while (row.Read())
                    {
                        int idReminder = int.Parse(row["idReminder"].ToString());
                        string title = row["title"].ToString();
                        string reminderText = row["reminder"].ToString();
                        string date = row["date"].ToString();
                        string hour = row["hour"].ToString();

                        array.Add(new ceReminder(idReminder, title, reminderText, date, hour));
                    }
                }
                
                row.Close();// Close reader.
                conn.Close();// Close connection.

                ceReminder reminder = null;
                for (int i = 0; i < array.Count; i++)
                {
                    DataGridViewRow newRow = new DataGridViewRow();

                    reminder = null;
                    reminder = (ceReminder)array[i];

                    newRow.CreateCells(dgvReminder);

                    newRow.Cells[0].Value = reminder.idReminder;
                    newRow.Cells[1].Value = reminder.title;
                    newRow.Cells[2].Value = reminder.reminder;
                    newRow.Cells[3].Value = reminder.date;
                    newRow.Cells[4].Value = reminder.hour;

                    dgvReminder.Rows.Add(newRow);
                }
            }
            catch (Exception err)
            {
                MessageBox.Show(err.ToString());
            }
        }

    }
}
