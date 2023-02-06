using System;
using capaDatos;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaNegocio
{
    public class cnDgvCustomer
    {
        cdDgvCustomer cdDgvCustomer = new cdDgvCustomer();

        public void updateDgvCustomer(DataGridView dgvCustomer)
        {
            cdDgvCustomer.getData();
            cdDgvCustomer.updateDatagrid(dgvCustomer);
        }

    }
}
