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
        /// <summary>
        /// adds a course to the database based on the text boxes and saves changes
        /// </summary>
        public void addCourse() {
            //makes sure text boxes arent empty because they are all essential to the course information
            if (textBoxClassProfessor.Text != "" && textBoxCourseSection.Text!= "" && textBoxClassSize.Text != "" && textBoxCourseID.Text != "" && textBoxCourseName.Text != "")
            {
                //creates a new course with the textboxes
                Course newCourse = new Course
                {
                    CourseId = Int32.Parse(textBoxCourseID.Text),
                    Section = Int32.Parse(textBoxCourseSection.Text),
                    CourseName = textBoxCourseName.Text,
                    MaxCourseSize = Int32.Parse(textBoxClassSize.Text),
                    Professor = context.Professors.Find(Int32.Parse(textBoxClassProfessor.Text)),
                };
                //adds and saves changes
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
