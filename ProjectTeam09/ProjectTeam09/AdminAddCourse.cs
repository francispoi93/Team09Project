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
            buttonCourseAdd.Click += (s, e) => addCourse();
        }
        public void addCourse() {
            if (textBoxClassProfessor.Text != null && textBoxCourseSection.Text!=null && textBoxClassSize.Text != null && textBoxCourseID.Text != null && textBoxCourseName.Text != null)
            {
                Course newCourse = new Course
                {
                    CourseId = Int32.Parse(textBoxCourseID.Text),
                    Section = Int32.Parse(textBoxCourseSection.Text),
                    CourseName = textBoxCourseName.Text,
                    maxClassSize = Int32.Parse(textBoxClassSize.Text),
                    Professor = context.Professors.Find(Int32.Parse(textBoxClassProfessor.Text)),
                };
                context.Courses.Add(newCourse);
                context.SaveChanges();
                this.Close();
            }
            else
            {
                MessageBox.Show("You must not leave a entry empty.");
            }
        }
    }
}
