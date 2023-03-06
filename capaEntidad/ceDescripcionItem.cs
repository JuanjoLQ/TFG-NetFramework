using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace capaEntidad
{
    public class ceDescripcionItem
    {

        public ceDescripcionItem(ceUser user, ceLead lead, ceCustomer customer)
        {
            this.User = user;
            this.Lead = lead;
            this.Customer = customer;
        }

        public ceUser User { get; set; }
        public ceLead Lead { get; set; }
        public ceCustomer Customer { get; set; }

    }
}
