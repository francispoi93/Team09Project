using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Entity;

namespace ProjectTeam09
{
    public partial class AdminAddForm : Form
    {
        public StudentDirectory context = new StudentDirectory();
        public int ProfessorID { get; set; }
        public int StudentID { get; set; }
        public int AdminID { get; set; }
        public AdminAddForm()
        { 
            InitializeComponent();
            context.Admin.Load();
            context.Students.Load();
            context.Professors.Load();
            buttonAddUser.Click += ButtonAddUser_Click;
            radioButtonAdminSelect.CheckedChanged += (s, e) => DisableClassInput();
        }
        /// <summary>
        /// when you select a radiobutton for admin it disables uneeded inputs, and when it is unselected enables them again.
        /// </summary>
        private void DisableClassInput()
        {
            if (radioButtonAdminSelect.Checked == true)
            {
                textBoxClass1.Enabled = false;
                textBoxClass1.Visible = false;
                textBoxClass2.Enabled = false;
                textBoxClass2.Visible = false;
                textBoxClass3.Enabled = false;
                textBoxClass3.Visible = false;
                textBoxClass4.Enabled = false;
                textBoxClass4.Visible = false;
                textBoxClass5.Enabled = false;
                textBoxClass5.Visible = false;

                labelClass1.Visible = false;
                labelClass2.Visible = false;
                labelClass3.Visible = false;
                labelClass4.Visible = false;
                labelClass5.Visible = false;
            }
            else
            {
                textBoxClass1.Enabled = true;
                textBoxClass1.Visible = true;
                textBoxClass2.Enabled = true;
                textBoxClass2.Visible = true;
                textBoxClass3.Enabled = true;
                textBoxClass3.Visible = true;
                textBoxClass4.Enabled = true;
                textBoxClass4.Visible = true;
                textBoxClass5.Enabled = true;
                textBoxClass5.Visible = true;

                labelClass1.Visible = true;
                labelClass2.Visible = true;
                labelClass3.Visible = true;
                labelClass4.Visible = true;
                labelClass5.Visible = true;
            }
        }
        private void ButtonAddUser_Click(object sender, EventArgs e)
        {
            //if there isnt anything selected it tells you to select
            if(radioButtonAdminSelect.Checked == false && radioButtonStudentSelect.Checked == false && radioButtonProfessorSelect.Checked == false)
            {
                MessageBox.Show("Please select a user type.");
                return;
            }
            //makes sure essential fields are filled
            if (textBoxFirstName.Text != null && textBoxLastName.Text != null)
            {
                //radio button determining admin
                if (radioButtonAdminSelect.Checked)
                {
                    //iterates the userID
                    int currentAdminID = 1000 +(context.Admin.Count()+1);
                    if (currentAdminID >= 2000)
                    {
                        MessageBox.Show("there is no more room for Admins");
                        return;
                    }
                    context.Admin.Load();
                    //creates an admin from input then adds it to the database then saves it
                    Admin admin = new Admin
                    {
                        AdminId = currentAdminID,
                        FirstName = textBoxFirstName.Text,
                        LastName = textBoxLastName.Text
                    }; 
                    context.Admin.Add(admin);
                    context.SaveChanges();
                    AdminID = admin.AdminId;
                    context.Dispose();
                }
                if (radioButtonProfessorSelect.Checked)
                {
                    //iterates the userId
                    int currentProfessorID = 3000 + (context.Professors.Count() + 1);
                    if(currentProfessorID>= 4000)
                    {
                        MessageBox.Show("there is no more room for Professors");
                        return;
                    }
                    context.Professors.Load();
                    //creates a professor and then adds it to the database and saves it.
                    Professor professor = new Professor
                    {
                        ProfessorId = 3000 + (context.Professors.Count() + 1),
                        FirstName = textBoxFirstName.Text,
                        LastName = textBoxLastName.Text,
                        Class1 = TestTextBox(textBoxClass1),
                        Class2 = TestTextBox(textBoxClass2),
                        Class3 = TestTextBox(textBoxClass3),
                        Class4 = TestTextBox(textBoxClass4),
                        Class5 = TestTextBox(textBoxClass5),
                    };
                    context.Professors.Add(professor);
                    context.SaveChanges();
                    ProfessorID = professor.ProfessorId;
                    context.Dispose();
                }
                //radio button determining student user type
                if (radioButtonStudentSelect.Checked)
                {
                    int currentStudentID = 2000 + (context.Students.Count() + 1);
                    if (currentStudentID >= 3000)
                    {
                        MessageBox.Show("there is no more room for Student");
                        return;
                    }
                    //checks class inputs
                    int? Class1 = TestTextBox(textBoxClass1);
                    int? Class2 = TestTextBox(textBoxClass2);
                    int? Class3 = TestTextBox(textBoxClass3);
                    int? Class4 = TestTextBox(textBoxClass4);
                    int? Class5 = TestTextBox(textBoxClass5);
                    context.Students.Load();
                    //creates a student and adds it to the database before saving
                    Student student = new Student
                    {
                        StudentId = currentStudentID,
                        FirstName = textBoxFirstName.Text,
                        LastName = textBoxLastName.Text,
                        Class1 = Class1,
                        Class2 = Class2,
                        Class3 = Class3,
                        Class4 = Class4,
                        Class5 = Class5,
                        PhoneNumber = "",
                        Email=""
                    };
                    context.Students.Add(student);
                    context.SaveChanges();
                    StudentID = student.StudentId;
                    context.Dispose();
                }
                this.Close();
            }
            else {
                MessageBox.Show("Please input BOTH first and last name");
                return;
            }
        }
        /// <summary>
        /// this is just validating if the field is filled and then assigning it, so no ridiculous if statements.
        /// </summary>
        /// <param name="textBox"></param>
        /// <returns></returns>
        private int? TestTextBox(TextBox textBox)
        {
            if (textBox.Text != "")
            {
                try
                {
                    return int.Parse(textBox.Text);
                }
                catch
                {
                    MessageBox.Show("please enter a proper classID");
                }
            }
            return null;
        }
    }
}
