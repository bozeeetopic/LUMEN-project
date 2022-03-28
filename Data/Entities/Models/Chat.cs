using System.Collections.Generic;

namespace Data.Entities.Models
{
    public class Chat
    {
        public int Id { get; set; }
        public string ChatName { get; set; }

        public ICollection<Message> Messages { get; set; }
        public ICollection<Student> Students { get; set; }
    }
}
