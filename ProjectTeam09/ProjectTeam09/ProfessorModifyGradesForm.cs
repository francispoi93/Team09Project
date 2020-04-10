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
    public partial class ProfessorModifyGradesForm : Form
    {
        public int CourseID { get; set; }
        public StudentDirectory context = new StudentDirectory();
        public ProfessorModifyGradesForm(int courseid)
        {
            InitializeComponent();
            CourseID = courseid;
            InitializeForm();
            buttonViewGrades.Click += ButtonViewGrades_Click;
            buttonAddAssingment.Click += ButtonAddAssingment_Click;
        }

        private void ButtonAddAssingment_Click(object sender, EventArgs e)
        {
            listBoxAssignments.Items.Add(textBoxAddAssignment.Text);
        }


        private void ButtonViewGrades_Click(object sender, EventArgs e)
        {

            dataGridViewProfGrades.Rows.Clear();


            var queryFilterAssignment = from filterGrade in context.Grades
                                        where filterGrade.Assignment == listBoxAssignments.SelectedItem.ToString()
                                        select filterGrade;


            var queryDataGrid = from grades in context.Grades
                                from student in context.Students
                                where grades.CourseId == CourseID
                                where grades.Assignment == listBoxAssignments.SelectedItem.ToString()
                                select new
                                {
                                    Grade = grades.Grade1,
                                    StudentID = student.StudentId,
                                    StudentFirstName = student.FirstName,
                                    StudentLastName = student.LastName,
                                };
       
                foreach (var s in queryDataGrid)
                {
                    foreach (var h in queryFilterAssignment)
                    {
                        if (s.StudentID != h.StudentId)
                        {
                            dataGridViewProfGrades.Rows.Add(new string[] { s.StudentFirstName + " " + s.StudentLastName, "-" });

                        }

                        else
                        {
                            dataGridViewProfGrades.Rows.Add(new string[] { s.StudentFirstName + " " + s.StudentLastName, s.Grade.ToString() });

                        }
                    }
                }
            }

        

        private void InitializeForm()
        {
            context.Students.Load();
            context.Courses.Load();
            context.Grades.Load();

            var query = from grades in context.Grades
                        where grades.CourseId == CourseID
                        select new
                        {
                            Assignment = grades.Assignment
                        };
            foreach (var s in query)
            {
                if (listBoxAssignments.Items.Contains(s.Assignment))
                {
                }
                else
                {
                    listBoxAssignments.Items.Add(s.Assignment);
                }
            }
            dataGridViewProfGrades.AllowUserToDeleteRows = false;


            DataGridViewTextBoxColumn[] columns = new DataGridViewTextBoxColumn[]
            {
                new DataGridViewTextBoxColumn() {Name = "Student Name"},
                new DataGridViewTextBoxColumn() {Name = "Grade"},
            };
            dataGridViewProfGrades.Columns.AddRange(columns);


        }
    }
}
