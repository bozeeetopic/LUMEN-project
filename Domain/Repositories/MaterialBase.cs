using Data.Entities;
using System.Linq;
using Domain.Enums;
using Data.Entities.Models;
using System.Collections.Generic;

namespace Domain.Repositories
{
    public class MaterialBase : RepositoryBase
    {
        public MaterialBase(UniSyncDbContext dbContext) : base(dbContext)
        {
        }

        public ResponseResultType Add(Byte[] file, string fileName)
        {
            Material material = new() { File = file, FileName = fileName};
            DbContext.Materials.Add(material);

            return SaveChanges();
        }
        public ResponseResultType Delete(int id)
        {
            var deletingMaterial = DbContext.Materials.Find(id);
            if (deletingMaterial is null)
            {
                return ResponseResultType.NotFound;
            }

            DbContext.Materials.Remove(deletingMaterial);

            return SaveChanges();
        }

        public ICollection<Material> GetAll() => DbContext.Materials.ToList();
    }
}
