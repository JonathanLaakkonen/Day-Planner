using System;
using System.Collections.Generic;
using System.Text;
using EntityFrameworkCore;
using EventClass.cs;

namespace Day_Planner.Data
{
    //Entities
    public class EventContext : DbContext
    {
        public DbSet<Event> Event { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=(localdb)\\mssqllocaldb;Database=DayPlannerdb;Trusted_Connection=True");
        }
    }
}
