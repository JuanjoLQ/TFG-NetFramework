using capaDatos;
using capaEntidad;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio
{
    public class cnCustomer
    {
        cdCustomer cdCustomer = new cdCustomer();

        public bool addCustomer(ceCustomer customer)
        {
            return cdCustomer.addCustomer(customer);
        }


    }
}
