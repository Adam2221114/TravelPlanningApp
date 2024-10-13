using System.Data.Entity;

namespace PlanningApp
{
    public class AppDbContext : DbContext
    {
        public AppDbContext() : base("name=AppDbContext")
        {
        }

        public DbSet<User> Users { get; set; }
    }
}



