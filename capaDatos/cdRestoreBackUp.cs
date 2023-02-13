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
        cdDeleteBBDD cdDeleteBBDD = new cdDeleteBBDD();

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

            backup.Add(string.Empty);
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

            MySqlConnection conn = new MySqlConnection(cadenaConexion);
            conn.Open();

            
            // Borrar BBDD entera, dejando un usuario admin
            cdDeleteBBDD.deleteBBDD(conn);

            conn.Close();

            conn = new MySqlConnection(cadenaConexion);
            conn.Open();

            MessageBox.Show("Después deleteBBDD");
            
            //
            // Hasta aquí funciona bien
            //
            MessageBox.Show("Se va a restaurar: " + backup[1]);

            string[] words = backup[2].ToString().Split(',');

            int start = 4;
            int end = start + int.Parse(words[0]);

            // users 4 12
            for (int i = start; i < end; i++)
            {
                users(backup[i], conn);
            }

            MessageBox.Show("Users: Inicio: ", + start + ", end: " + end);

            start = end + 1;
            end += int.Parse(words[1]) + 1;
            // customers 13 16
            for (int i = start; i < end; i++)
            {
                customers(backup[i], conn);
            }
            MessageBox.Show("Customers: Inicio: " + start + ", end: " + end + " Words[1] = " + words[1]);

            // roles 17 21
            start = end + 1;
            end += int.Parse(words[2]) + 1;

            for (int i = start; i < end; i++)
            {
                roles(backup[i], conn);
            }
            MessageBox.Show("Roles: Inicio: " + start + ", end: " + end);

            // companies 22 23
            start = end + 1;
            end += int.Parse(words[3]) + 1;

            for (int i = start; i < end; i++)
            {
                companies(backup[i], conn);
            }
            MessageBox.Show("Companies: Inicio: " + start + ", end: " + end);

            // departments 24 28
            start = end + 1;
            end += int.Parse(words[4]) + 1;

            for (int i = start; i < end; i++)
            {
                MessageBox.Show(backup[i]);
                departments(backup[i], conn);
            }
            MessageBox.Show("Departments: Inicio: " + start + ", end: " + end);

            // leads 29 30
            start = end + 1;
            end += int.Parse(words[5]) + 1;

            for (int i = start; i < end; i++)
            {
                leads(backup[i], conn);
            }
            MessageBox.Show("Leads: Inicio: " + start + ", end: " + end);

            // mileages 31 31
            start = end + 1;
            end += int.Parse(words[6]) + 1;

            for (int i = start; i < end; i++)
            {
                mileages(backup[i], conn);
            }
            MessageBox.Show("Mileages: Inicio: " + start + ", end: " + end);

            // allowances 32 32
            start = end + 1;
            end += int.Parse(words[7]) + 1;

            for (int i = start; i < end; i++)
            {
                allowances(backup[i], conn);
            }
            MessageBox.Show("Allowances: Inicio: " + start + ", end: " + end);

            // role_users 33 39
            start = end + 1;
            end += int.Parse(words[8]) + 1;

            for (int i = start; i < end; i++)
            {
                role_users(backup[i], conn);
            }
            MessageBox.Show("Role_Users: Inicio: " + start + ", end: " + end);

            // department_users 40 45
            start = end + 1;
            end += int.Parse(words[9]) + 1;

            for (int i = start; i < end; i++)
            {
                departments_users(backup[i], conn);
            }
            MessageBox.Show("Department_Users: Inicio: " + start + ", end: " + end);

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
                string date = parts[13].Replace("/", "-");

                string[] dates = date.Split(' ');
                string[] partsDate = dates[0].Split('-');
                date = partsDate[2] + "-" + partsDate[1] + "-" + partsDate[0] + " " + dates[1];

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
                // Date Conversión a DateTime
                //string date = parts[2].Replace("/", "-");
                //string[] dates = date.Split(' ');
                //string[] partsDate = dates[0].Split('-');
                //date = partsDate[2] + "-" + partsDate[1] + "-" + partsDate[0] + " " + dates[1];
                string date = parts[2];

                //
                string stage = parts[3];
                string amount = parts[4];
                string notes = parts[5];
                string assignedTo = parts[6];
                //string createdAt = parts[7];
                // createdAt Date Conversión a DateTime
                string createdAt = parts[7].Replace("/", "-");
                string[] createdAts = createdAt.Split(' ');
                string[] partsCreatedAt = createdAts[0].Split('-');
                createdAt = partsCreatedAt[2] + "-" + partsCreatedAt[1] + "-" + partsCreatedAt[0] + " " + createdAts[1];
                //
                string Customer_idCustomer = parts[8];
                string User_idUser = parts[9];

                MessageBox.Show("Lead Date: " + date);
                MessageBox.Show("Lead createdAt: " + createdAt);

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
