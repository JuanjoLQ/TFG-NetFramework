﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace capaEntidad
{
    public class ceLead
    {
        public ceLead(string Name, string Date, string Stage, int Amount,
            string Notes, string AssignedTo, string CreatedAt)
        {
            this.Name = Name;
            this.Date = Date;
            this.Stage = Stage;
            this.Amount = Amount;
            this.Notes = Notes;
            this.AssignedTo = AssignedTo;
            this.CreatedAt = CreatedAt;
        }

        public string Name { get; set; }
        public string Date { get; set; }
        public string Stage { get; set; }
        public int Amount { get; set; }
        public string Notes { get; set; }
        public string AssignedTo { get; set; }
        public string CreatedAt { get; set; }

    }
}
