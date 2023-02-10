using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace capaEntidad
{
    public class ceDepartment
    {
        public ceDepartment(int idDepartment, string name, int company_idCompany)
        {
            this.idDepartment = idDepartment;
            this.name = name;
            this.Company_idCompany = company_idCompany;
        }

        public int idDepartment { get; set; }
        public string name { get; set; }
        public int Company_idCompany { get; set; }

    }
}
