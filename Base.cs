using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace EFGetStarted
{
    public class Base : DbContext
    {
        public DbSet<Student> Students  { get; set; }

        public Base()
        {
            Database.EnsureCreated();
        }
        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            optionsBuilder.UseSqlServer("Server=(localdb)\\mssqllocaldb;Database=team-db;Trusted_Connection=True;");
        }
    }
}
