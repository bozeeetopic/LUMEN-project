using System;
using System.Collections.Generic;

namespace Data.Entities.Models
{
    public class Material
    {
        public int Id { get; set; }
        public Byte[] File { get; set; }
        public string FileName { get; set; }

        public ICollection<Tag> Tags { get; set; }
    }
}
