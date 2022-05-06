using System.Collections.Generic;

namespace Data.Entities.Models
{
    public class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }

        public ICollection<Subject> Subjects { get; set; }
    }
}
