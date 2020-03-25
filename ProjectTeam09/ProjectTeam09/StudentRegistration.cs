namespace ProjectTeam09
{
    using System;
    using System.Data.Entity;
    using System.Linq;

    public class StudentRegistration : DbContext
    {
        public StudentRegistration()
            : base("name=StudentRegistration")
        {
        }

        public DbSet<UserCredential> UserCredentials { get; set; }
        public DbSet<Student> Students { get; set; }
        public DbSet<Professor> Professors { get; set;}
        public DbSet<Course> Courses { get; set; }

    }

    public class UserCredential
    {
        public int UserID { get; set; }
        public string Password { get; set; }
        public string Permission { get; set; }
    }

    public class Student
    {
        public int StudentId { get; set; }
        public string StudentFirstName { get; set; }
        public string StudentLastName { get; set; }
        public double StudentGpa { get; set; }
    }

    public class Professor
    {
        public int ProfessorId { get; set; }
        public string ProfessorFirstName { get; set; }
        public string ProfessorLatsName { get; set; }
    }
    
    public class Course
    {
        public int CourseId { get; set; }
        public string CourseName { get; set; }
        public string CourseSemester { get; set; }
        public int CourseSection { get; set; }
        public string CourseProfessor { get; set; }
        public string CourseDocumentsFolder { get; set; }
    }



}