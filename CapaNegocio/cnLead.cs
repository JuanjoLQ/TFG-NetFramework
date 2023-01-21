using capaDatos;
using capaEntidad;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio
{
    public class cnLead
    {
        cdLead cdLead = new cdLead();
        public bool addLead(ceLead lead)
        {
            return cdLead.addLead(lead);
        }

    }
}
