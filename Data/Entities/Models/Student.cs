using System.Collections.Generic;

namespace Data.Entities.Models
{
    public class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }

        public ICollection<Subject> Subjects { get; set; }
        public ICollection<ScheduleItem> ScheduleItems { get; set; }
        public ICollection<Chat> Chats { get; set; }
        public ICollection<Message> Messages { get; set; }
    }
}
