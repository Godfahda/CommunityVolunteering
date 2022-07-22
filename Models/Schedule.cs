namespace CommunityCare.Models
{
    public class Schedule
    {
        public int Id { get; set; }
        public DateTime ScheduleTime { get; set; }
        public String HomeLocation { get; set; }
        public String HomeName { get; set; }
        public String VolunteerName { get; set; }
        public String ScheduleNote { get; set; }
        public String ResidentName { get; set; }

        public Schedule()
        {

        }
    }
}
