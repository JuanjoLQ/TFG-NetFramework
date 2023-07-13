using capaDatos;
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
