using Microsoft.EntityFrameworkCore;
using Data.Entities.Enums;
using Data.Entities.Models;
using System;
using System.Collections.Generic;

namespace Data.Seeds
{
    public class DBSeed
    {
        public static void Execute(ModelBuilder builder)
        {
            builder.Entity<Chat>()
                .HasData(new List<Chat>
                {
                    new Chat
                    {
                        Id = 1,
                        ChatName = "Matiša"
                    },
                });

            builder.Entity<College>()
                .HasData(new List<College>
                {
                    new College
                    {
                        Id = 1,
                        CollegeName = "FESB"
                    }
                }) ;

            builder.Entity<Message>()
                .HasData(new List<Message>
                {
                    new Message
                    {
                        Id = 1,
                        MessageText = "Hnjoh",
                        TimeSent = DateTime.Now,
                        StudentId= 1,
                        ChatId = 1
                    }
                }) ;

            builder.Entity<ScheduleItem>()
                .HasData(new List<ScheduleItem>
                {
                    new ScheduleItem
                    {
                        Id = 1,
                        EventName = "Majmuniranje",
                        StartTime = DateTime.Now,
                        Duration = 300,
                        RepetitionType = DurationType.Day,
                        RepetitionCounter = 3,
                        StudentId = 1
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
        }
    }
}
