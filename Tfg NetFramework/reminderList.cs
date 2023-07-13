using System;
using CapaNegocio;
using System.Windows.Forms;
using capaEntidad;
using capaDatos;
using capaNegocio;

namespace Tfg_NetFramework
{
    public partial class reminderList : Form
    {
        cnReminder cnReminder = new cnReminder();
        string emailUser = string.Empty;
        int idUser;
        cdGlobals cdGlobals = new cdGlobals();

        public reminderList(string email)
        {
            InitializeComponent();
            this.emailUser = email;
            this.idUser = cdGlobals.getId(email);
        }

        private void reminderList_Load(object sender, EventArgs e)
        {

        }

        private void btnReminderRemove_Click(object sender, EventArgs e)
        {
            string idReminder = dgvReminder.CurrentRow.Cells[0].Value.ToString();
            if(idReminder != string.Empty)
            {
                cnReminder.removeReminder(idUser, int.Parse(idReminder));
                btnDgvReminderUpdate_Click(sender, e);
            }
        }

        private void btnReminderAdd_Click(object sender, EventArgs e)
        {
            newReminder newReminder = new newReminder();

            newReminder.Show();


            string title = tbReminderTitle.Text;
            string date = tbReminderDate.Text;

            if(title != string.Empty && date != string.Empty)
            {
                ceReminder reminder = new ceReminder(title, tbReminderReminder.Text, date, tbReminderHour.Text);
                cnReminder.addReminder(idUser, reminder);
                btnDgvReminderUpdate_Click(sender, e);
            }
            //else
            //{
            //    MessageBox.Show("Faltan por rellenar campos obligatorios");
            //}
            
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgvReminder_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            tbReminderTitle.Text = dgvReminder.CurrentRow.Cells[1].Value.ToString();
            tbReminderReminder.Text = dgvReminder.CurrentRow.Cells[2].Value.ToString();
            tbReminderDate.Text = dgvReminder.CurrentRow.Cells[3].Value.ToString();
            tbReminderHour.Text = dgvReminder.CurrentRow.Cells[4].Value.ToString();            
        }

        private void btnUpdateDgvReminder_Click(object sender, EventArgs e)
        {

            string idReminder = dgvReminder.CurrentRow.Cells[0].Value.ToString();
            string title = tbReminderTitle.Text;
            string date = tbReminderDate.Text;
            string hour = tbReminderHour.Text;
            string reminderReminder = tbReminderReminder.Text;

            if (idReminder != string.Empty)
            {
                ceReminder reminder = new ceReminder(int.Parse(idReminder), title, reminderReminder, date, hour);
                cnReminder.updateReminder(reminder);
            }

        }

        private void btnDgvReminderUpdate_Click(object sender, EventArgs e)
        {
            dgvReminder.Update();
            dgvReminder.Refresh();
            cnReminder.updateDgvReminders(dgvReminder, idUser);

        }
    }
}
