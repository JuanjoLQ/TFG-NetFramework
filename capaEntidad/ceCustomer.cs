using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace capaEntidad
{
    public class ceCustomer
    {
        public ceCustomer(string idCustomer, string Name, string Phone, string Email, string Department, 
            string City, string State, string Zip, string Country, string Adress1, 
            string Adress2, string Type, string Notes, string Date)
        {
            this.idCustomer = idCustomer;
            this.Name = Name;
            this.Phone = Phone;
            this.Email = Email;
            this.Department = Department;
            this.City = City;
            this.State = State;
            this.Zip = Zip;
            this.Country = Country;
            this.Adress1 = Adress1;
            this.Adress2 = Adress2;
            this.Type = Type;
            this.Notes = Notes;
            this.Date = Date;
        }
        public string idCustomer { get; set; }
        public string Name { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public string Department { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Zip { get; set; }
        public string Country { get; set; }
        public string Adress1 { get; set; }
        public string Adress2 { get; set; }
        public string Type { get; set; }
        public string Notes { get; set; }
        public string Date { get; set; }

    }
}
