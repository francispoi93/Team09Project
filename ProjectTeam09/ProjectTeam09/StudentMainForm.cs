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
    public partial class StudentMainForm : Form
    {
        public int StudentID { get; set; }
        public int CourseID { get; set; }
        public StudentDirectory context = new StudentDirectory();
        public StudentMainForm(int userId)
        {
            StudentID = userId;
            InitializeComponent();
            InitializeForm(userId);
            //when we do the coding, the grades button gets which class from the bottom dataGridView and student from top, both must be selected. 
            //edit personal info button gets the student from dataGridView and on form load fills all the info textboxes 
            //TODO personal info form
            buttonEditPersonalInfo.Click += ButtonEditPersonalInfo_Click;
            buttonShowGrades.Click += ButtonShowGrades_Click;
            buttonShowContent.Click += ButtonShowContent_Click;
        }

        private void ButtonShowContent_Click(object sender, EventArgs e)
        {
            CourseID = 0;
            try
            {
                SelectedRows();
                var contextCourse = context.Courses.Find(CourseID);
                string contentPath = contextCourse.DocumentsFolder;
                CourseContentForm contentForm = new CourseContentForm(contentPath);
                contentForm.Show();
            }
            catch
            {
                MessageBox.Show("Please select a valid class.");
            }
        }

        private void ButtonShowGrades_Click(object sender, EventArgs e)
        {
            CourseID = 0;
            try {
                SelectedRows();
                if (CourseID != 0)
                {
                    StudentGradesForm gradeForm = new StudentGradesForm(StudentID, CourseID);
                    gradeForm.Show();
                }
                else
                {
                    MessageBox.Show("Please select a valid class.");
                }
            }
            catch
            {
                MessageBox.Show("Please select a valid class.");
            }


        }

        public void SelectedRows()
        {
            try
            {
                foreach (DataGridViewRow row in dataGridViewAvailable.SelectedRows)
                {
                    CourseID = Int32.Parse(row.Cells[0].Value.ToString());
                }
            }
            catch
            {
            }
        }
        private void ButtonEditPersonalInfo_Click(object sender, EventArgs e)
        {
            StudentInfoForm studentForm = new StudentInfoForm(StudentID);
            studentForm.Show();
        }

        private void InitializeForm(int userId)
        {
            context.Students.Load();
            context.Courses.Load();
            var student = context.Students.Find(userId);
            dataGridViewAvailable.AllowUserToDeleteRows = false;


            DataGridViewTextBoxColumn[] columns = new DataGridViewTextBoxColumn[]
            {
                new DataGridViewTextBoxColumn() {Name = "Course ID"},
                new DataGridViewTextBoxColumn() {Name = "Course"},
                new DataGridViewTextBoxColumn() {Name = "Professor Name"},
                new DataGridViewTextBoxColumn() {Name = "Section"}
            };
            dataGridViewAvailable.Columns.AddRange(columns);

            var query = from courses in context.Courses
                        where courses.CourseId == student.Class1 || courses.CourseId == student.Class2
                        select courses;
            foreach (var s in query)
            {
                dataGridViewAvailable.Rows.Add(new string[] {s.CourseId.ToString(), s.CourseName, s.Professor.FirstName + " " + s.Professor.LastName, s.Section.ToString() }) ; 
            }
            
        }


       









        }
    }

