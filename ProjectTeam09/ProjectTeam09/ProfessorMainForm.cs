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
    public partial class ProfessorMainForm : Form
    {
        public int ProfessorID { get; set; }
        public int CourseID { get; set; }
        public StudentDirectory context = new StudentDirectory();
        public ProfessorMainForm(int userId)
        {

            InitializeComponent();
            ProfessorID = userId;
             InitializeForm();
            buttonAddContent.Click += ButtonAddContent_Click;
            buttonGrades.Click += ButtonGrades_Click;

        }
        /// <summary>
        /// Grabs the course ID from the selected row and opens up the modify grades form of the class chosen
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonGrades_Click(object sender, EventArgs e)
        {
            CourseID = 0;
            try
            {
                try
                {
                    foreach (DataGridViewRow row in dataGridViewProfessorCourses.SelectedRows)
                    {
                        CourseID = Int32.Parse(row.Cells[0].Value.ToString());
                    }
                }
                catch
                {
                }
                var contextCourse = context.Courses.Find(CourseID);
                ProfessorModifyGradesForm contentForm = new ProfessorModifyGradesForm(CourseID);
                contentForm.Show();
            }
            catch
            {
                MessageBox.Show("Please select a valid class.");
            }
        }
        /// <summary>
        ///  Initializes datagridview based on the courses the professor is teaching from the database. Can be selected to go to further menus.
        /// </summary>
        private void InitializeForm()
        {
            context.Professors.Load();
            context.Courses.Load();
            var professor = context.Professors.Find(ProfessorID);

            dataGridViewProfessorCourses.AllowUserToDeleteRows = false;
            DataGridViewTextBoxColumn[] columns = new DataGridViewTextBoxColumn[]
            {
                new DataGridViewTextBoxColumn() {Name = "Course ID"},
                new DataGridViewTextBoxColumn() {Name = "Course"},
                new DataGridViewTextBoxColumn() {Name = "Section"},
            };

            dataGridViewProfessorCourses.Columns.AddRange(columns);

            var query = from courses in context.Courses
                        where courses.CourseId == professor.Class1 || courses.CourseId == professor.Class2 || courses.CourseId == professor.Class3 ||
                        courses.CourseId == professor.Class4 || courses.CourseId == professor.Class5
                        select courses;
            foreach (var s in query)
            {
                dataGridViewProfessorCourses.Rows.Add(new string[] { s.CourseId.ToString(), s.CourseName, s.Section.ToString() });
            }
        }
        /// <summary>
        /// Grabs the course ID from the selected row and opens up the view content form of the class chosen
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonAddContent_Click(object sender, EventArgs e)
        {
            CourseID = 0;
            try
            {
                try
                {
                    foreach (DataGridViewRow row in dataGridViewProfessorCourses.SelectedRows)
                    {
                        CourseID = Int32.Parse(row.Cells[0].Value.ToString());
                    }
                }
                catch
                {
                }
                var contextCourse = context.Courses.Find(CourseID);
                string contentPath = contextCourse.DocumentsFolder;
                ProfessorAdContentForm contentForm = new ProfessorAdContentForm(contentPath);
                contentForm.Show();
            }
            catch
            {
                MessageBox.Show("Please select a valid class.");
            }
        }
    }
}
