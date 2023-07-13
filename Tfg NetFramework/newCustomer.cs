using capaDatos;
using capaEntidad;
using CapaNegocio;
using System;
using System.Windows.Forms;

namespace Tfg_NetFramework
{
    public partial class newCustomer : Form
    {
        cnCustomer cnCustomer = new cnCustomer();
        cdGlobals cdGlobals = new cdGlobals();
        string email;

        public newCustomer(string email)
        {
            InitializeComponent();
            this.email = email;
        }

        private void newCustomer_Load(object sender, EventArgs e)
        {
            //Labels
            blbNewCustomerTitle.Text = "<h2>" + Res.NewCustomer + "</h2>";
            lbName.Text = "<h4>" + Res.Name + "*:" + "</h4>";
            lbPhone.Text = "<h4>" + Res.Phone + ":" + "</h4>";
            lbEmailNewCustomer.Text = "<h4>" + Res.Email + ":" + "</h4>";
            lbDepartmentNewCustomer.Text = "<h4>" + Res.department + ":" + "</h4>";
            lbCity.Text = "<h4>" + Res.City + ":" + "</h4>";
            lbState.Text = "<h4>" + Res.state + ":" + "</h4>";
            lbZip.Text = "<h4>" + Res.Zip + ":" + "</h4>";
            lbCountry.Text = "<h4>" + Res.Country + ":" + "</h4>";
            lbAddress1.Text = "<h4>" + Res.MainAddress + ":" + "</h4>";
            lbAddress2.Text = "<h4>" + Res.SecondaryAddress + ":" + "</h4>";
            lbType.Text = "<h4>" + Res.Type + "*:" + "</h4>";
            lbNotes.Text = "<h4>" + Res.Notes + ":" + "</h4>";
            lbDate.Text = "<h4>" + Res.date + ":" + "</h4>";

            //Textboxs
            tbNewCustomerName.PlaceholderText = Res.nameCustomer;
            tbNewCustomerPhone.PlaceholderText = Res.Phone;
            tbNewCustomerEmail.PlaceholderText = Res.CustomerEmail;
            tbNewCustomerDepartment.PlaceholderText = Res.department;
            tbNewCustomerCity.PlaceholderText = Res.City;
            tbNewCustomerState.PlaceholderText = Res.state;
            tbNewCustomerZip.PlaceholderText = Res.Zip;
            tbNewCustomerCountry.PlaceholderText = Res.Country;
            tbNewCustomerAdress1.PlaceholderText = Res.MainAddress;
            tbNewCustomerAdress2.PlaceholderText = Res.SecondaryAddress;
            tbNewCustomerNotes.PlaceholderText = Res.Notes;

            //Buttons
            btnNewCustomerCancel.Text = Res.Exit ;
            btnNewCustomerSave.Text = Res.Save ;

        }

        private void btnNewCustomerSave_Click(object sender, EventArgs e)
        {
            try
            {
                var aux1 = tbNewCustomerName.Text;
                var aux2 = cbNewCustomerType.SelectedItem;

                if(aux1 == string.Empty || aux2 == null)
                {
                    MessageBox.Show("Falta por rellenar campos obligatorios.");
                }

                if (aux1 != string.Empty && aux2 != null)
                {
                    if (cnCustomer.addCustomer(new ceCustomer(null, tbNewCustomerName.Text, tbNewCustomerPhone.Text, tbNewCustomerEmail.Text,
                        tbNewCustomerDepartment.Text, tbNewCustomerCity.Text, tbNewCustomerState.Text, tbNewCustomerZip.Text,
                        tbNewCustomerCountry.Text, tbNewCustomerAdress1.Text, tbNewCustomerAdress2.Text, cbNewCustomerType.SelectedItem.ToString(),
                        tbNewCustomerNotes.Text, dtpNewCustomer.Text)))
                    {
                        MessageBox.Show("Customer creado con éxito.");
                        cdGlobals.newLogEntry(this.email, "Customer creado");
                    }
                    else
                    {
                        MessageBox.Show("Customer NO creado con éxito.");
                    }

                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

        }

        private void btnNewCustomerCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
