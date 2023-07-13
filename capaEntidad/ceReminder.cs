namespace capaEntidad
{
    public class ceReminder
    {
        public ceReminder(string title, string reminder, string date, string hour)
        {
            this.title = title;
            this.reminder = reminder;
            this.date = date;
            this.hour = hour;
        }
        public ceReminder(int idReminder, string title, string reminder, string date, string hour)
        {
            this.idReminder = idReminder;
            this.title = title;
            this.reminder = reminder;
            this.date = date;
            this.hour = hour;
        }
        public int idReminder { get; set; }
        public string title { get; set; }
        public string reminder { get; set; }
        public string date { get; set; }
        public string hour { get; set; }

    }
}
