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
    public partial class AdminMainForm : Form
    {
        public StudentDirectory context = new StudentDirectory();
        public AdminMainForm(int userId)
        {
            InitializeComponent();
            //make it so that if student is selected and search is blank takes to student main, same with prof
            buttonAddCourse.Click += (s,e) => AddCourse();
            buttonSearch.Click += (s,e) => IdView(userId);
            buttonBackupXML.Click += (s, e) => BackupDataSetToXML();
            buttonAddUser.Click += (s,e) => AddUser();
        }
        public void BackupDataSetToXML()
        {
            
        }
        public void AddUser() 
        {
            AdminAddUser addUser = new AdminAddUser();
            addUser.Show();
        }
        public void AddCourse() 
        {
            AdminAddCourse addCourse = new AdminAddCourse();
            addCourse.Show();
        }
        public void IdView(int userId)
        {
            int viewId = new int();
            try
            {
                viewId = Int32.Parse(textBoxUserID.Text);
                if (1999 < viewId && viewId< 2999) {
                    StudentMainForm studentMainForm = new StudentMainForm(viewId);
                    studentMainForm.Show();
                }
                else if (2999 < viewId && viewId < 3999)
                {
                   ProfessorMainForm professorMainForm = new ProfessorMainForm(viewId);
                    professorMainForm.Show();
                }
                else {
                    MessageBox.Show("Id view unavailable");
                }
            }
            catch
            {
                MessageBox.Show("Please enter a number");
            }
        }
    }
}
