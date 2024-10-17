using Microsoft.EntityFrameworkCore;
using System;

namespace PlanningApp
{
    public class AppDbContext : DbContext
    {
        // 有参数构造函数，供依赖注入使用
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }
        public DbSet<User> Users { get; set; }
        public DbSet<TouristSpot> TouristSpots { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                string dbPath = System.IO.Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "..", "..", "..", "localdatabase.db");
                optionsBuilder.UseSqlite($"Data Source={dbPath}");
                Console.WriteLine($"Using database file at: {dbPath}");
            }
        }
    }
}










