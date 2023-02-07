using CapaNegocio;
using capaEntidad;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;
using System.Data.SqlClient;
using capaNegocio;

namespace Tfg_NetFramework
{
    public partial class newLead : Form
    {
        cnLead cnLead = new cnLead();
        cnUser cnUser = new cnUser();
        cnCustomer cnCustomer = new cnCustomer();
        Dictionary<Tuple<string, string>, string> departments_employees = new Dictionary<Tuple<string, string>, string>();
        ArrayList customers = new ArrayList();

        public newLead()
        {
            InitializeComponent();
        }

        private void newLead_Load(object sender, EventArgs e)
        {
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
            
            if (tbNewLeadName.Text != string.Empty && cbNewLeadStage.SelectedItem.ToString() != string.Empty &&
            lBNewLeadEmployees.SelectedItem.ToString() != string.Empty && lBNewLeadEmployees != null && lBNewLeadCustomers.SelectedItem.ToString() != string.Empty && lBNewLeadCustomers != null)
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

                MessageBox.Show(words[0]);
                
                words[1] = words[1].Replace("(", string.Empty).Replace(")", string.Empty);

                MessageBox.Show(words[1]);

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
        
    }
}
