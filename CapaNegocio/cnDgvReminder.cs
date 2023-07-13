using Bunifu.UI.WinForms;
using capaDatos;

namespace CapaNegocio
{
    public class cnDgvReminder
    {
        cdDgvReminder cdDgvReminder = new cdDgvReminder();

        public void dgvReminder(BunifuDataGridView dgvReminder)
        {
            cdDgvReminder.GetData();
            cdDgvReminder.updateDatagrid(dgvReminder);
        }

    }
}
