using Data.Entities.Enums;
using System;

namespace Data.Entities.Models
{
    public class ScheduleItem
    {
        public int Id { get; set; }
        public string EventName { get; set; }
  
        public DateTime StartTime { get; set; }
        public int Duration { get; set; }

        public DurationType? RepetitionType { get; set; }
        public int RepetitionCounter { get; set; }

        public int StudentId { get; set; }
        public Student Student { get; set; }
    }
}
