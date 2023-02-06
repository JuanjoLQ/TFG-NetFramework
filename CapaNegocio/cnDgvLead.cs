using capaDatos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaNegocio
{
    public class cnDgvLead
    {
        cdDgvLead cdDgvLead = new cdDgvLead();

        public void updateDgvLead(int idCustomer, DataGridView dgvCustomer_Lead)
        {
            cdDgvLead.GetData(idCustomer);
            cdDgvLead.updateDatagrid(dgvCustomer_Lead);
        }

    }
}
