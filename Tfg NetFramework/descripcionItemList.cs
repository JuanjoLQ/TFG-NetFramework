using capaEntidad;
using CapaNegocio;
using System;
using System.Drawing;
using System.Windows.Forms;

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
