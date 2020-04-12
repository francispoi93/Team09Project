using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectTeam09
{
    public partial class AdminProfessorReport : Form
    {
        public int CourseID { get; set; }
        public StudentDirectory context = new StudentDirectory();
        public AdminProfessorReport()
        {
            InitializeComponent();
            InitializeForm();
            listBoxStudentNumber.SelectedIndexChanged += ListBoxStudentNumber_SelectedIndexChanged;
        }
        /// <summary>
        /// Updates information based on selected course ID. (Number of students, list of students, professor, section, name)
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ListBoxStudentNumber_SelectedIndexChanged(object sender, EventArgs e)
        {
            CourseID = Int32.Parse(listBoxStudentNumber.SelectedItem.ToString());
            var courseInfo = context.Courses.Find(CourseID);
            var profInfo = context.Professors.Find(courseInfo.ProfessorId);
            var query = from student in context.Students
                        where CourseID == student.Class1 || CourseID == student.Class2 || CourseID == student.Class3 || CourseID == student.Class4 || CourseID == student.Class5
                        select student;
            labelProfessorData.Text = profInfo.FirstName + " " + profInfo.LastName;
            labelCourseSectionData.Text = courseInfo.Section.ToString();
            labelCourseNameData.Text = courseInfo.CourseName.ToString();
            labelAverageStudentGPA.Text = query.Average(s=> s.GPA).ToString();
            labelStudentNumberData.Text = query.Count().ToString();
            listBoxStudents.Items.Clear();
            foreach (var s in query)
            {
                listBoxStudents.Items.Add(s.FirstName + " " + s.LastName);
            }

        }
        /// <summary>
        /// Loads initial listbox for filtering.
        /// </summary>
        private void InitializeForm()
        {
            context.Students.Load();
            context.Courses.Load();
            var query = from course in context.Courses
                        select course;

            foreach (var s in query)
            {
                listBoxStudentNumber.Items.Add(s.CourseId);
            }
        }
    }
}
