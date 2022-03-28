using System.Collections.Generic;

namespace Data.Entities.Models
{
    public class Subject
    {
        public int Id { get; set; }
        public string SubjectName { get; set; }

        public int CollegeId { get; set; }
        public College College { get; set; }


        public ICollection<Student> Students { get; set; }
    }
}
