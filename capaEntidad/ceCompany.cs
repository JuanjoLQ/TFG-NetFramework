using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace capaEntidad
{
    public class ceCompany
    {
        public ceCompany(int idCompany, string name)
        {
            this.idCompany = idCompany;
            this.name = name;
        }

        public int idCompany { get; set; }
        public string name { get; set; }
    }
}
