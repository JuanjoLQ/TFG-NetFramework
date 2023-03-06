using capaEntidad;
using MySql.Data.MySqlClient;
using System;
using System.Collections;
using System.Windows.Forms;

namespace capaDatos
{
    public class cdPipelineFlps
    {
        string cadenaConexion = "Server=localhost;User=root;Password=TFG_ERP_C#;Port=3306;database=mydb;";

        public ArrayList updateFpls()
        {
            ArrayList array = new ArrayList();
            try
            {
                MySqlConnection conn = new MySqlConnection(cadenaConexion);
                conn.Open();
                string query = "SELECT user.idUser, mydb.lead.idLead, customer.idCustomer, user.email AS userEmail, mydb.lead.name AS nameLead, mydb.lead.date AS dateLead, " +
                    "mydb.lead.stage, mydb.lead.amount, mydb.lead.notes AS notesLead, mydb.lead.assignedTo, mydb.lead.createdAt, customer.name AS nameCustomer, " +
                    "customer.phone, customer.email AS customerEmail, customer.department, customer.city, customer.state, " +
                    "customer.zip, customer.country, customer.adress1, customer.adress2, customer.type, " +
                    "customer.notes AS notesCustomer, customer.date AS dateCustomer " +
                    "FROM((mydb.lead INNER JOIN user ON lead.User_idUser = user.idUser) " +
                    "INNER JOIN Customer ON mydb.lead.Customer_idCustomer = Customer.idCustomer);";

                MySqlCommand command = new MySqlCommand(query, conn);

                var row = command.ExecuteReader();
                
                if (row.HasRows)
                {
                    while (row.Read())
                    {
                        int idUser = int.Parse(row["idUser"].ToString());
                        int idLead = int.Parse(row["idLead"].ToString());
                        int idCustomer = int.Parse(row["idCustomer"].ToString());
                        string userEmail = row["userEmail"].ToString();
                        string nameLead = row["nameLead"].ToString();
                        string dateLead = row["dateLead"].ToString();
                        string stage = row["stage"].ToString();
                        int amount = int.Parse(row["amount"].ToString());
                        string notesLead = row["notesLead"].ToString();
                        string assignedTo = row["assignedTo"].ToString();
                        string createdAt = row["createdAt"].ToString();
                        string nameCustomer = row["nameCustomer"].ToString();
                        string phone = row["phone"].ToString();
                        string customerEmail = row["customerEmail"].ToString();
                        string department = row["department"].ToString();
                        string city = row["city"].ToString();
                        string state = row["state"].ToString();
                        string zip = row["zip"].ToString();
                        string country = row["country"].ToString();
                        string adress1 = row["adress1"].ToString();
                        string adress2 = row["adress2"].ToString();
                        string type = row["type"].ToString();
                        string notesCustomer = row["notesCustomer"].ToString();
                        string dateCustomer = row["dateCustomer"].ToString();

                        ceUser user = new ceUser(idUser, 0, userEmail, null);
                        ceLead lead = new ceLead(idLead, nameLead, dateLead, stage, amount, notesLead, 
                            assignedTo, createdAt, idCustomer, idUser);
                        ceCustomer customer = new ceCustomer(idCustomer.ToString(), nameCustomer, phone, customerEmail, 
                            department, city, state, zip, country, adress1, adress2, type, notesCustomer, dateCustomer);
                        ceDescripcionItem ceDescripcionItem = new ceDescripcionItem(user, lead, customer);
                        array.Add(ceDescripcionItem);
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

    }
}
