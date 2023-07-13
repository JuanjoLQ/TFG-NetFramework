using Bunifu.UI.WinForms;
using capaDatos;
using System.Collections;

namespace capaNegocio
{
    public class cnDgvAllowance
    {
        cdDgvAllowance cdDgvAllowance = new cdDgvAllowance();

        public void dgvAllowance(BunifuDataGridView dgvAllowance, Hashtable pdfs)
        {
            cdDgvAllowance.GetData();
            cdDgvAllowance.updateDatagrid(dgvAllowance, pdfs);
        }
    }
}
