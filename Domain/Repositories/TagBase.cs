using Data.Entities;
using Data.Entities.Models;
using Domain.Enums;
using System.Collections.Generic;
using System.Linq;

namespace Domain.Repositories
{
    public class MemberBase : RepositoryBase
    {
        public MemberBase(UniSyncDbContext dbContext) : base(dbContext)
        {
        }

        public ResponseResultType Add(string tagName)
        {
	    Tag tag = new() { TagName = tagName};
            DbContext.Tags.Add(member);

            return SaveChanges();
        }

        public ICollection<Tag> GetAll() => DbContext.Tags.ToList();
    }
}
