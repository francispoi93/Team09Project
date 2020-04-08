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
        public AdminAddForm()
        { 
            InitializeComponent();
            context.Admin.Load();
            context.Students.Load();
            context.Professors.Load();
            buttonAddUser.Click += ButtonAddUser_Click;
            radioButtonAdminSelect.CheckedChanged += (s, e) => DisableClassInput();
            textBoxClass1.Text = "0";
            textBoxClass2.Text = "0";
            textBoxClass3.Text = "0";
            textBoxClass4.Text = "0";
            textBoxClass5.Text = "0";
        }
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
            if(radioButtonAdminSelect.Checked == false && radioButtonStudentSelect.Checked == false && radioButtonProfessorSelect.Checked == false)
            {
                MessageBox.Show("Please select a user type.");
                return;
            }
            if (textBoxFirstName.Text != null && textBoxLastName.Text != null)
            {
                if (radioButtonAdminSelect.Checked)
                {
                  
                    int currentAdminID = 1000 +(context.Admin.Count()+1);
                    if (currentAdminID >= 2000)
                    {
                        MessageBox.Show("there is no more room for Admins");
                        return;
                    }
                    Admin admin = new Admin()
                    {
                        AdminId = currentAdminID,
                        FirstName = textBoxFirstName.Text,
                        LastName = textBoxLastName.Text
                    }; 
                    context.Admin.Load();
                    context.Admin.Add(admin);
                    context.SaveChanges();

                }
                if (radioButtonProfessorSelect.Checked)
                {
                    int currentProfessorID = 3000 + (context.Professors.Count() + 1);
                    if(currentProfessorID>= 4000)
                    {
                        MessageBox.Show("there is no more room for Professors");
                        return;
                    }
                    Professor professor = new Professor()
                    {
                        ProfessorId = 3000 + (context.Professors.Count() + 1),
                        FirstName = textBoxFirstName.Text,
                        LastName = textBoxLastName.Text,
                        Class1 = Int32.Parse(textBoxClass1.Text),
                        Class2 = Int32.Parse(textBoxClass2.Text),
                        Class3 = Int32.Parse(textBoxClass3.Text),
                        Class4 = Int32.Parse(textBoxClass4.Text),
                        Class5 = Int32.Parse(textBoxClass5.Text)
                    };
                    context.Professors.Load();
                    context.Professors.Add(professor);
                    context.SaveChanges();
                }

                if (radioButtonStudentSelect.Checked)
                {
                    int currentStudentID = 2000 + (context.Students.Count() + 1);
                    if (currentStudentID >= 3000)
                    {
                        MessageBox.Show("there is no more room for Student");
                        return;
                    }
                    int Class1 = Int32.Parse(textBoxClass1.Text);
                    int Class2 = Int32.Parse(textBoxClass2.Text);
                    int Class3 = Int32.Parse(textBoxClass3.Text);
                    int Class4 = Int32.Parse(textBoxClass4.Text);
                    int Class5 = Int32.Parse(textBoxClass5.Text);
                    Student student = new Student()
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
                    context.Students.Load();
                    context.Students.Add(student);
                    context.SaveChanges();
                }
                this.Close();
            }
            else {
                MessageBox.Show("Please input BOTH first and last name");
                return;
            }
        }
    }
}
