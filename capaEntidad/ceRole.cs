using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace capaEntidad
{
    public class ceRole
    {
        public ceRole(int idRole, string nameRole, string privileges)
        {
            this.idRole = idRole;
            this.nameRole = nameRole;
            this.privileges = privileges;
        }

        public int idRole { get; set; }
        public string nameRole { get; set; }
        public string privileges { get; set; }
    }
}
