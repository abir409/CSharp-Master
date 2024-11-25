using System;
using System.Reflection;
using Microsoft.EntityFrameworkCore;
using EntityFrameworkExample.Entities;

namespace EntityFrameworkExample
{
    public class TrainingDbContext : DbContext
    {
        private readonly string _connectionString;
        private readonly string _migrationAssembly;

        public TrainingDbContext()
        {
            _connectionString = @"Server=192.168.11.148;Database=CSharpnew;User Id=sa;Password=fintech@123;";
            _migrationAssembly = Assembly.GetExecutingAssembly().GetName().Name; // Fixed parentheses issue here
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer(_connectionString, options =>
                {
                    options.MigrationsAssembly(_migrationAssembly);
                });
            }

            base.OnConfiguring(optionsBuilder);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // If additional configuration is needed, do it here, e.g.:
            // modelBuilder.Entity<Course>().HasKey(c => c.Id);
        }

        // Corrected visibility for DbSet
        public DbSet<Course> Courses { get; set; } // Changed to public
        public DbSet<Student> Students { get; set; }
    }
}
