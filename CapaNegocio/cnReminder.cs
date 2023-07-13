using Bunifu.UI.WinForms;
using capaDatos;
using capaEntidad;
using System.Windows.Forms;

namespace CapaNegocio
{

    public class cnReminder
    {
        cdReminder cdReminder = new cdReminder();

        public void addReminder(int idUser, ceReminder reminder)
        {
            cdReminder.addReminder(idUser, reminder);
        }

        public void removeReminder(int idUser, int idReminder)
        {
            cdReminder.removeReminder(idUser, idReminder);
        }

        public void updateReminder(ceReminder reminder)
        {
            cdReminder.updateReminder(reminder);
        }

        public void checkReminder(int idUser, NotifyIcon notifyIcon)
        {
            cdReminder.checkReminder(idUser, notifyIcon);
        }

        public void updateDgvReminders(BunifuDataGridView dgvReminder, int idUser)
        {
            cdReminder.updateDgvReminders(dgvReminder, idUser);
        }

    }
}
