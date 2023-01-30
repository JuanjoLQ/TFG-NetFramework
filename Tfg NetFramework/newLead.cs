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
                lBNewLeadEmployees.Items.ToString() != string.Empty && lBNewLeadCustomers.Items.ToString() != string.Empty)
            {

                //

                string[] words = lBNewLeadCustomers.SelectedItem.ToString().Split(' ');
                //item.Item1 + " (" + item.Item2 + ")");
                words[1] = words[1].Replace("(", string.Empty).Replace(")", string.Empty);
                

                MessageBox.Show(words[0]);
                MessageBox.Show(words[1]);

                foreach (Tuple<string, string, string> k in customers) if (k.Item1 == words[0] && k.Item2 == words[1])
                {
                    idCustomer = k.Item3;
                    break;
                }

                //

                idUser = departments_employees[new Tuple<string, string>(cbNewLeadAssignedTo.SelectedItem.ToString(), lBNewLeadEmployees.SelectedItem.ToString())];

                //MessageBox.Show(tbNewLeadName.Text);
                //MessageBox.Show(dtpNewLeadDate.Text);
                //MessageBox.Show(cbNewLeadStage.SelectedItem.ToString());
                //MessageBox.Show(int.Parse(tbNewLeadAmount.Text).ToString());
                //MessageBox.Show(tbNewLeadNotes.Text);
                //MessageBox.Show(cbNewLeadAssignedTo.SelectedItem.ToString());
                //MessageBox.Show(dtpNewLeadCreatedAt.Text);


                if (cnLead.addLead(new ceLead(tbNewLeadName.Text, dtpNewLeadDate.Text, cbNewLeadStage.SelectedItem.ToString(),
                    int.Parse(tbNewLeadAmount.Text), tbNewLeadNotes.Text, lBNewLeadEmployees.SelectedItem.ToString(),
                    dtpNewLeadCreatedAt.Text, int.Parse(idCustomer), int.Parse(idUser))))
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
