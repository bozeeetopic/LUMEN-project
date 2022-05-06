using Data.Entities;
using Data.Entities.Models;
using Domain.Enums;
using System.Collections.Generic;
using System.Linq;

namespace Domain.Repositories
{
    public class SubjectBase : RepositoryBase
    {
        public SubjectBase(UnySyncDbContext dbContext) : base(dbContext)
        {
        }

        public ICollection<Subject> GetAll() => DbContext.Subjects.ToList();
    }
}
