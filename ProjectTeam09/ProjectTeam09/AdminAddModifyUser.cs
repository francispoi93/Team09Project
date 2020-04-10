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
            InitializeStudentGridView();
            InitializeProfessorGridView();
            InitializeAdminGridView();
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
                context.Professors.Load();
                dataGridViewProfessors.DataSource = context.Professors.Local.ToBindingList();
            }
        }
        private void InitializeAdminGridView() {
            if (context.Admin != null) {
                context.Admin.Load();
                dataGridViewAdmins.DataSource = context.Admin.Local.ToBindingList();
            }
        }
        private void ButtonModifyUser_Click(object sender, EventArgs e)
        {
            if (dataGridViewProfessors.SelectedRows.Count != 0)
            {
                foreach (DataGridViewRow row in dataGridViewProfessors.SelectedRows)
                {
                    AdminProfessorModify professorsModifyForm = new AdminProfessorModify(row.DataBoundItem as Professor);
                    professorsModifyForm.ShowDialog();
                    context.Professors.Load();
                    if (professorsModifyForm.ProfessorId >= 0)
                    {
                        var entity = context.Professors.Find(professorsModifyForm.ProfessorId);
                        if (entity != null)
                            context.Entry(entity).Reload();
                    }
                    dataGridViewProfessors.Refresh();
                    context.SaveChanges();
                    return;
                }
            }
            if (dataGridViewStudents.SelectedRows.Count != 0)
            {
                foreach (DataGridViewRow row in dataGridViewStudents.SelectedRows)
                {
                    AdminStudentModify studentModiftyForm = new AdminStudentModify(row.DataBoundItem as Student);
                    studentModiftyForm.ShowDialog();
                    if (studentModiftyForm.StudentId >= 0)
                    {
                        var entity = context.Students.Find(studentModiftyForm.StudentId);
                        if (entity != null)
                            context.Entry(entity).Reload();
                    }
                    dataGridViewStudents.Refresh();
                    context.SaveChanges();
                    return;
                }
            }
            if (dataGridViewAdmins.SelectedRows.Count != 0)
            {
                foreach (DataGridViewRow row in dataGridViewAdmins.SelectedRows)
                { 
                    AdminAdminModifyForm adminModifyForm = new AdminAdminModifyForm(row.DataBoundItem as Admin);
                    adminModifyForm.ShowDialog();
                    if (adminModifyForm.AdminId >= 0)
                    {
                        var entity = context.Admin.Find(adminModifyForm.AdminId);
                        if (entity != null)
                            context.Entry(entity).Reload();
                    }
                    dataGridViewAdmins.Refresh();
                    context.SaveChanges();
                    return;
                }

            }
            MessageBox.Show("please make a proper selection");
        }
        private void ButtonAddUser_Click(object sender, EventArgs e)
        {
            AdminAddForm adminAddForm = new AdminAddForm();
            adminAddForm.ShowDialog();
            context.Students.Load();
            context.Admin.Load();
            context.Professors.Load();
            if (adminAddForm.StudentID >= 0)
            {
                var entity = context.Students.Find(adminAddForm.StudentID);
                if (entity != null)
                    context.Entry(entity).Reload();
            }     
            if (adminAddForm.ProfessorID >= 0)
            {
                var entity = context.Professors.Find(adminAddForm.StudentID);
                if (entity != null)
                    context.Entry(entity).Reload();
            }           
            if (adminAddForm.AdminID >= 0)
            {
                var entity = context.Admin.Find(adminAddForm.StudentID);
                if (entity != null)
                    context.Entry(entity).Reload();
            }
            dataGridViewStudents.Refresh();
            context.SaveChanges();
        }
    }
}
