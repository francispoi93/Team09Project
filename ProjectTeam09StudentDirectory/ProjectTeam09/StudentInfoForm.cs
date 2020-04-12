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
    public partial class StudentInfoForm : Form
    {
        public int StudentID { get; set; }
        StudentDirectory context = new StudentDirectory();
        public StudentInfoForm(int userId)
        {
            StudentID = userId;
            InitializeComponent();
            InitializeForm();
            buttonUpdate.Click += ButtonUpdate_Click;
        }
        /// <summary>
        /// Find student ID based on login information, fills the information.
        /// </summary>
        private void InitializeForm()
        {
            context.Students.Load();
            var student = context.Students.Find(StudentID);
            labelFirstNameServer.Text = student.FirstName;
            labelLastNameServer.Text = student.LastName;
            textBoxEmail.Text = student.Email;
            textBoxPhone.Text = student.PhoneNumber;
        }
        /// <summary>
        /// Once user clicks update, the information is filled from the email and phone texts into the database. Error occurs if database can't update for some reason
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                var student = context.Students.Find(StudentID);
                student.Email = textBoxEmail.Text;
                student.PhoneNumber = textBoxPhone.Text;
                context.SaveChanges();
                this.Close();
                MessageBox.Show("Info successfully updated.");
            }
            catch
            {
                MessageBox.Show("An error has occured while trying to update. Please make sure that the phone number and email are correct.");
            }
        }
    }
}
