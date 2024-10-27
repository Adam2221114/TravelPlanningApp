using Microsoft.EntityFrameworkCore;
using System;

namespace PlanningApp
{
    public class AppDbContext : DbContext
    {
        // Constructor used for dependency injection
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }

        // Parameterless constructor, for design-time use (such as during migration)
        public AppDbContext()
        {
        }

        // DbSet is used to manage users and attractions
        public DbSet<User> Users { get; set; }
        public DbSet<TouristSpot> TouristSpots { get; set; }

        //Configure TPH (Table Per Hierarchy) inheritance mode
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>()
                .HasDiscriminator<string>("UserType")
                .HasValue<Customer>("Customer")
                .HasValue<Staff>("Staff");
        }

        // Configure the connection string. If not configured, use the default value
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                // Provide a default SQLite connection string
                string dbPath = System.IO.Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "localdatabase.db");
                optionsBuilder.UseSqlite($"Data Source={dbPath}");
                Console.WriteLine($"Using database file at: {dbPath}");
            }
        }
    }
}












