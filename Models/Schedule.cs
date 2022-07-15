namespace CommunityCare.Models
{
    public class Schedule
    {
        public int Id { get; set; }
        public DateTime ScheduleTime { get; set; }
        public String HomeLocation { get; set; }

        public Schedule()
        {

        }
    }
}
