using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EFCoreAssignment001
{
    #region DbContext Class (Data Annotation)
    public class ITIDbContext : DbContext
    {
        public DbSet<Student> Students { get; set; }
        public DbSet<Department> Departments { get; set; }
        public DbSet<Course> Courses { get; set; }
        public DbSet<Instructor> Instructors { get; set; }
        public DbSet<Topic> Topics { get; set; }
        public DbSet<Stud_Course> StudCourses { get; set; }
        public DbSet<Course_Inst> CourseInstructors { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=.;Database=ITIDb;Trusted_Connection=True;");
        }
    }
    #endregion (

    #region Student Entity (Convention)
    public class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
    }
    #endregion

    #region Department Entity (Convention)
    public class Department
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }
    #endregion

    #region Course Entity (Data Annotation)
    public class Course
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
    }
    #endregion

    #region Instructor Entity (Data Annotation)
    public class Instructor
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Salary { get; set; }
    }
    #endregion

    #region Topic Entity (Data Annotation)
    public class Topic
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
    }
    #endregion

    #region Stud_Course (Data Annotation)
    public class Stud_Course
    {
        [Key]
        public int StudId { get; set; }
        [Key]
        public int CourseId { get; set; }
    }
    #endregion

    #region Course_Inst (Data Annotation)
    public class Course_Inst
    {
        [Key]
        public int CourseId { get; set; }
        [Key]
        public int InstId { get; set; }
    }
    #endregion
}
