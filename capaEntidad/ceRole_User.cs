using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace capaEntidad
{
    public class ceRole_User
    {
        public ceRole_User(int User_idUser, int Role_idRole)
        {
            this.User_idUser = User_idUser;
            this.Role_idRole = Role_idRole;
        }

        public int User_idUser { get; set; }
        public int Role_idRole { get; set; }
    }
}
