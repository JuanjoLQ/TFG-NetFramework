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
            //Labels
            lbCustomerInformation.Text = "<h3>" + Res.CustomerInfo + "</h3>";
            lbCustomerName.Text = "<h4>" + Res.nameCustomer + ":" + "</h4>";
            lbCustomerDepartment.Text = "<h4>" + Res.department + ":" + "</h4>";
            lbCustomerType.Text = "<h4>" + Res.Type + ":" + "</h4>";
            lbCustomerDate.Text = "<h4>" + Res.date + ":" + "</h4>";
            lbCustomerState.Text = "<h4>" + Res.state + ":" + "</h4>";

            lbContactInfo.Text = "<h3>" + Res.ContactInfo + "</h3>";
            lbCustomerEmail.Text = "<h4>" + Res.Email + ":" + "</h4>";
            lbCustomerPhone.Text = "<h4>" + Res.Phone + ":" + "</h4>";
            lbCustomerAddress1.Text = "<h4>" + Res.MainAddress + ":" + "</h4>";
            lbCustomerAddress2.Text = "<h4>" + Res.SecondaryAddress + ":" + "</h4>";
            lbCustomerCity.Text = "<h4>" + Res.City + ":" + "</h4>";
            lbCustomerCountry.Text = "<h4>" + Res.Country + ":" + "</h4>";
            lbCustomerZip.Text = "<h4>" + Res.Zip + ":" + "</h4>";

            lbCustomerNotes.Text = "<h3>" + Res.Notes + "</h3>";

            //Textboxs
            tbCustomerName.PlaceholderText = customer.Name;
            tbCustomerDepartment.PlaceholderText = customer.Department;
            tbCustomerType.PlaceholderText = customer.Type;
            tbCustomerDate.PlaceholderText = customer.Date;
            tbCustomerState.PlaceholderText = customer.State;

            tbCustomerEmail.PlaceholderText = customer.Email;
            tbCustomerPhone.PlaceholderText = customer.Phone;
            tbCustomerAddress1.PlaceholderText = customer.Adress1;
            tbCustomerAddress2.PlaceholderText = customer.Adress2;
            tbCustomerCity.PlaceholderText = customer.City;
            tbCustomerCountry.PlaceholderText = customer.Country;
            tbCustomerZip.PlaceholderText = customer.Zip;

            tbCustomerNotes.PlaceholderText = customer.Notes;

            //Buttons
            btnClose.Text = Res.Exit ;

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
