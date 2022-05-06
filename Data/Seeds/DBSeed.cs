using Microsoft.EntityFrameworkCore;
using Data.Entities.Models;
using System;
using System.Collections.Generic;

namespace Data.Seeds
{
    public class DBSeed
    {
        public static void Execute(ModelBuilder builder)
        {

            builder.Entity<College>()
                .HasData(new List<College>
                {
                    new College
                    {
                        Id = 1,
                        CollegeName = "FESB"
                    }
                }) ;

            builder.Entity<Student>()
                .HasData(new List<Student>
                {
                    new Student
                    {
                        Id = 1,
                        Name = "Ante",
                        Surname = "Samo"
                    }
                });

            builder.Entity<Subject>()
                .HasData(new List<Subject>
                {
                    new Subject
                    {
                        Id = 1,
                        SubjectName = "Matiša",
                        CollegeId = 1
                    }
                });

            builder.Entity<Tag>()
                .HasData(new List<Tag>
                {
                    new Tag
                    {
                        Id = 1,
                        TagName = "c#"
                    }
                });
        }
    }
}
