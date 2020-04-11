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
            buttonModifyGrades.Click += ButtonModifyGrades_Click;
        }

        private void ButtonModifyGrades_Click(object sender, EventArgs e)
        {
            context.SaveChanges();
            MessageBox.Show("Changes saved.");
        }

        private void InitializeForm()
        {
            context.Students.Load();
            context.Courses.Load();
            context.Grades.Load();
            dataGridViewProfGrades.AllowUserToDeleteRows = false;
            dataGridViewProfGrades.AllowUserToAddRows = true;
            dataGridViewProfGrades.AllowUserToOrderColumns = true;

            dataGridViewProfGrades.DataSource = context.Grades.Where(s => s.CourseId == CourseID).ToList();



        }
    }
}
