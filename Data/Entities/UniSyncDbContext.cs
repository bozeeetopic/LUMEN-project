using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using Data.Entities.Models;
using Data.Seeds;
using System.IO;
using System.Linq;

namespace Data.Entities
{
    public class UniSyncDbContext : DbContext
    {
        public UniSyncDbContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<College> College { get; set; }
        public DbSet<Subject> Subject { get; set; }
        public DbSet<Student> Student { get; set; }
        public DbSet<Material> Material { get; set; }
        public DbSet<Tag> Tag { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            /*modelBuilder.Entity<Comment>().ToTable("Comments");
            modelBuilder.Entity<Resource>().ToTable("Resources");*/

            DBSeed.Execute(modelBuilder);
            base.OnModelCreating(modelBuilder);
        }
    }

    public class PaymentManagerContextFactory : IDesignTimeDbContextFactory<UniSyncDbContext>
    {
        public UniSyncDbContext CreateDbContext(string[] args)
        {
            var configuration = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddXmlFile("App.config")
                .Build();

            configuration
                .Providers
                .First()
                .TryGet("connectionStrings:add:Unisync:connectionString", out var connectionString);

            var options = new DbContextOptionsBuilder<UniSyncDbContext>()
                .UseSqlServer(connectionString)
                .Options;

            return new UniSyncDbContext(options);
        }
    }
}
