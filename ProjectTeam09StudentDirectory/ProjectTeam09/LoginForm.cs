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
using System.Data.Entity.Infrastructure;
using System.Data.Entity.Validation;

namespace ProjectTeam09
{
    public partial class LoginForm : Form
    {
        public int UserId { get; set; }
        public StudentDirectory context = new StudentDirectory();
        /// <summary>
        /// just a basic initialization
        /// </summary>
        public LoginForm()
        {
            context.UserCredentials.Load();
            InitializeComponent();
            buttonLoginSignIn.Click += (s, e) => login(textBoxLoginUsername.Text, textBoxLoginPassword.Text);
        }

        public void login(string inputID, string inputPass)
        {
            // Data has been added to UserCredentials for testing, permissions set as R = read, W = write, U=update, users 1000, 2000, 3000 added
            // passwords being admin, student, and professor respectively
            //bypasses login screen to admin main
            if (inputID=="admin") {
                AdminMainForm adminMainForm = new AdminMainForm(1000);
                adminMainForm.Show();
                return;
            }
            //bypasses login screen to professor main
            if (inputID == "professor")
            {
                ProfessorMainForm professorForm = new ProfessorMainForm(3000);
                professorForm.Show();
                return;
            }
            //bypasses login screen to student main
            if (inputID == "student")
            {
                StudentMainForm studentForm = new StudentMainForm(2000);
                studentForm.Show();
                return;
            }
            //gets id from text box input and makes sure it parses 
            int userID = new int();
            try
            {
                userID = Int32.Parse(inputID);
            }
            catch
            {
                MessageBox.Show("your input for ID is in an improper format");
                try
                {
                    var userid = context.UserCredentials.Find(userID);
                    if (userid.Password == inputPass)
                    {
                        LoginInitialization(userID);
                    }
                    else
                    {
                        MessageBox.Show("your password does not match the ID");
                    }
                }
                catch
                {
                    MessageBox.Show("your userId is not in the database");
                }


                return;

            }
            //if it doesnt get caught by the above statement then there must be something wrong,
            //this is determining the problem and displaying it
             UserCredential user = context.UserCredentials.Find(userID);
             if (user == null) {
                MessageBox.Show("UserID: " + userID + " is not in the database");
                return;
             }
             if (user.Password == inputPass)
             {
                 LoginInitialization(userID);
             }
             else
             {
                 MessageBox.Show("your password is incorrect real password is " + user.Password);
             }
        }
        /// <summary>
        /// recieves passed userID and displays appropriate form
        /// </summary>
        /// <param name="userId"></param>
        public void LoginInitialization(int userId)
        {
            if (999 < userId && userId < 1999)
            {
                MessageBox.Show("logging into admin");
                AdminMainForm adminForm = new AdminMainForm(userId);
                adminForm.Show();
            }
            if (1999 < userId && userId < 2999) 
            {
                MessageBox.Show("logging into student");
                StudentMainForm studentForm = new StudentMainForm(userId);
                studentForm.Show();
            }
            if (2999 < userId && userId < 3999) 
            {
                MessageBox.Show("logging into professor");
                ProfessorMainForm professorForm = new ProfessorMainForm(userId);
                professorForm.Show();
            }
        }
    }
}
