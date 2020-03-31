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
    public partial class LoginForm : Form
    {
        private StudentDirectory context;
        public LoginForm()
        {
            context = new StudentDirectory();
            InitializeComponent();
            buttonLoginSignIn.Click += (s, e) => login(textBoxLoginUsername.Text, textBoxLoginPassword.Text);
        }

        public void login(string inputID, string inputPass)
        {
            // Data has been added to UserCredentials for testing, permissions set as R = read, W = write, U=update, users 1000, 2000, 3000 added
            // passwords being admin, student, and professor respectively
            int userID = new int();
            try {
                userID = Int32.Parse(inputID);
                LoginInitialization(userID);
            } catch {
                MessageBox.Show("your input for ID is in an improper format");

                //bool usercheck = context.UserCredentials.UserID.contains(userID);
                /*var databasePassword =
                    from n in context.UserCredentials
                    where n.UserID = userID
                    select n.Password;
                bool passcheck = databasePassword == inputPass;
                if (passcheck && usercheck) 
                {
                    LoginInitialization(userID);
                }else{
                    MessageBox.show(your password and Id do not match);
                }
                */
            }
        }
        public void LoginInitialization(int userId)
        {
            AdminMainForm adminForm = new AdminMainForm();
            StudentMainForm studentForm = new StudentMainForm(userId);
            ProfessorMainForm professorForm = new ProfessorMainForm();
            if (999 < userId && userId < 1999)
            {
                adminForm.Show();
            }
            if (1999 < userId && userId < 2999) 
            {
                studentForm.Show();
            }
            if (2999 < userId && userId < 3999) 
            {
                professorForm.Show();
            }
        }
    }
}
