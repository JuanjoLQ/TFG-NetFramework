using MySql.Data.MySqlClient;
using capaEntidad;
using System.Windows.Forms;
using System.IO;

namespace capaDatos
{
    public class cdAllowance
    {
        string cadenaConexion = "Server=localhost;User=root;Password=TFG_ERP_C#;Port=3306;database=mydb;";

        public bool insertAllowance(ceAllowance allowance)
        {
            MySqlConnection conn = new MySqlConnection(cadenaConexion);
            conn.Open();
            string query = "INSERT INTO allowance (User_idUser, Title, Observations, State, StartTime, StartHour, EndHour) VALUES " +
                "('" + allowance.User_idUser + "', '" + allowance.title + "', '" + allowance.observations + "', '" + allowance.state + "', '" + allowance.startTime + "', '" + allowance.startHour + "', '" + allowance.endHour + "');";
            MySqlCommand command = new MySqlCommand(query, conn);
            command.ExecuteNonQuery();
            conn.Close();

            return true;
        }

        public void addAllowance(ceAllowance allowance, MySqlConnection conn)
        {
            try
            {
                using (MySqlCommand cmd = new MySqlCommand("INSERT INTO allowance (idAllowance, User_idUser, Title, Observations, State, StartTime, EndTime, " +
                    "StartHour, EndHour, Invoice) VALUES (@idAllowance, @User_idUser, @Title, @Observations, @State, @StartTime, @EndTime, " +
                    "@StartHour, @EndHour, @Invoice);", conn))
                {
                    cmd.Parameters.AddWithValue("@idAllowance", allowance.idAllowance);
                    cmd.Parameters.AddWithValue("@User_idUser", allowance.User_idUser);
                    cmd.Parameters.AddWithValue("@Title", allowance.title);
                    cmd.Parameters.AddWithValue("@Observations", allowance.observations);
                    cmd.Parameters.AddWithValue("@State", allowance.state);
                    cmd.Parameters.AddWithValue("@StartTime", allowance.startTime);
                    cmd.Parameters.AddWithValue("@EndTime", allowance.endTime);
                    cmd.Parameters.AddWithValue("@StartHour", allowance.startHour);
                    cmd.Parameters.AddWithValue("@EndHour", allowance.endHour);
                    cmd.Parameters.AddWithValue("@Invoice", allowance.invoice);

                    cmd.ExecuteNonQuery();
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.ToString());
            }

        }

        public void updateAllowance(int idAllowance, string state)
        {
            MySqlConnection conn = new MySqlConnection(cadenaConexion);
            MySqlCommand cmd;
            conn.Open();

            using (cmd = new MySqlCommand("update allowance set state = @state where idAllowance = @idAllowance;", conn))
            {
                cmd.Parameters.AddWithValue("@state", state);
                cmd.Parameters.AddWithValue("@idAllowance", idAllowance);
                cmd.ExecuteNonQuery();
            }
            MessageBox.Show("Dieta modificada", "Juanjo", MessageBoxButtons.OK, MessageBoxIcon.Information);

            conn.Close();
        }

        public void deleteAllowance(int idAllowance)
        {
            MySqlConnection conn = new MySqlConnection(cadenaConexion);
            MySqlCommand cmd;
            conn.Open();

            using (cmd = new MySqlCommand("delete from allowance where idAllowance = @idAllowance;", conn))
            {
                cmd.Parameters.AddWithValue("@idAllowance", idAllowance);
                cmd.ExecuteNonQuery();
            }
            MessageBox.Show("Dieta eliminada", "Juanjo", MessageBoxButtons.OK, MessageBoxIcon.Information);

            conn.Close();
        }

        public void uploadFile(ceAllowance allowance, string fileName)
        {
            MySqlConnection conn = new MySqlConnection(cadenaConexion);
            MySqlCommand cmd;
            conn.Open();

            /*
            System.IO.FileStream fileStream = File.OpenRead(file);
            byte[] contents = new byte[fileStream.Length];
            fileStream.Read(contents, 0, (int)fileStream.Length);
            fileStream.Close();
            */

            //
            string name = Path.GetFileName(fileName);
            string newPath = @"C:\Users\Jesus\Tfg Net Framework\Tfg NetFramework\files\";
            string locationCopy = newPath + name;
            // MessageBox.Show("Location Copy: " + locationCopy + "\nFileName: " + fileName);

            if (File.Exists(fileName))
            {
                File.Copy(fileName, locationCopy, true);
                // MessageBox.Show("File Copied");
            }

            using (cmd = new MySqlCommand("insert into allowance(User_idUser, Title, Observations, State, StartTime, StartHour, EndHour, Invoice) " +
                "values(@idUser, @title, @observations, @state, @startTime, @startHour, @endHour, @invoice)", conn))
            {
                cmd.Parameters.AddWithValue("@idUser", allowance.User_idUser);
                cmd.Parameters.AddWithValue("@title", allowance.title);
                cmd.Parameters.AddWithValue("@observations", allowance.observations);
                cmd.Parameters.AddWithValue("@state", allowance.state);
                cmd.Parameters.AddWithValue("@startTime", allowance.startTime);
                cmd.Parameters.AddWithValue("@startHour", allowance.startHour);
                cmd.Parameters.AddWithValue("@endHour", allowance.endHour);
                MessageBox.Show("location pdf: " + locationCopy);
                cmd.Parameters.AddWithValue("@invoice", locationCopy);
                cmd.ExecuteNonQuery();
            }
            MessageBox.Show("Finished uploading files", "Juanjo", MessageBoxButtons.OK, MessageBoxIcon.Information);

            conn.Close();
        }

    }
}