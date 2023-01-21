using capaDatos;
using capaEntidad;
using CapaNegocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tfg_NetFramework
{
    public partial class newCustomer : Form
    {
        cnCustomer cnCustomer = new cnCustomer();
        public newCustomer()
        {
            InitializeComponent();
        }

        private void btnNewCustomerSave_Click(object sender, EventArgs e)
        {
            if (tbNewCustomerName.Text != string.Empty && cbNewCustomerType.SelectedItem.ToString() != string.Empty)
            {
                if (cnCustomer.addCustomer(new ceCustomer(tbNewCustomerName.Text, tbNewCustomerPhone.Text, tbNewCustomerEmail.Text,
                    tbNewCustomerDepartment.Text, tbNewCustomerCity.Text, tbNewCustomerState.Text, tbNewCustomerZip.Text,
                    tbNewCustomerCountry.Text, tbNewCustomerAdress1.Text, tbNewCustomerAdress2.Text, cbNewCustomerType.SelectedItem.ToString(),
                    tbNewCustomerNotes.Text, tbNewCustomerNotes.Text)))
                {
                    MessageBox.Show("Customer creado con éxito.");
                }
                else
                    {
                        MessageBox.Show("Customer NO creado con éxito.");
                    }
                    
            }
        }

        private void btnNewCustomerCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
