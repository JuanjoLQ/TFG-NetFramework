using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace capaEntidad
{
    public class ceAllowance
    {

        public ceAllowance(int idAllowance, int User_idUser, string title, string observations, string state,
            string startTime, string endTime, string startHour, string endHour, string invoice)
        {
            this.idAllowance = idAllowance;
            this.User_idUser = User_idUser;
            this.title = title;
            this.observations = observations;
            this.state = state;
            this.startTime = startTime;
            this.endTime = endTime;
            this.startHour = startHour;
            this.endHour = endHour;
            this.invoice = invoice;
        }

        public ceAllowance(int idAllowance, int User_idUser, string title, string observations, string state, string startHour, string endHour, string startTime)
        {
            this.idAllowance = idAllowance;
            this.User_idUser = User_idUser;
            this.title = title;
            this.observations = observations;
            this.state = state;
            this.startHour = startHour;
            this.endHour = endHour;
            this.startTime = startTime;
        }

        public int idAllowance { get; set; }
        public int User_idUser { get; set; }
        public string title { get; set; }
        public string observations { get; set; }
        public string state { get; set; }
        public string startHour { get; set; }
        public string endHour { get; set; }
        public string startTime { get; set; }
        public string endTime { get; set; }
        public string invoice { get; set; }

    }
}
