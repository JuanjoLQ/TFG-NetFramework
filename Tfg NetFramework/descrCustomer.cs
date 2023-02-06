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

namespace Tfg_NetFramework
{
    public partial class descrCustomer : Form
    {
        ceCustomer customer = null;
        public descrCustomer(ceCustomer customer)
        {
            InitializeComponent();
            this.customer = customer;
        }

        private void descrCustomer_Load(object sender, EventArgs e)
        {
            tbCustomerName.Text = customer.Name;
            tbCustomerDepartment.Text = customer.Department;
            tbCustomerType.Text = customer.Type;
            tbCustomerDate.Text = customer.Date;
            tbCustomerState.Text = customer.State;

            tbCustomerEmail.Text = customer.Email;
            tbCustomerPhone.Text = customer.Phone;
            tbCustomerAddress1.Text = customer.Adress1;
            tbCustomerAddress2.Text = customer.Adress2;
            tbCustomerCity.Text = customer.City;
            tbCustomerCountry.Text = customer.Country;
            tbCustomerZip.Text = customer.Zip;

            tbCustomerNotes.Text = customer.Notes;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
