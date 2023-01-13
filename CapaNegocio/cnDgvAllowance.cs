using capaDatos;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace capaNegocio
{
    public class cnDgvAllowance
    {
        cdDgvAllowance cdDgvAllowance = new cdDgvAllowance();
        public void dgvAllowance(DataGridView dgvAllowance, Hashtable pdfs)
        {
            cdDgvAllowance.GetData();
            cdDgvAllowance.updateDatagrid(dgvAllowance, pdfs);
        }
    }
}
