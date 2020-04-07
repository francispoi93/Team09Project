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
            InitializeComponent();
            dataGridViewProfessors.MultiSelect = false;
            dataGridViewStudents.MultiSelect = false;
            dataGridViewAdmins.MultiSelect = false;
            context.Students.Load();
            context.Professors.Load();
            InitializeStudentGridView();
            InitializeProfessorGridView();
            buttonAddUser.Click += ButtonAddUser_Click;
            buttonModifyUser.Click += ButtonModifyUser_Click;
            dataGridViewAdmins.SelectionChanged += (s, e) => ClearOtherSelections();
            dataGridViewProfessors.SelectionChanged += (s, e) => ClearOtherSelections();
            dataGridViewStudents.SelectionChanged += (s, e) => ClearOtherSelections();
        }
        private void ClearOtherSelections() {
            if (dataGridViewProfessors.SelectedRows.Count != 0)
            {
                dataGridViewAdmins.ClearSelection();
                dataGridViewStudents.ClearSelection();
            }          
            if (dataGridViewStudents.SelectedRows.Count != 0)
            {
                dataGridViewAdmins.ClearSelection();
                dataGridViewProfessors.ClearSelection();
            }        
            if (dataGridViewAdmins.SelectedRows.Count != 0)
            {
                dataGridViewStudents.ClearSelection();
                dataGridViewProfessors.ClearSelection();
            }
        }
        private void InitializeStudentGridView() {
            if (context.Students != null) {
                context.Students.Load();
                dataGridViewStudents.DataSource = context.Students.Local.ToBindingList();
            }
        }
        private void InitializeProfessorGridView() {
            if (context.Professors != null)
            {
                dataGridViewProfessors.DataSource = context.Professors.Local.ToBindingList();
            }
        }

        private void ButtonModifyUser_Click(object sender, EventArgs e)
        {
            if (dataGridViewProfessors.SelectedRows.Count != 0)
            {
                AdminModifyForm adminModifyForm = new AdminModifyForm(dataGridViewProfessors.SelectedRows.ToString());
            }
            if (dataGridViewStudents.SelectedRows.Count != 0)
            {
                AdminModifyForm adminModifyForm = new AdminModifyForm(dataGridViewStudents.SelectedRows.ToString());
            }
            if (dataGridViewAdmins.SelectedRows.Count != 0)
            {
                AdminModifyForm adminModifyForm = new AdminModifyForm(dataGridViewStudents.SelectedRows.ToString());
            }
        }
        private void ButtonAddUser_Click(object sender, EventArgs e)
        {
            AdminAddForm adminAddForm = new AdminAddForm();   
        }
    }
}
