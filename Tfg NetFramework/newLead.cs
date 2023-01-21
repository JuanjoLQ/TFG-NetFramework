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

namespace Tfg_NetFramework
{
    public partial class newLead : Form
    {
        cnLead cnLead = new cnLead();
        public newLead()
        {
            InitializeComponent();
        }

        private void btnNewLeadSave_Click(object sender, EventArgs e)
        {
            if (tbNewLeadName.Text != string.Empty && cbNewLeadStage.SelectedItem.ToString() != string.Empty)
            {
                if (cnLead.addLead(new ceLead(tbNewLeadName.Text, dtpNewLeadDate.Text, cbNewLeadStage.SelectedItem.ToString(),
                    int.Parse(tbNewLeadAmount.ToString()), tbNewLeadNotes.Text, cbNewLeadAssignedTo.SelectedItem.ToString(),
                    dtpNewLeadCreatedAt.Text)))
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
