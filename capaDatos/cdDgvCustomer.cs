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

namespace capaDatos
{
    public class cdDgvCustomer
    {
        string cadenaConexion = "Server=localhost;User=root;Password=TFG_ERP_C#;Port=3306;database=mydb;";

        private ArrayList arrayCustomers = new ArrayList();

        private void resetData()
        {
            arrayCustomers.Clear();
        }

        public void getData()
        {
            try
            {
                resetData();
                MySqlConnection conn = new MySqlConnection(cadenaConexion);
                conn.Open();
                string query = "SELECT c.idCustomer, c.name, c.phone, c.email, c.department, c.city, c.country, " +
                    "c.type, COUNT(mydb.lead.idLead) AS leads " +
                    "FROM customer AS c " +
                    "LEFT JOIN mydb.lead ON c.idCustomer = mydb.lead.Customer_idCustomer " +
                    "GROUP BY c.name;";

                MySqlCommand command = new MySqlCommand(query, conn);

                var row = command.ExecuteReader();

                var idCustomer = string.Empty;
                var name = string.Empty;
                var phone = string.Empty;
                var email = string.Empty;
                var department = string.Empty;
                var city = string.Empty;
                var country = string.Empty;
                var type = string.Empty;
                var leads = string.Empty;

                if (row.HasRows)
                {
                    while (row.Read())
                    {
                        idCustomer = row["idCustomer"].ToString();
                        name = row["name"].ToString();
                        phone = row["phone"].ToString();
                        email = row["email"].ToString();
                        department = row["department"].ToString();
                        city = row["city"].ToString();
                        country = row["country"].ToString();
                        type = row["type"].ToString();
                        leads = row["leads"].ToString();

                        ceCustomer customer = new ceCustomer(idCustomer, name, phone, email, department, city, country, type, leads);

                        arrayCustomers.Add(customer);
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

        public void updateDatagrid(DataGridView dgvCustomer)
        {
            dgvCustomer.RowCount = 0;
            ceCustomer customer = null;

            for (int i = 0; i < arrayCustomers.Count; i++)
            {
                DataGridViewRow newRow = new DataGridViewRow();
                
                customer = null;
                customer = (ceCustomer) arrayCustomers[i];

                newRow.CreateCells(dgvCustomer);

                newRow.Cells[0].Value = customer.idCustomer;
                newRow.Cells[1].Value = customer.Name;
                newRow.Cells[2].Value = customer.Phone;
                newRow.Cells[3].Value = customer.Email;
                newRow.Cells[4].Value = customer.Department;
                newRow.Cells[5].Value = customer.City;
                newRow.Cells[6].Value = customer.Country;
                newRow.Cells[7].Value = customer.Type;
                newRow.Cells[8].Value = customer.Leads;

                dgvCustomer.Rows.Add(newRow);
            }

        }

    }
}
