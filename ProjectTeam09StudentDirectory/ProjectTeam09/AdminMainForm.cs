using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace ProjectTeam09
{
    public partial class AdminMainForm : Form
    {
        public StudentDirectory context = new StudentDirectory();
        public AdminMainForm(int userId)
        {
            InitializeComponent();
            buttonAddCourse.Click += (s,e) => AddCourse();
            buttonSearch.Click += (s,e) => IdView(userId);
            buttonBackupXML.Click += (s, e) => BackupDataSetToXML();
            buttonAddModifyUser.Click += (s,e) => AddModifyUser();
            buttonReportForm.Click += (s,e) => ReportFormCaller();
        }
        /// <summary>
        /// backs up data to xml, I had to do it more hands on than using the 
        /// serializer because it doesnt handle custom classes very well
        /// </summary>
        public void BackupDataSetToXML()
        {
           //this uses linq and some XML classes to construct the architecture then fills in the values from the database
            XElement backup = new XElement("StudentDirectory", 
                new XElement("Admins",
                (from admin in context.Admin
                select new
                {
                   admin.AdminId,
                   admin.FirstName,
                   admin.LastName
                }).ToList().Select(
                    x => new XElement("Admin", 
                    new XAttribute("AdminId" , x.AdminId.ToString()),
                    new XAttribute("FirstName" , x.FirstName),
                    new XAttribute("LastNameS" , x.LastName)
                    ))),
                new XElement("Professors",
                 (from prof in context.Professors
                 select new
                 {
                     prof.ProfessorId,
                     prof.FirstName,
                     prof.LastName,
                     prof.Class1,
                     prof.Class2,
                     prof.Class3,
                     prof.Class4,
                     prof.Class5,
                 }
                 ).ToList().Select(
                    x=> new XElement("Professor",
                    new XAttribute("ProfessorId", x.ProfessorId),
                    new XAttribute("FirstName", x.FirstName),
                    new XAttribute("LastName", x.LastName),
                    new XAttribute("Class1", x.Class1 ?? 000),
                    new XAttribute("Class2", x.Class2 ?? 000),
                    new XAttribute("Class3", x.Class3 ?? 000),
                    new XAttribute("Class4", x.Class4 ?? 000),
                    new XAttribute("Class5", x.Class5 ?? 000)
                    ))),
                new XElement("Student",
                (from student in context.Students
                 select new 
                 { 
                    student.StudentId,
                    student.FirstName,
                    student.LastName,
                    student.GPA,
                    student.Class1,
                    student.Class2,
                    student.Class3,
                    student.Class4,
                    student.Class5,
                    student.PhoneNumber,
                    student.Email,
                 }).ToList().Select(
                    x=> new XElement("Students",
                    new XAttribute("StudentId", x.StudentId),                       
                    new XAttribute("FirstName", x.FirstName),                       
                    new XAttribute("LastName", x.LastName),                       
                    new XAttribute("GPA", x.GPA),                       
                    new XAttribute("Class1", x.Class1 ?? 000),                       
                    new XAttribute("Class2", x.Class2 ?? 000),                       
                    new XAttribute("Class3", x.Class3 ?? 000),                       
                    new XAttribute("Class4", x.Class4 ?? 000),                       
                    new XAttribute("Class5", x.Class5 ?? 000),                       
                    new XAttribute("PhoneNumber", x.PhoneNumber),                       
                    new XAttribute("Email", x.Email)                   
                        ))),
                new XElement("Courses",
                (from courses in context.Courses
                 select new 
                 { 
                    courses.CourseId,
                    courses.CourseName,
                    courses.CourseNumber,
                    courses.ProfessorId,
                    courses.Section,
                    courses.MaxCourseSize,
                    courses.DocumentsFolder
                 }).ToList().Select(
                   x=> new XElement("Course",
                   new XAttribute("CourseId",x.CourseId),
                   new XAttribute("CourseName",x.CourseName),
                   new XAttribute("CourseNumber",x.CourseNumber),
                   new XAttribute("ProfessorId",x.ProfessorId),
                   new XAttribute("Section",x.Section),
                   new XAttribute("MaxCourseSize",x.MaxCourseSize),
                   new XAttribute("DocumentsFolder",x.DocumentsFolder ?? System.IO.Path.GetFullPath(Application.StartupPath).ToString())
                   ))),
                new XElement("UserCredentials",
                (from user in context.UserCredentials
                 select new { 
                     user.UserId,
                     user.Password,
                     user.Permissions
                 }).ToList().Select(
                 x=> new XElement("UserCredentials",
                 new XAttribute("UserID", x.UserId),
                 new XAttribute("Password", x.Password),
                 new XAttribute("Permissions", x.Permissions)
                 ))), 
                new XElement("Grades",
                (from grades in context.Grades
                 select new
                 {
                     grades.StudentId,
                     grades.CourseId,
                     grades.Assignment,
                     grades.Grade1
                 }).ToList().Select(
                    x=> new XElement("Grades",
                    new XAttribute("StudentId", x.StudentId),
                    new XAttribute("CourseId", x.CourseId),
                    new XAttribute("Assignment", x.Assignment),
                    new XAttribute("Grade1", x.Grade1)
                    )))
                );
            backup.Save("../../XmlBackup.xml");
            MessageBox.Show("backup saved to XML");
        }
        /// <summary>
        /// calls reports
        /// </summary>
        private void ReportFormCaller() {
            AdminProfessorReport adminProfessorReport = new AdminProfessorReport();
            adminProfessorReport.Show();
        }
       /// <summary>
       /// calls the form for adding and modify users
       /// </summary>
        public void AddModifyUser() 
        {
            AdminAddUser addUser = new AdminAddUser();
            addUser.Show();
        }
        /// <summary>
        /// calls the add course form
        /// </summary>
        public void AddCourse() 
        {
            AdminAddCourse addCourse = new AdminAddCourse();
            addCourse.Show();
        }
        /// <summary>
        /// the searching function to see what the user that needs help sees
        /// </summary>
        /// <param name="userId"></param>
        public void IdView(int userId)
        {
            int viewId = new int();
            try
            {
                viewId = Int32.Parse(textBoxUserID.Text);
                if (1999 < viewId && viewId< 2999) {
                    StudentMainForm studentMainForm = new StudentMainForm(viewId);
                    studentMainForm.Show();
                }
                else if (2999 < viewId && viewId < 3999)
                {
                   ProfessorMainForm professorMainForm = new ProfessorMainForm(viewId);
                    professorMainForm.Show();
                }
                else {
                    MessageBox.Show("Id view unavailable");
                }
            }
            catch
            {
                MessageBox.Show("Please enter a number");
            }
        }
    }
}
