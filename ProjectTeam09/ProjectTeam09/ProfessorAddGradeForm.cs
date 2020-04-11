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
    public partial class ProfessorAddGradeForm : Form
    {
        public int CourseID { get; set; }
        public StudentDirectory context = new StudentDirectory();
        public ProfessorAddGradeForm(int courseId)
        {
            InitializeComponent();
            CourseID = courseId;
            InitializeForm();
            buttonAddGrade.Click += ButtonAddGrade_Click;
        }
        /// <summary>
        /// Grabs the information that was inputted and adds it to the database.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonAddGrade_Click(object sender, EventArgs e)
        {
            try
            {
                context.Grades.Add(new Grade { Id = context.Grades.Max(s=> s.Id) + 1, StudentId = Int32.Parse(listBoxStudent.SelectedItem.ToString()), Assignment = textBoxAssignment.Text, CourseId = CourseID,
                    Grade1 = Double.Parse(textBoxGrade.Text) });
                context.SaveChanges();
                MessageBox.Show("Grade added.");
                ProfessorModifyGradesForm content = new ProfessorModifyGradesForm(CourseID);
                content.Show();
                this.Close();
             }
            catch
            {
                MessageBox.Show("An error has occured while adding the grade. Please make sure all the entries are correct.");
            }
        }
        /// <summary>
        /// Sets listbox.
        /// </summary>
        private void InitializeForm()
        {
            var query = from student in context.Students
                        where student.Class1 == CourseID || student.Class2 == CourseID || student.Class3 == CourseID || student.Class4 == CourseID || student.Class5 == CourseID
                        select student;

            foreach (var s in query)
            {
                listBoxStudent.Items.Add(s.StudentId);
            }
        }
    }
}
