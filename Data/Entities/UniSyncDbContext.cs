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

        public DbSet<Chat> Chat { get; set; }
        public DbSet<College> College { get; set; }
        public DbSet<Subject> Subject { get; set; }
        public DbSet<Message> Message { get; set; }
        public DbSet<ScheduleItem> ScheduleItem { get; set; }
        public DbSet<Student> Student { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder
                .Entity<Message>()
                .HasOne(r => r.Chat)
                .WithMany(rs => rs.Messages)
                .OnDelete(DeleteBehavior.NoAction);
            modelBuilder
                .Entity<Message>()
                .HasOne(r => r.Student)
                .WithMany(rs => rs.Messages)
                .OnDelete(DeleteBehavior.NoAction);

            modelBuilder
                .Entity<ScheduleItem>()
                .HasOne(p => p.Student)
                .WithMany(r => r.ScheduleItems)
                .OnDelete(DeleteBehavior.NoAction);

            modelBuilder
                .Entity<Subject>()
                .HasOne(r => r.College)
                .WithMany(c => c.Subjects)
                .OnDelete(DeleteBehavior.NoAction);

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
