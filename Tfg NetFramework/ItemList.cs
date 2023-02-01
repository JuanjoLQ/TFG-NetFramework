using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace Tfg_NetFramework
{
    public partial class ItemList : UserControl
    {
        public ItemList()
        {
            InitializeComponent();
        }

        public ItemList(int id, string name, string date, string stage, float amount, string notes, 
            string assignedTo, string createdAt, int idCustomer, string nameCustomer, int idUser)
        {
            this.id = id;
            this.name = name;
            this.date = date;
            this.stage = stage;
            this.amount = amount;
            this.notes = notes;
            this.assignedTo = assignedTo;
            this.createdAt = createdAt;
            this.idCustomer = idCustomer;
            this.nameCustomer = nameCustomer;
            this.idUser = idUser;
        }

        private int id;
        private string name;
        
        private string date;

        private string stage;
        private float amount;
        private string notes;
        private string assignedTo;

        private string createdAt;

        private int idCustomer;
        private string nameCustomer;

        private int idUser;

        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        public string Name
        {
            get { return date; }
            set { name = value; lbName.Text = value; }
        }

        public string Date
        {
            get { return date; }
            set { date = value; lbDate.Text = value; }
        }

        public string Stage
        {
            get { return stage; }
            set { stage = value; lbStage.Text = value; }
        }

        public float Amount
        {
            get { return amount; }
            set { amount = value; lbAmount.Text = value.ToString(); }
        }

        public string Notes
        {
            get { return notes; }
            set { notes = value; lbNotes.Text = value.ToString(); }
        }

        public string AssignedTo
        {
            get { return assignedTo; }
            set { assignedTo = value; lbAssignedTo.Text = value.ToString(); }
        }

        public string CreatedAt
        {
            get { return createdAt; }
            set { createdAt = value; lbCreatedAt.Text = value; }
        }

        public int IdCustomer
        {
            get { return idCustomer; }
            set { idCustomer = value; }
        }

        public string NameCustomer
        {
            get { return nameCustomer; }
            set { nameCustomer = value; lbNameCustomer.Text = value; }
        }

        public int IdUser
        {
            get { return idUser; }
            set { idUser = value; }
        }

        private void ItemList_MouseDown(object sender, MouseEventArgs e)
        {
            var control = sender as Control;
            control.Name = id.ToString();
            this.DoDragDrop(control.Name, DragDropEffects.Move);
        }
    }
}
