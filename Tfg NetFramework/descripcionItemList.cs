using capaDatos;
using capaEntidad;
using CapaNegocio;
using System;
using System.Drawing;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Tfg_NetFramework
{
    public partial class descripcionItemList : Form
    {
        int idLead;
        int idSale;
        string stageLead;

        cnLead cnLead = new cnLead();
        cnSale cnSale = new cnSale();

        ceDescripcionItem descrItem = null;

        private void descripcionItemList_Load(object sender, EventArgs e)
        {
            
        }

        public descripcionItemList(ceDescripcionItem descripcionItem)
        {
            InitializeComponent();

            stageLead = descripcionItem.Lead.Stage;

            this.descrItem = descripcionItem;

            if(stageLead == "New")
            {
                btnNew.BackColor = Color.FromArgb(107, 107, 114);
            }
            else if(stageLead == "Qualified")
            {

                btnQualified.BackColor = Color.FromArgb(107, 107, 114);
            }
            else if (stageLead == "Proposition")
            {
                btnProposition.BackColor = Color.FromArgb(107, 107, 114);
            }
            else if (stageLead == "Sale")
            {
                btnSale.BackColor = Color.FromArgb(107, 107, 114);
                bbtnDetailsSale.Visible = true;
                idSale = cnSale.getidSaleFromIdLead(descripcionItem.Lead.Idlead);
            }
            else
            {
                btnWon.BackColor = Color.FromArgb(107, 107, 114);
                bbtnLeadToSale.Visible = true;
            }

            idLead = descripcionItem.Lead.Idlead;

            //Labels

            lbLeadName.Text = "<h2>" + descripcionItem.Lead.Name + "</h2>";
            lbAssignedTo.Text = "<h3>" + Res.AssignedTo + ":" + "</h3>";
            lbUserAssignedTo.Text = "<h3>" + descripcionItem.Lead.AssignedTo + "</h3>";
            blbAmount.Text = "<h3>" + Res.Amount + ":" + "</h3>";
            lbAmountLead.Text = "<h4>" + descripcionItem.Lead.Amount.ToString() + "</h4>";

            lbCustomer.Text = "<h2>" + Res.Customer + "</h2>";
            lbCustomerName.Text = "<h4>" + Res.nameCustomer + ":" + "</h4>";
            lbNameCustomer.Text = "<h4>" + descripcionItem.Customer.Name + "</h4>";
            lbCustomerEmail.Text = "<h4>" + Res.CustomerEmail + ":" + "</h4>";
            lbEmailCustomer.Text = "<h4>" + descripcionItem.Customer.Email + "</h4>";
            lbLeadExpDate.Text = "<h4>" + Res.ExpDate + ":" + "</h4>";
            lbLeadDate.Text = "<h4>" + descripcionItem.Lead.Date + "</h4>";

            //tabPageNotes
            lbNotes.Text = "<h2>" + Res.Notes + "</h2>";
            tbLeadNotes.PlaceholderText = descripcionItem.Lead.Notes;

            //tabPageExtraInfo
            lbContactInfo.Text = "<h3>" + Res.ContactInfo + "</h3>";
            lbCompanyName.Text = "<h4>" + Res.NameCompany + ":" + "</h4>";
            lbPhone.Text = "<h4>" + Res.Phone + ":" + "</h4>";
            lbAddress1.Text = "<h4>" + Res.MainAddress + ":" + "</h4>";
            lbSecondaryAddress.Text = "<h4>" + Res.SecondaryAddress + ":" + "</h4>";
            lbCity.Text = "<h4>" + Res.City + ":" + "</h4>";
            lbCountry.Text = "<h4>" + Res.Country + ":" + "</h4>";
            lbZip.Text = "<h4>" + Res.Zip + ":" + "</h4>";

            lbCustomerInformation.Text = "<h3>" + Res.CustomerInfo + "</h3>";
            lbDepartment.Text = "<h4>" + Res.department + ":" + "</h4>";
            lbType.Text = "<h4>" + Res.Type + ":" + "</h4>";
            lbDate.Text = "<h4>" + Res.date + ":" + "</h4>";

            
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

            lbLeadCreatedAt.Text = "<h2>" + descripcionItem.Lead.CreatedAt + "</h2>";

        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            if (stageLead != "New")
            {
                updateStageLead(idLead, "New");
                btnNew.BackColor = Color.FromArgb(107, 107, 114);
                btnQualified.BackColor = Color.FromArgb(246, 246, 246);
                btnProposition.BackColor = Color.FromArgb(246, 246, 246);
                btnWon.BackColor = Color.FromArgb(246, 246, 246);
            }
        }

        private void btnQualified_Click(object sender, EventArgs e)
        {
            if (stageLead != "Qualified")
            {
                updateStageLead(idLead ,"Qualified");
                btnNew.BackColor = Color.FromArgb(246, 246, 246);
                btnQualified.BackColor = Color.FromArgb(107, 107, 114);
                btnProposition.BackColor = Color.FromArgb(246, 246, 246);
                btnWon.BackColor = Color.FromArgb(246, 246, 246);
            }
        }

        private void btnProposition_Click(object sender, EventArgs e)
        {
            if (stageLead != "Proposition")
            {
                updateStageLead(idLead, "Proposition");
                btnNew.BackColor = Color.FromArgb(246, 246, 246);
                btnQualified.BackColor = Color.FromArgb(246, 246, 246);
                btnProposition.BackColor = Color.FromArgb(107, 107, 114);
                btnWon.BackColor = Color.FromArgb(246, 246, 246);
            }
        }

        private void btnWon_Click(object sender, EventArgs e)
        {
            if (stageLead != "Won")
            {
                updateStageLead(idLead, "Won");
                btnNew.BackColor = Color.FromArgb(246, 246, 246);
                btnQualified.BackColor = Color.FromArgb(246, 246, 246);
                btnProposition.BackColor = Color.FromArgb(246, 246, 246);
                btnWon.BackColor = Color.FromArgb(107, 107, 114);
            }
        }

        private void updateStageLead(int idLead, string newStage)
        {
            cnLead.updateStageLead(idLead, newStage);
        }

        private void btnLeadRemove_Click(object sender, EventArgs e)
        {
            cnLead.deleteLead(idLead);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bbtnLeadToSale_Click(object sender, EventArgs e)
        {
            Form doSale = new doSale(descrItem);

            doSale.Show();
        }

        private void bbtnDetailsSale_Click(object sender, EventArgs e)
        {
            Form detailsSale = new detailsSale(descrItem, this.idSale);

            detailsSale.Show();
        }
    }
}
