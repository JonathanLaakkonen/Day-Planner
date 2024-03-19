using Microsoft.EntityFrameworkCore;
using Day_Planner.Models;

namespace Day_Planner.Data
{
    //Entities
    public class DataContext : DbContext
    {
          public DataContext(DbContextOptions<DataContext> options) : base(options)
        {
        
        }

        public DbSet<Event> Events { get; set; }
    }
}
