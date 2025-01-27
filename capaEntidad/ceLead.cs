﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace capaEntidad
{
    public class ceLead
    {

        public ceLead(int idLead, string name, string date, string stage, int amount, string notes, string AssignedTo, string CreatedAt) 
        { 
        this.Idlead = idLead;
        this.Name = name;
        this.Date = date;
        this.Stage = stage;
        this.Amount = amount;
        this.Notes= notes;
        this.AssignedTo = AssignedTo;
        this.CreatedAt = CreatedAt;
        }
        public ceLead(int idLead, string name, string date, string stage, int amount, string AssignedTo, string CreatedAt)
        {
            this.Idlead = idLead;
            this.Name = name;
            this.Date = date;
            this.Stage = stage;
            this.Amount = amount;
            this.AssignedTo = AssignedTo;
            this.CreatedAt = CreatedAt;
        }

        public ceLead(string Name, string Date, string Stage, int Amount,
            string Notes, string AssignedTo, string CreatedAt, int IdCustomer, int idUser)
        {
            this.Name = Name;
            this.Date = Date;
            this.Stage = Stage;
            this.Amount = Amount;
            this.Notes = Notes;
            this.AssignedTo = AssignedTo;
            this.CreatedAt = CreatedAt;
            this.idCustomer = IdCustomer;
            this.idUser = idUser;
        }

        public ceLead(int idLead, string Name, string Date, string Stage, int Amount,
            string Notes, string AssignedTo, string CreatedAt, int IdCustomer, int idUser)
        {
            this.Idlead = idLead;
            this.Name = Name;
            this.Date = Date;
            this.Stage = Stage;
            this.Amount = Amount;
            this.Notes = Notes;
            this.AssignedTo = AssignedTo;
            this.CreatedAt = CreatedAt;
            this.idCustomer = IdCustomer;
            this.idUser = idUser;
        }

        public int Idlead { get; set; }
        public string Name { get; set; }
        public string Date { get; set; }
        public string Stage { get; set; }
        public int Amount { get; set; }
        public string Notes { get; set; }
        public string AssignedTo { get; set; }
        public string CreatedAt { get; set; }
        public int idCustomer { get; set; }
        public int idUser { get; set; }

    }
}
