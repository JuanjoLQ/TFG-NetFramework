using capaEntidad;
using MySql.Data.MySqlClient;
using Org.BouncyCastle.Utilities;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace capaDatos
{
    public class cdDoBackup
    {
        string cadenaConexion = "Server=localhost;User=root;Password=TFG_ERP_C#;Port=3306;database=mydb;";
        cdGlobals cdGlobals = new cdGlobals();

        public void doBackUp(string email)
        {
            try
            {
                string nameFile = string.Format("{0}.csv", DateTime.Now.ToString("dd.MM.yyyy HH.mm.ss"));
                MessageBox.Show(nameFile);
                //Pass the filepath and filename to the StreamWriter Constructor
                StreamWriter sw = new StreamWriter("C:\\Users\\Jesus\\Tfg Net Framework\\Tfg NetFramework\\backups\\" + nameFile);

                MySqlConnection conn = new MySqlConnection(cadenaConexion);
                conn.Open();
                
                sw = counts(sw, conn);
                sw = users(sw, conn);
                sw = customers(sw, conn);
                sw = roles(sw, conn);
                sw = companies(sw, conn);
                sw = departments(sw, conn);
                sw = leads(sw, conn);
                sw = mileages(sw, conn);
                sw = allowances(sw, conn);
                sw = role_users(sw, conn);
                sw = department_users(sw, conn);

                sw.Close();

                conn.Close();
            }
            catch (Exception err)
            {
                Console.WriteLine("Exception: " + err.Message);
            }
            finally
            {
                Console.WriteLine("Executing finally block.");
                cdGlobals.newLogEntry(email, "Copia de seguridad de la BBDD realizada correctamente");
            }
        }

        private StreamWriter counts(StreamWriter sw, MySqlConnection conn)
        {
            try
            {
                string query = "SELECT (SELECT COUNT(*) FROM user) as users, (SELECT COUNT(*) FROM customer) as customers, " +
                    "(SELECT COUNT(*) FROM role) as roles, (SELECT COUNT(*) FROM company) as companies, (SELECT COUNT(*) FROM department) as departments, " +
                    "(SELECT COUNT(*) FROM mydb.lead) as leads, (SELECT COUNT(*) FROM mileage) as mileages, (SELECT COUNT(*) FROM allowance) as allowances, " +
                    "(SELECT COUNT(*) FROM role_user) as role_users, (SELECT COUNT(*) FROM department_user) as department_users;";

                MySqlCommand command = new MySqlCommand(query, conn);

                var row = command.ExecuteReader();

                if (row.HasRows)
                {
                    while (row.Read())
                    {
                        string users = row["users"].ToString();
                        string customers = row["customers"].ToString();
                        string roles = row["roles"].ToString();
                        string companies = row["companies"].ToString();
                        string departments = row["departments"].ToString();
                        string leads = row["leads"].ToString();
                        string mileages = row["mileages"].ToString();
                        string allowances = row["allowances"].ToString();
                        string role_users = row["role_users"].ToString();
                        string department_users = row["department_users"].ToString();

                        sw.WriteLine("users: " + users + "," + " customers: " + customers + ", roles: " + roles + ", companies: " + companies + ", departments:" + departments + ", leads: " + leads + ", mileages: " + mileages + ", allowances: " + allowances + ", role_users: " + role_users + ", department_users: " + department_users);
                        sw.WriteLine(users + ","+ customers + "," + roles + "," + companies + "," + departments + "," + leads + "," + mileages + "," + allowances + "," + role_users + "," + department_users);
                    }
                }
                else
                {
                    MessageBox.Show("No hay leads correspondientes al fechado indicado.");
                }

                row.Close();// Close reader.
            }
            catch (Exception err)
            {
                MessageBox.Show(err.ToString());
                return null;
            }
            
            return sw;
        }

        private StreamWriter users(StreamWriter sw, MySqlConnection conn)
        {
            try
            {
                string query = "SELECT idUser, email, password FROM user;";

                sw.WriteLine("users");

                MySqlCommand command = new MySqlCommand(query, conn);

                var row = command.ExecuteReader();

                if (row.HasRows)
                {
                    while (row.Read())
                    {
                        string idUser = row["idUser"].ToString();
                        string email = row["email"].ToString();
                        string password = row["password"].ToString();

                        sw.WriteLine(idUser + "," + email + "," + password);
                    }
                }
                else
                {
                    MessageBox.Show("No hay leads correspondientes al fechado indicado.");
                }

                row.Close();// Close reader.
            }
            catch (Exception err)
            {
                MessageBox.Show(err.ToString());
                return null;
            }

            return sw;
        }
        
        private StreamWriter customers(StreamWriter sw, MySqlConnection conn)
        {
            try
            {
                string query = "SELECT idCustomer, name, phone, email, department, city, state, zip, country, adress1, adress2, type, notes, date FROM customer;";

                sw.WriteLine("customers");

                MySqlCommand command = new MySqlCommand(query, conn);

                var row = command.ExecuteReader();

                if (row.HasRows)
                {
                    while (row.Read())
                    {
                        string idCustomer = row["idCustomer"].ToString();
                        string name = row["name"].ToString();
                        string phone = row["phone"].ToString() == string.Empty ? "-" : row["phone"].ToString();
                        string email = row["email"].ToString() == string.Empty ? "-" : row["email"].ToString();
                        string department = row["department"].ToString() == string.Empty ? "-" : row["department"].ToString();
                        string city = row["city"].ToString() == string.Empty ? "-" : row["city"].ToString();
                        string state = row["state"].ToString() == string.Empty ? "-" : row["state"].ToString();
                        string zip = row["zip"].ToString() == string.Empty ? "-" : row["zip"].ToString();
                        string country = row["country"].ToString() == string.Empty ? "-" : row["country"].ToString();
                        string adress1 = row["adress1"].ToString() == string.Empty ? "-" : row["adress1"].ToString();
                        string adress2 = row["adress2"].ToString() == string.Empty ? "-" : row["adress2"].ToString();
                        string type = row["type"].ToString();
                        string notes = row["notes"].ToString() == string.Empty ? "-" : row["notes"].ToString();
                        string date = row["date"].ToString();

                        sw.WriteLine(idCustomer + "," + name + "," + phone + "," + email + "," + department + "," + city + "," + state + "," + zip + "," + country + "," + adress1 + "," + adress2 + "," + type + "," + notes + "," + date);
                    }
                }
                else
                {
                    MessageBox.Show("No hay leads correspondientes al fechado indicado.");
                }

                row.Close();// Close reader.
            }
            catch (Exception err)
            {
                MessageBox.Show(err.ToString());
                return null;
            }

            return sw;
        }

        private StreamWriter roles(StreamWriter sw, MySqlConnection conn)
        {
            try
            {
                string query = "SELECT idRole, nameRole, Privileges FROM role;";

                sw.WriteLine("roles");

                MySqlCommand command = new MySqlCommand(query, conn);

                var row = command.ExecuteReader();

                if (row.HasRows)
                {
                    while (row.Read())
                    {
                        string idRole = row["idRole"].ToString();
                        string nameRole = row["nameRole"].ToString();
                        string Privileges = row["Privileges"].ToString();

                        sw.WriteLine(idRole + "," + nameRole + "," + Privileges);
                    }
                }
                else
                {
                    MessageBox.Show("No hay leads correspondientes al fechado indicado.");
                }

                row.Close();// Close reader.
            }
            catch (Exception err)
            {
                MessageBox.Show(err.ToString());
                return null;
            }

            return sw;
        }

        private StreamWriter companies(StreamWriter sw, MySqlConnection conn)
        {
            try
            {
                string query = "SELECT idCompany, name FROM company;";

                sw.WriteLine("companies");

                MySqlCommand command = new MySqlCommand(query, conn);

                var row = command.ExecuteReader();

                if (row.HasRows)
                {
                    while (row.Read())
                    {
                        string idCompany = row["idCompany"].ToString();
                        string name = row["name"].ToString();

                        sw.WriteLine(idCompany + "," + name);
                    }
                }
                else
                {
                    MessageBox.Show("No hay leads correspondientes al fechado indicado.");
                }

                row.Close();// Close reader.
            }
            catch (Exception err)
            {
                MessageBox.Show(err.ToString());
                return null;
            }

            return sw;
        }

        private StreamWriter departments(StreamWriter sw, MySqlConnection conn)
        {
            try
            {
                string query = "SELECT idDepartment, name, Company_idCompany FROM department;";

                sw.WriteLine("departments");

                MySqlCommand command = new MySqlCommand(query, conn);

                var row = command.ExecuteReader();

                if (row.HasRows)
                {
                    while (row.Read())
                    {
                        string idDepartment = row["idDepartment"].ToString();
                        string name = row["name"].ToString();
                        string Company_idCompany = row["Company_idCompany"].ToString();

                        sw.WriteLine(idDepartment + "," + name + "," + Company_idCompany);
                    }
                }
                else
                {
                    MessageBox.Show("No hay leads correspondientes al fechado indicado.");
                }

                row.Close();// Close reader.
            }
            catch (Exception err)
            {
                MessageBox.Show(err.ToString());
                return null;
            }

            return sw;
        }

        private StreamWriter leads(StreamWriter sw, MySqlConnection conn)
        {
            try
            {
                string query = "SELECT idLead, name, date, stage, amount, notes, assignedTo, createdAt, Customer_idCustomer, User_idUser FROM mydb.lead;";

                sw.WriteLine("leads");

                MySqlCommand command = new MySqlCommand(query, conn);

                var row = command.ExecuteReader();

                if (row.HasRows)
                {
                    while (row.Read())
                    {
                        string idLead = row["idLead"].ToString();
                        string name = row["name"].ToString();
                        string date = row["date"].ToString();
                        string stage = row["stage"].ToString();
                        string amount = row["amount"].ToString() == string.Empty ? "-" : row["amount"].ToString();
                        string notes = row["notes"].ToString() == string.Empty ? "-" : row["notes"].ToString();
                        string assignedTo = row["assignedTo"].ToString();
                        string createdAt = row["createdAt"].ToString();
                        string Customer_idCustomer = row["Customer_idCustomer"].ToString(); 
                        string User_idUser = row["User_idUser"].ToString();

                        sw.WriteLine(idLead + "," + name + "," + date + "," + stage + "," + amount + "," + notes + "," + assignedTo + "," + createdAt + "," + Customer_idCustomer + "," + User_idUser);
                    }
                }
                else
                {
                    MessageBox.Show("No hay leads correspondientes al fechado indicado.");
                }

                row.Close();// Close reader.
            }
            catch (Exception err)
            {
                MessageBox.Show(err.ToString());
                return null;
            }

            return sw;
        }

        private StreamWriter mileages(StreamWriter sw, MySqlConnection conn)
        {
            try
            {
                string query = "SELECT idMileage, User_idUser, Title, Fechado, Subcategory, Origen, Destino, Kilometers, PricePerKilometer, Final, State FROM mileage;";

                sw.WriteLine("mileages");

                MySqlCommand command = new MySqlCommand(query, conn);

                var row = command.ExecuteReader();

                if (row.HasRows)
                {
                    while (row.Read())
                    {
                        string idMileage = row["idMileage"].ToString();
                        string User_idUser = row["User_idUser"].ToString();
                        string Title = row["Title"].ToString();
                        string Fechado = row["Fechado"].ToString();
                        string Subcategory = row["Subcategory"].ToString();
                        string Origen = row["Origen"].ToString();
                        string Destino = row["Destino"].ToString();
                        string Kilometers = row["Kilometers"].ToString();
                        string PricePerKilometer = row["PricePerKilometer"].ToString();
                        string Final = row["Final"].ToString();
                        string State = row["State"].ToString();

                        sw.WriteLine(idMileage + "," + User_idUser + "," + Title + "," + Fechado + "," + Subcategory + "," + Origen + "," + Destino + "," + Kilometers + "," + PricePerKilometer + "," + Final + "," + State);
                    }
                }
                else
                {
                    MessageBox.Show("No hay leads correspondientes al fechado indicado.");
                }

                row.Close();// Close reader.
            }
            catch (Exception err)
            {
                MessageBox.Show(err.ToString());
                return null;
            }

            return sw;
        }

        private StreamWriter allowances(StreamWriter sw, MySqlConnection conn)
        {
            try
            {
                string query = "SELECT idAllowance, User_idUser, Title, Observations, State, StartTime, EndTime, StartHour, EndHour, Invoice FROM allowance;";

                sw.WriteLine("allowances");

                MySqlCommand command = new MySqlCommand(query, conn);

                var row = command.ExecuteReader();

                if (row.HasRows)
                {
                    while (row.Read())
                    {
                        string idAllowance = row["idAllowance"].ToString();
                        string User_idUser = row["User_idUser"].ToString();
                        string Title = row["Title"].ToString();
                        string Observations = row["Observations"].ToString();
                        string State = row["State"].ToString();
                        string StartTime = row["StartTime"].ToString();
                        string EndTime = row["EndTime"].ToString() == string.Empty ? "-" : row["EndTime"].ToString();
                        string StartHour = row["StartHour"].ToString();
                        string EndHour = row["EndHour"].ToString();
                        string Invoice = row["Invoice"].ToString() == string.Empty ? "-" : row["Invoice"].ToString();

                        sw.WriteLine(idAllowance + "," + User_idUser + "," + Title + "," + Observations + "," + State + "," + StartTime + "," + EndTime + "," + StartHour + "," + EndHour + "," + Invoice);
                    }
                }
                else
                {
                    MessageBox.Show("No hay leads correspondientes al fechado indicado.");
                }

                row.Close();// Close reader.
            }
            catch (Exception err)
            {
                MessageBox.Show(err.ToString());
                return null;
            }

            return sw;
        }

        private StreamWriter role_users(StreamWriter sw, MySqlConnection conn)
        {
            try
            {
                string query = "SELECT User_idUser, Role_idRole FROM role_user;";

                sw.WriteLine("role_users");

                MySqlCommand command = new MySqlCommand(query, conn);

                var row = command.ExecuteReader();

                if (row.HasRows)
                {
                    while (row.Read())
                    {
                        string User_idUser = row["User_idUser"].ToString();
                        string Role_idRole = row["Role_idRole"].ToString();

                        sw.WriteLine(User_idUser + "," + Role_idRole);
                    }
                }
                else
                {
                    MessageBox.Show("No hay leads correspondientes al fechado indicado.");
                }

                row.Close();// Close reader.
            }
            catch (Exception err)
            {
                MessageBox.Show(err.ToString());
                return null;
            }

            return sw;
        }

        private StreamWriter department_users(StreamWriter sw, MySqlConnection conn)
        {
            try
            {
                string query = "SELECT Department_idDepartment, User_idUser FROM department_user;";

                sw.WriteLine("department_users");

                MySqlCommand command = new MySqlCommand(query, conn);

                var row = command.ExecuteReader();

                if (row.HasRows)
                {
                    while (row.Read())
                    {
                        string Department_idDepartment = row["Department_idDepartment"].ToString();
                        string User_idUser = row["User_idUser"].ToString();

                        sw.WriteLine(Department_idDepartment + "," + User_idUser);
                    }
                }
                else
                {
                    MessageBox.Show("No hay leads correspondientes al fechado indicado.");
                }

                row.Close();// Close reader.
            }
            catch (Exception err)
            {
                MessageBox.Show(err.ToString());
                return null;
            }

            return sw;
        }

    }
}
