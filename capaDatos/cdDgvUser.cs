using MySql.Data.MySqlClient;
using System;
using System.Collections;
using System.Windows.Forms;

namespace capaDatos
{
    public class cdDgvUser
    {
        string cadenaConexion = "Server=localhost;User=root;Password=TFG_ERP_C#;Port=3306;database=mydb;";

        //arraylist to getter and setter data  
        private static ArrayList idUsers = new ArrayList();
        private static ArrayList emailUsers = new ArrayList();
        private static ArrayList passUsers = new ArrayList();
        private static ArrayList departmentUsers = new ArrayList();
        private static ArrayList roleUsers = new ArrayList();
        
        public void resetData()
        {
            idUsers.Clear();
            emailUsers.Clear();
            passUsers.Clear();
            departmentUsers.Clear();
            roleUsers.Clear();
        }

        public void GetData()
        {
            try
            {
                resetData();
                MySqlConnection conn = new MySqlConnection(cadenaConexion);
                conn.Open();
                string query = "select u.idUser, u.email, u.password, dept.name, r.nameRole " +
                    "from department as dept " +
                    "join department_user as dept_us on dept_us.Department_idDepartment = dept.idDepartment " +
                    "join user as u on u.idUser = dept_us.User_idUser " +
                    "join role_user as ru on ru.User_idUser = u.idUser " +
                    "join role as r on ru.Role_idRole = r.idRole";

                MySqlCommand command = new MySqlCommand(query, conn);

                var row = command.ExecuteReader();

                if (row.HasRows)
                {
                    while (row.Read())
                    {
                        idUsers.Add(row["idUser"].ToString());
                        emailUsers.Add(row["email"].ToString());
                        passUsers.Add(row["password"].ToString());
                        departmentUsers.Add(row["name"].ToString());
                        roleUsers.Add(row["nameRole"].ToString());
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

        public void updateDatagrid(DataGridView dgvUser)
        {
            dgvUser.RowCount = 0;

            //dgvUser.Rows.Clear();
            for (int i = 0; i < idUsers.Count; i++)
            {
                DataGridViewRow newRow = new DataGridViewRow();

                newRow.CreateCells(dgvUser);
                newRow.Cells[0].Value = idUsers[i];
                newRow.Cells[1].Value = emailUsers[i];
                newRow.Cells[2].Value = passUsers[i];
                newRow.Cells[3].Value = departmentUsers[i];
                newRow.Cells[4].Value = roleUsers[i];
                dgvUser.Rows.Add(newRow);
            }
        }

    }
}
