using capaDatos;
using capaEntidad;
using System;
using System.Collections;
using System.Windows.Forms;
using Bunifu.UI.WinForms;

namespace CapaNegocio
{
    public class cnLead
    {
        cdLead cdLead = new cdLead();
        public bool addLead(ceLead lead)
        {
            return cdLead.addLead(lead);
        }

        public ArrayList getLeads(ArrayList array)
        {
            return cdLead.getLeads(array);
        }

        public void updateStageLead(int idLead, string newStage)
        {
            cdLead.updateStageLead(idLead, newStage);
        }

        public void deleteLead(int idLead)
        {
            cdLead.deleteLead(idLead);
        }

        public void leadsByDate(Label lbDateLead,DataGridView dgvLead_Date, int idCustomer, DateTime startDate, DateTime endDate)
        {
            cdLead.leadsByDate(lbDateLead, dgvLead_Date, idCustomer, startDate, endDate);
        }

        public ceDescripcionItem getLead(int idLead)
        {
            return cdLead.getLead(idLead);
        }

        public void leadToSale(int idLead, int idSale)
        {
            cdLead.leadToSale(idLead, idSale);
        }

    }
}
