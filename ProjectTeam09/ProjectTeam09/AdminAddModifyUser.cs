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
    public partial class AdminAddUser : Form
    {
        StudentDirectory context = new StudentDirectory();
        public AdminAddUser()
        {
            context.Students.Load();
            context.Professors.Load();
            InitializeStudentGridView();
            InitializeProfessorGridView();
            InitializeComponent();
            buttonAddUser.Click += ButtonAddUser_Click;
            buttonModifyUser.Click += ButtonModifyUser_Click;
        }
        private void InitializeStudentGridView() {
            if (context.Students == null) {
                dataGridViewStudents.DataSource = context.Students;
            }
        }
        private void InitializeProfessorGridView() {
            if (context.Professors == null)
            {
                dataGridViewProfessors.DataSource = context.Professors;
            }
        }

        private void ButtonModifyUser_Click(object sender, EventArgs e)
        {

        }
        private void ButtonAddUser_Click(object sender, EventArgs e)
        {
            
        }
    }
}
