using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace SchoolsMVC.Models
{
    public class LogicContext : DbContext
    {
        public LogicContext(DbContextOptions<LogicContext> options) : base(options)
        {

        }
        public DbSet<School> DBSchool { get; set; }
        public DbSet<Student> DBStudent { get; set; }
        public DbSet<Teacher> DBTeacher { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<School>().ToTable("School");
            modelBuilder.Entity<Student>().ToTable("Student");
            modelBuilder.Entity<Teacher>().ToTable("Teacher");
        }
    }
}
