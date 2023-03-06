namespace capaEntidad
{
    public class ceUser
    {
        public ceUser()
        {

        }

        public ceUser(int isAdmin, string email, string password)
        {
            this.Email = email;
            this.Password = password;
            this.isAdmin = isAdmin;
        }

        public ceUser(int idUser, int isAdmin, string email, string password)
        {
            this.idUser = idUser;
            this.Email = email;
            this.Password = password;
            this.isAdmin = isAdmin;
        }

        public ceUser(string idUser, string email, string password)
        {
            this.idUser = int.Parse(idUser);
            this.Email = email;
            this.Password = password;
        }

        public ceUser(int idUser, string email, string password, string department, string job)
        {
            this.idUser = idUser;
            this.Email = email;
            this.Password = password;
            this.Department = department;
            this.Job = job;
        }

        public int idUser { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string Department { get; set; }
        public string Job { get; set; }

        public int isAdmin { get; set; }

        public override string ToString()
        {
            return "Email: " + this.Email + ", Password: " + this.Password;
        }
    }
}

//
//
//
/*
parsear tipos de datos a este objeto
user.Id = (int) txtId.Value;

user.Nombre = tbNombre.Text;;

user.Foto = picFoto.ImageLocation;



*/