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
    public partial class StudentGradesForm : Form
    {
        public int StudentID { get; set; }
        public int CourseID { get; set; }
        StudentDirectory context = new StudentDirectory();
        public StudentGradesForm(int studentId, int courseId)
        {
            StudentID = studentId;
            CourseID = courseId;
            InitializeComponent();
            InitializeDataGrid();
        }
        /// <summary>
        /// Initializes datagrid and filters based on student and class chosen.
        /// </summary>
        private void InitializeDataGrid()
        {
          
            context.Grades.Load();
            dataGridViewStudentGrades.AllowUserToDeleteRows = false;


            DataGridViewTextBoxColumn[] columns = new DataGridViewTextBoxColumn[]
            {
                new DataGridViewTextBoxColumn() {Name = "Assignment"},
                new DataGridViewTextBoxColumn() {Name = "Grade"}
            };
            dataGridViewStudentGrades.Columns.AddRange(columns);

            var query = from gradeslist in context.Grades
                        where gradeslist.CourseId == CourseID
                        where gradeslist.StudentId == StudentID
                        select new
                        {
                            Assignment = gradeslist.Assignment,
                            Grade = gradeslist.Grade1,
                        };
                        
            foreach (var s in query)
            {
                dataGridViewStudentGrades.Rows.Add(new string[] { s.Assignment, s.Grade.ToString() });
               
            }
        }
    }
}
