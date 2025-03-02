using EFCore_Session_Three_Relation.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory.Database;

namespace EFCore_Session_Three_Relation
{
    internal class ITIContext:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
           optionsBuilder.UseSqlServer("Server = Mohamed-Hesham\\MSSQLSERVER01 ; Database = ITI_V2; Integrated Security = True; TrustServerCertificate = True");
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            #region Topic and Course
            modelBuilder.Entity<Topic>()
                .HasMany(c => c.Course)
                .WithOne(r => r.topic)
                .HasForeignKey(r => r.topicID)
                .IsRequired(false);

            modelBuilder.Entity<Course>()
                .HasOne(c => c.topic)
                .WithMany(x => x.Course)
                .HasForeignKey(r => r.topicID)
                .IsRequired(true);
            #endregion
            //---------------//
            #region ins_ and Deparment
            modelBuilder.Entity<Department>()
                .HasMany(r => r.instructors)
                .WithOne(t => t.department)
                .IsRequired(false)
                .HasForeignKey(r => r.departmentId); 
            
            modelBuilder.Entity<Instructor>()
                .HasOne(r => r.department)
                .WithMany(t => t.instructors)
                .IsRequired(false)
                .HasForeignKey(r => r.departmentId);
            #endregion
            //--------------//
            #region Set Primary key for   Course instructor
            modelBuilder.Entity<Course_instructor>().HasKey(e => new { e.InstructorId, e.CourseId });

            #endregion
            #region Set Primary Key for StudentCourse
            modelBuilder.Entity<Student_Course>().HasKey(s => new { s.StudentId, s.CourseId });
            #endregion

        }
        //All Tables
        public DbSet<Student> students { get; set; }
        public DbSet<Department> departments { get; set; }
        public DbSet<Course> courses { get; set; }
        public DbSet<Instructor> instructors { get; set; }
        public DbSet<Topic> Topic { get; set; }
        public DbSet<Course_instructor> Course_Instructors { get; set; }
        public DbSet<Student_Course> student_Courses { get; set; }

    }
}
