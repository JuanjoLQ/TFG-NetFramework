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
    public partial class descripcionItemList : Form
    {
        private void descripcionItemList_Load(object sender, EventArgs e)
        {
            ItemList item = new ItemList();
        }

        public descripcionItemList(ceDescripcionItem descripcionItem)
        {
            InitializeComponent();

            lbLeadName.Text = descripcionItem.Lead.Name;
            lbUserAssignedTo.Text = descripcionItem.Lead.AssignedTo;
            lbAmountLead.Text = descripcionItem.Lead.Amount.ToString();
            lbNameCustomer.Text = descripcionItem.Customer.Name;
            lbEmailCustomer.Text = descripcionItem.Customer.Email;
            lbLeadDate.Text = descripcionItem.Lead.Date;
            tbLeadNotes.Text = descripcionItem.Lead.Notes;
            lbLeadCreatedAt.Text = descripcionItem.Lead.CreatedAt;

            tbCustomerCompanyName.Text = descripcionItem.Customer.Name;
            tbCustomerPhone.Text = descripcionItem.Customer.Phone;
            tbCustomerAddress1.Text = descripcionItem.Customer.Adress1;
            tbCustomerAddress2.Text = descripcionItem.Customer.Adress2;
            tbCustomerCity.Text = descripcionItem.Customer.City;
            tbCustomerCountry.Text = descripcionItem.Customer.Country;
            tbCustomerZip.Text = descripcionItem.Customer.Zip;
            tbCustomerDepartment.Text = descripcionItem.Customer.Department;
            tbCustomerType.Text = descripcionItem.Customer.Type;
            tbCustomerDate.Text = descripcionItem.Customer.Date;

        }

        private void btnNew_Click(object sender, EventArgs e)
        {

        }

        private void btnQualified_Click(object sender, EventArgs e)
        {

        }

        private void btnProposition_Click(object sender, EventArgs e)
        {

        }

        private void btnWon_Click(object sender, EventArgs e)
        {

        }

    }
}
