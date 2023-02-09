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
