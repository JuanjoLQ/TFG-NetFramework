using capaDatos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio
{
    public class cnRestoreBackUp
    {
        cdRestoreBackUp cdRestoreBackUp = new cdRestoreBackUp();

        public void restoreBackUp(string path, string email)
        {
            cdRestoreBackUp.restoreBackUp(path, email);
        }

    }
}
