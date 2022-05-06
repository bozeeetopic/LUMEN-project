using System.Collections.Generic;

namespace Data.Entities.Models
{
    public class College
    {
        public int Id { get; set; }
        public string CollegeName { get; set; }

        public ICollection<Subject> Subjects { get; set; }
        public ICollection<Student> Students { get; set; }
    }
}
