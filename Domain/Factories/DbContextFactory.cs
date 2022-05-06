using Microsoft.EntityFrameworkCore;
using Data.Entities;
using System.Configuration;

namespace Domain.Factories
{
    public static class DbContextFactory
    {
        public static UniSyncDbContext GetUniSyncDbContext()
        {
            var options = new DbContextOptionsBuilder()
                .UseSqlServer(ConfigurationManager.ConnectionStrings["UniSync"].ConnectionString)
                .Options;

            return new UniSyncDbContext(options);
        }
    }
}