using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectTeam09
{
    public partial class AdminAddCourse : Form
    {
        public StudentDirectory context = new StudentDirectory();
        public AdminAddCourse()
        {
            InitializeComponent();
            Course newCourse = new Course {
                CourseId = Int32.Parse(textBoxCourseID.Text),
                CourseName = textBoxCourseName.Text,

                Professor = context.Professors.Find(Int32.Parse(textBoxClassProfessor.Text)),
            };
            context.Courses.Add(newCourse);
        }
    }
}
