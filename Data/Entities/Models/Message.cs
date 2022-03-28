using System;
using System.Collections.Generic;

namespace Data.Entities.Models
{
    public class Message
    {
        public int Id { get; set; }
        public string MessageText { get; set; }
        public DateTime TimeSent { get; set; }

        public int StudentId { get; set; }
        public Student Student { get; set; }

        public int ChatId { get; set; }
        public Chat Chat { get; set; }
    }
}
