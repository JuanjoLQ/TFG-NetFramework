using capaDatos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio
{
    public  class cnDoBackup
    {
        cdDoBackup cdBackup = new cdDoBackup();

        public void doBackUp(string email)
        {
            cdBackup.doBackUp(email);
        }


    }
}
