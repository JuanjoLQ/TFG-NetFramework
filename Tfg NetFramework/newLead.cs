using CapaNegocio;
using capaEntidad;
using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Collections;
using System.Data.SqlClient;
using capaNegocio;
using capaDatos;

namespace Tfg_NetFramework
{
    public partial class newLead : Form
    {
        cnLead cnLead = new cnLead();
        cdGlobals cdGlobals = new cdGlobals();
        cnUser cnUser = new cnUser();
        cnCustomer cnCustomer = new cnCustomer();
        Dictionary<Tuple<string, string>, string> departments_employees = new Dictionary<Tuple<string, string>, string>();
        ArrayList customers = new ArrayList();
        string email;

        public newLead(string email)
        {
            InitializeComponent();
            this.email = email;

        }

        private void newLead_Load(object sender, EventArgs e)
        {

            //Labels
            blbNewLeadTitle.Text = "<h2>" + Res.NewLead + "</h2>";
            lbNewLeadName.Text = "<h4>" + Res.LeadName + "*:" + "</h4>";
            lbNewLeadDate.Text = "<h4>" + Res.date + "*:" + "</h4>";
            lbNewLeadStage.Text = "<h4>" + Res.Stage + "*:" + "</h4>";
            lbNewLeadAmount.Text = "<h4>" + Res.Amount + "</h4>";
            lbNewLeadNotes.Text = "<h4>" + Res.Notes + "</h4>";
            lbNewLeadAssignedTo.Text = "<h4>" + Res.AssignedTo + "*:" + "</h4>";
            lbNewLeadDepartment.Text = "<h4>" + Res.department + "</h4>";
            lbNewLeadEmployee.Text = "<h4>" +  Res.Employees + "</h4>";
            lbNewLeadCustomer.Text = "<h4>" + Res.Customer + "</h4>";
            lbNewLeadCreatedAt.Text = "<h4>" + Res.CreatedAt + "*:" + "</h4>";

            //Textboxs
            tbNewLeadName.PlaceholderText = Res.LeadName ;
            tbNewLeadAmount.PlaceholderText = Res.LeadAmount ;
            tbNewLeadNotes.PlaceholderText = Res.LeadNotes ;

            //Buttons
            bbtnCancel.Text = Res.Exit;
            bbtnSave.Text = Res.Save;

            ArrayList array = new ArrayList();
            try
            {
                cbNewLeadAssignedTo.Items.Clear();
                departments_employees = cnUser.obtainEmployeesPerDepartment(departments_employees);

                foreach (var k in departments_employees.Keys)
                {
                    if (!cbNewLeadAssignedTo.Items.Contains(k.Item1.ToString()))
                    {
                        cbNewLeadAssignedTo.Items.Add(k.Item1.ToString());
                    }
                }

                lBNewLeadCustomers.Items.Clear();
                array.Clear();

                customers.Clear();
                customers = cnCustomer.getCustomers(customers);

                foreach (Tuple <string, string, string> item in customers)
                {
                    lBNewLeadCustomers.Items.Add(item.Item1 + " (" + item.Item2 + ")");
                }
            }
            catch (SqlException ex)
            {
                // Handle the SQL Exception as you wish
                Console.WriteLine(ex.ToString());
            }
        }

        private void cbNewLeadAssignedTo_SelectedIndexChanged(object sender, EventArgs e)
        {
            lBNewLeadEmployees.Items.Clear();

            foreach (var k in departments_employees.Keys) if (cbNewLeadAssignedTo.SelectedItem.ToString() == k.Item1)
            {
                lBNewLeadEmployees.Items.Add(k.Item2);
            }
        }

        private void btnNewLeadSave_Click(object sender, EventArgs e)
        {
            var idCustomer = string.Empty;
            var idUser = string.Empty;

            string newLeadStage = cbNewLeadStage.SelectedItem == null ? String.Empty :
                    cbNewLeadStage.SelectedItem.ToString();

            string newLeadEmployees = lBNewLeadEmployees.SelectedItem == null ? String.Empty :
                    lBNewLeadEmployees.SelectedItem.ToString();

            string newLeadCustomers = lBNewLeadCustomers.SelectedItem == null ? String.Empty :
                    lBNewLeadCustomers.SelectedItem.ToString();

            if (tbNewLeadName.Text != string.Empty && newLeadStage != string.Empty &&
            newLeadEmployees != string.Empty
            && newLeadCustomers != string.Empty)
            {
                string[] words = lBNewLeadCustomers.SelectedItem.ToString().Split(' ');
                
                if (words.Length > 2)
                {
                    for(int i = 1; i < words.Length - 1; i++)
                    {
                        words[0] += " " + words[i];
                    }
                    words[1] = words[words.Length - 1];
                }

                //MessageBox.Show(words[0]);
                
                words[1] = words[1].Replace("(", string.Empty).Replace(")", string.Empty);

                //MessageBox.Show(words[1]);

                foreach (Tuple<string, string, string> k in customers) if (k.Item1 == words[0] && k.Item2 == words[1])
                {
                    idCustomer = k.Item3;
                    break;
                }

                idUser = departments_employees[new Tuple<string, string>(cbNewLeadAssignedTo.SelectedItem.ToString(), lBNewLeadEmployees.SelectedItem.ToString())];

                string Name = tbNewLeadName.Text;
                string Date = dtpNewLeadDate.Text;
                string Stage = cbNewLeadStage.SelectedItem.ToString();
                int Amount;
                if(tbNewLeadAmount.Text == string.Empty)
                {
                    Amount = 0;
                }
                else
                {
                    Amount = int.Parse(tbNewLeadAmount.Text);
                }
                
                string Notes = tbNewLeadNotes.Text;
                string AssignedTo = lBNewLeadEmployees.SelectedItem.ToString();
                string CreatedAt = dtpNewLeadCreatedAt.Text;

                if (cnLead.addLead(new ceLead(Name, Date, Stage,
                    Amount, Notes, AssignedTo, CreatedAt, 
                    int.Parse(idCustomer), int.Parse(idUser))))
                {
                    MessageBox.Show("Lead creado con éxito.");
                    cdGlobals.newLogEntry(email, "Lead creado");
                }
                else
                {
                    MessageBox.Show("Lead NO creado con éxito.");
                }
            }
            else
            {
                MessageBox.Show("Faltan por rellenar campos obligatorios");
            }
        }

        private void btnNewLeadCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void tbNewLeadAmount_Leave(object sender, EventArgs e)
        {
            int numericValue;
            bool isNumber = int.TryParse(tbNewLeadAmount.Text, out numericValue);

            if (isNumber == false && tbNewLeadAmount.Text != "")
            {
                tbNewLeadAmount.Text = "";
                MessageBox.Show("Introduzca un valor numérico.");
            }            
        }
    }
}
