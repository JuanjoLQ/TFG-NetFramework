using capaDatos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace capaNegocio
{
    public class cnDgvMileage
    {
        cdDgvMileage cdDgvMileage = new cdDgvMileage();
        public void dgvMileage(DataGridView dgvMileage)
        {
            cdDgvMileage.GetData();
            cdDgvMileage.updateDatagrid(dgvMileage);
        }
    }
}
