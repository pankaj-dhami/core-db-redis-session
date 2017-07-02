using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System.IO;

namespace WebApplication1.model
{
    public class SchoolContext : DbContext
    {
        public SchoolContext(DbContextOptions <SchoolContext> options) : base(options)
        {
             
        }

        public DbSet<Student> Students { get; set; }
       
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Student>().ToTable("Student");
        }
    }
}
