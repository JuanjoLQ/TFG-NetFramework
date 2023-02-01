﻿using capaEntidad;
using MySql.Data.MySqlClient;
using System;
using System.Collections;
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
        ceLead ceLead = null;
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

                cmd.ExecuteNonQuery();
            }
            MessageBox.Show("Lead añadido", "Juanjo", MessageBoxButtons.OK, MessageBoxIcon.Information);

            conn.Close();

            return true;
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

    }
}
