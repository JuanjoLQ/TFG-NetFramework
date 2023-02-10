using capaEntidad;
using MySql.Data.MySqlClient;
using Org.BouncyCastle.Tls.Crypto;
using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace capaDatos
{
    public class cdRestoreBackUp
    {
        cdUser cdUser = new cdUser();
        cdCustomer cdCustomer = new cdCustomer();
        cdRole cdRole = new cdRole();
        cdCompany cdCompany = new cdCompany();
        cdDepartment cdDepartment = new cdDepartment();
        cdLead cdLead = new cdLead();
        cdMileage cdMileage = new cdMileage();
        cdAllowance cdAllowance = new cdAllowance();
        cdRoleUser cdRoleUser = new cdRoleUser();
        cdDepartmentUser cdDepartmentUser = new cdDepartmentUser();

        List<string> backup = new List<string>();

        string cadenaConexion = "Server=localhost;User=root;Password=TFG_ERP_C#;Port=3306;database=mydb;";
        public void restoreBackUp(string path) 
        {
            string line;
            //Pass the file path and file name to the StreamReader constructor
            StreamReader sr = new StreamReader(path);
            //Read the first line of text
            line = sr.ReadLine();
            //Continue to read until you reach end of file
            while (line != null)
            {
                //write the line to console window
                Console.WriteLine(line);
                backup.Add(line);
                //Read the next line
                line = sr.ReadLine();
            }
            //close the file
            sr.Close();

            //

            // Borrar BBDD entera

            //

            MessageBox.Show("Se va a restaurar: " + backup[0]);

            string[] words = backup[1].ToString().Split(',');

            int start = 3; 
            int end = start + int.Parse(words[0]);

            MySqlConnection conn = new MySqlConnection(cadenaConexion);
            conn.Open();

            // users
            for (int i = start; i < end; i++)
            {
                users(backup[i], conn);
            }

            start = end;
            end += int.Parse(words[1]);
            // customers
            for (int i = start; i < end; i++)
            {
                customers(backup[i], conn);
            }

            // roles
            start = end;
            end += int.Parse(words[2]);

            for (int i = start; i < end; i++)
            {
                roles(backup[i], conn);
            }

            // companies
            start = end;
            end += int.Parse(words[3]);

            for (int i = start; i < end; i++)
            {
                companies(backup[i], conn);
            }

            // departments
            start = end;
            end += int.Parse(words[4]);

            for (int i = start; i < end; i++)
            {
                departments(backup[i], conn);
            }
            // leads
            start = end;
            end += int.Parse(words[5]);

            for (int i = start; i < end; i++)
            {
                leads(backup[i], conn);
            }

            // mileages
            start = end;
            end += int.Parse(words[6]);

            for (int i = start; i < end; i++)
            {
                mileages(backup[i], conn);
            }

            // allowances
            start = end;
            end += int.Parse(words[7]);

            for (int i = start; i < end; i++)
            {
                allowances(backup[i], conn);
            }

            // role_users
            start = end;
            end += int.Parse(words[8]);

            for (int i = start; i < end; i++)
            {
                role_users(backup[i], conn);
            }


            // department_users
            start = end;
            end += int.Parse(words[9]);

            for (int i = start; i < end; i++)
            {
                departments_users(backup[i], conn);
            }

            conn.Close();

        }

        private void users(string line, MySqlConnection conn)
        {
            try
            {
                string[] parts = line.Split(',');
                
                string idUser = parts[0];
                string email = parts[1];
                string password = parts[2];

                ceUser user = new ceUser(idUser, email, password);

                cdUser.addUser(user, conn);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void customers(string line, MySqlConnection conn)
        {
            try
            {
                string[] parts = line.Split(',');

                string idCustomer = parts[0];
                string name = parts[1];
                string phone = parts[2] == "-" ? string.Empty : parts[2];
                string email = parts[3] == "-" ? string.Empty : parts[3];
                string department = parts[4] == "-" ? string.Empty : parts[4];
                string city = parts[5] == "-" ? string.Empty : parts[5];
                string state = parts[6] == "-" ? string.Empty : parts[6];
                string zip = parts[7] == "-" ? string.Empty : parts[7];
                string country = parts[8] == "-" ? string.Empty : parts[8];
                string address1 = parts[9] == "-" ? string.Empty : parts[9];
                string address2 = parts[10] == "-" ? string.Empty : parts[10];
                string type = parts[11];
                string notes = parts[12] == "-" ? string.Empty : parts[12];
                string date = parts[13];

                ceCustomer customer = new ceCustomer(idCustomer, name, phone, email, department, 
                    city, state, zip, country, address1, address2, type, notes, date);

                cdCustomer.addCustomer(customer, conn);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void roles(string line, MySqlConnection conn)
        {
            try
            {
                string[] parts = line.Split(',');

                string idRole = parts[0];
                string nameRole = parts[1];
                string privileges = parts[2];

                ceRole role = new ceRole(int.Parse(idRole), nameRole, privileges);

                cdRole.addRole(role, conn);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void companies(string line, MySqlConnection conn)
        {
            try
            {
                string[] parts = line.Split(',');

                string idCompany = parts[0];
                string name = parts[1];

                ceCompany company = new ceCompany(int.Parse(idCompany), name);

                cdCompany.addCompany(company, conn);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void departments(string line, MySqlConnection conn)
        {
            try
            {
                string[] parts = line.Split(',');

                string idDepartment = parts[0];
                string name = parts[1];
                string Company_idCompany = parts[2];

                ceDepartment department = new ceDepartment(int.Parse(idDepartment), name, int.Parse(Company_idCompany));

                cdDepartment.addDepartment(department, conn);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void leads(string line, MySqlConnection conn)
        {
            try
            {
                string[] parts = line.Split(',');

                string idLead = parts[0];
                string name = parts[1];
                string date = parts[2];
                string stage = parts[3];
                string amount = parts[4];
                string notes = parts[5];
                string assignedTo = parts[6];
                string createdAt = parts[7];
                string Customer_idCustomer = parts[8];
                string User_idUser = parts[9];

                ceLead lead = new ceLead(int.Parse(idLead), name, date, stage, 
                    int.Parse(amount), notes, assignedTo, createdAt, 
                    int.Parse(Customer_idCustomer), int.Parse(User_idUser));

                cdLead.addLead(lead, conn);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void mileages(string line, MySqlConnection conn)
        {
            try
            {
                string[] parts = line.Split(',');

                string idMileage = parts[0];
                string User_idUser = parts[1];
                string title = parts[2];
                string fechado = parts[3];
                string subcategory = parts[4];
                string origen = parts[5];
                string destino = parts[6];
                string kilometers = parts[7];
                string priceperkilometer = parts[8];
                string final = parts[9];
                string state = parts[10];

                ceMileage mileage = new ceMileage(int.Parse(idMileage), int.Parse(User_idUser), 
                    title, fechado, subcategory, origen, destino, float.Parse(kilometers), 
                    float.Parse(priceperkilometer), float.Parse(final), state);

                cdMileage.addMileage(mileage, conn);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void allowances(string line, MySqlConnection conn)
        {
            try
            {
                string[] parts = line.Split(',');

                string idAllowance = parts[0];
                string User_idUser = parts[1];
                string title = parts[2];
                string observations = parts[3];
                string state = parts[4];
                string startTime = parts[5];
                string endTime = parts[6] == "-" ? string.Empty : parts[6];
                string startHour = parts[7];
                string endHour = parts[8];
                string invoice = parts[9] == "-" ? string.Empty : parts[9];

                ceAllowance allowance = new ceAllowance(int.Parse(idAllowance), int.Parse(User_idUser), title, observations, state, startTime, endTime, startHour, endHour, invoice);

                cdAllowance.addAllowance(allowance, conn);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void role_users(string line, MySqlConnection conn)
        {
            try
            {
                string[] parts = line.Split(',');

                string User_idUser = parts[0];
                string Role_idRole = parts[1];


                ceRole_User role_user = new ceRole_User(int.Parse(User_idUser), int.Parse(Role_idRole));

                cdRoleUser.addRoleUser(role_user, conn);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void departments_users(string line, MySqlConnection conn)
        {
            try
            {
                string[] parts = line.Split(',');

                string Department_idDepartment = parts[0];
                string User_idUser = parts[1];


                ceDepartment_User department_user = new ceDepartment_User(int.Parse(Department_idDepartment), int.Parse(User_idUser));

                cdDepartmentUser.addDepartmentUser(department_user, conn);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
