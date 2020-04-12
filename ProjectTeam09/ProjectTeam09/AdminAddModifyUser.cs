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
            dataGridViewAdmins.ReadOnly = true;
            dataGridViewProfessors.ReadOnly = true;
            dataGridViewStudents.ReadOnly = true;
            InitializeStudentGridView();
            InitializeProfessorGridView();
            InitializeAdminGridView();
            buttonAddUser.Click += ButtonAddUser_Click;
            buttonModifyUser.Click += ButtonModifyUser_Click;
            dataGridViewAdmins.SelectionChanged += (s, e) => ClearOtherSelections();
            dataGridViewProfessors.SelectionChanged += (s, e) => ClearOtherSelections();
            dataGridViewStudents.SelectionChanged += (s, e) => ClearOtherSelections();
        }
        /// <summary>
        /// makes sure that only one datagridview value is selected at a time
        /// </summary>
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
        /// <summary>
        /// intitializes student datagridview
        /// </summary>
        private void InitializeStudentGridView() {
            if (context.Students != null) {
                context.Students.Load();
                dataGridViewStudents.DataSource = context.Students.Local.ToBindingList();
            }
        }
        /// <summary>
        /// initializes professor datagridview
        /// </summary>
        private void InitializeProfessorGridView() {
            if (context.Professors != null)
            {
                context.Professors.Load();
                dataGridViewProfessors.DataSource = context.Professors.Local.ToBindingList();
            }
        }
        /// <summary>
        /// intializes the admin datagridview
        /// </summary>
        private void InitializeAdminGridView() {
            if (context.Admin != null) {
                context.Admin.Load();
                dataGridViewAdmins.DataSource = context.Admin.Local.ToBindingList();
            }
        }
        private void ButtonModifyUser_Click(object sender, EventArgs e)
        {
            //checks if there is a professor selected
            if (dataGridViewProfessors.SelectedRows.Count != 0)
            {
                foreach (DataGridViewRow row in dataGridViewProfessors.SelectedRows)
                {
                    //modifies the selected professor
                    AdminProfessorModify professorsModifyForm = new AdminProfessorModify(row.DataBoundItem as Professor);
                    professorsModifyForm.ShowDialog();
                    context.Professors.Load();
                    //this is mostly for testing
                    if (professorsModifyForm.ProfessorId >= 0)
                    {
                        var entity = context.Professors.Find(professorsModifyForm.ProfessorId);
//                        if (entity != null)
//                           context.Entry(entity).Reload();
                    }
                    //refreshes the view and saves
                    dataGridViewProfessors.Refresh();
                    context.SaveChanges();
                    return;
                }
            }
            //checks if its a student selected
            if (dataGridViewStudents.SelectedRows.Count != 0)
            {
                foreach (DataGridViewRow row in dataGridViewStudents.SelectedRows)
                {
                    //loads student modify form
                    AdminStudentModify studentModiftyForm = new AdminStudentModify(row.DataBoundItem as Student);
                    studentModiftyForm.ShowDialog();
                    context.Students.Load();
                    //testing stuff
                    if (studentModiftyForm.StudentId >= 0)
                    {
                        var entity = context.Students.Find(studentModiftyForm.StudentId);
//                        if (entity != null)
//                            context.Entry(entity).Reload();
                    }
                    //refreshes view and saves changes
                    dataGridViewStudents.Refresh();
                    context.SaveChanges();
                    return;
                }
            }
            //checks if its an admin selected
            if (dataGridViewAdmins.SelectedRows.Count != 0)
            {
                foreach (DataGridViewRow row in dataGridViewAdmins.SelectedRows)
                { 
                    //generates modify form
                    AdminAdminModifyForm adminModifyForm = new AdminAdminModifyForm(row.DataBoundItem as Admin);
                    adminModifyForm.ShowDialog();
                    context.Admin.Load();
                    //testing stuff
                    if (adminModifyForm.AdminId >= 0)
                    {
                        var entity = context.Admin.Find(adminModifyForm.AdminId);
                        MessageBox.Show(entity.AdminId.ToString() + " " + entity.FirstName + " " + entity);
//                        if (entity != null)
//                            context.Entry(entity).Reload();
 
                    }
                    //refreshes view and saves changes
                    dataGridViewAdmins.Refresh();
                    context.SaveChanges();
                    return;
                }
            }
            MessageBox.Show("please make a proper selection");
        }
        /// <summary>
        /// generates the add form and refreshes views then saves
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonAddUser_Click(object sender, EventArgs e)
        {
            AdminAddForm adminAddForm = new AdminAddForm();
            adminAddForm.ShowDialog();
            context.Students.Load();
            context.Admin.Load();
            context.Professors.Load();
            //testing stuff
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
            //refreshes view after adding and saves changes
            dataGridViewStudents.Refresh();
            dataGridViewAdmins.Refresh();
            dataGridViewProfessors.Refresh();
            context.SaveChanges();
        }
    }
}
