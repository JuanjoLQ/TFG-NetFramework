using capaDatos;
using capaEntidad;
using System;
using System.Collections;
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

        public ArrayList getCustomers (ArrayList array)
        {
            return cdCustomer.getCustomers(array);
        }

        public ceCustomer getCustomer(int id)
        {
            return cdCustomer.GetCustomer(id);
        }

    }
}
