using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace capaEntidad
{
    public class ceDepartment_User
    {

        public ceDepartment_User(int Department_idDepartment, int User_idUser)
        {
            this.Department_idDepartment = Department_idDepartment;
            this.User_idUser = User_idUser;
        }

        public int Department_idDepartment { get; set; }
        public int User_idUser { get; set; }
    }
}
