﻿using System;
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
    public partial class ProfessorModifyGradesForm : Form
    {
        public int CourseID { get; set; }
        public StudentDirectory context = new StudentDirectory();
        public ProfessorModifyGradesForm(int courseid)
        {
            InitializeComponent();
            CourseID = courseid;
            InitializeForm();
            buttonModifyGrades.Click += ButtonModifyGrades_Click;
            buttonAddNewGrade.Click += ButtonAddNewGrade_Click;
        }

        /// <summary>
        /// Allows user to add a new grade to the database.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonAddNewGrade_Click(object sender, EventArgs e)
        {
            ProfessorAddGradeForm contentForm = new ProfessorAddGradeForm(CourseID);
            contentForm.Show();
            this.Close();
            
        }

        /// <summary>
        /// Saves any changes done on the datagrid and refreshes it.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonModifyGrades_Click(object sender, EventArgs e)
        {
            context.SaveChanges();
            MessageBox.Show("Changes saved.");
            dataGridViewProfGrades.Refresh();
            
        }
        /*
        private void ButtonViewGrades_Click(object sender, EventArgs e)
        {

            dataGridViewProfGrades.Rows.Clear();
            var queryFilterAssignment = from filterGrade in context.Grades
                                        where filterGrade.Assignment == listBoxAssignments.SelectedItem.ToString()
                                        select filterGrade;

            var queryDataGrid = from grades in context.Grades
                                from student in context.Students
                                where grades.CourseId == CourseID
                                where grades.Assignment == listBoxAssignments.SelectedItem.ToString()
                                select new
                                {
                                    Grade = grades.Grade1,
                                    StudentID = student.StudentId,
                                    StudentFirstName = student.FirstName,
                                    StudentLastName = student.LastName,
                                };
                foreach (var s in queryDataGrid)
                {
                    foreach (var h in queryFilterAssignment)
                    {
                        if (s.StudentID != h.StudentId)
                        {
                            dataGridViewProfGrades.Rows.Add(new string[] { s.StudentFirstName + " " + s.StudentLastName, "-" });

                        }

                        else
                        {
                            dataGridViewProfGrades.Rows.Add(new string[] { s.StudentFirstName + " " + s.StudentLastName, s.Grade.ToString() });

                        }
                    }
                }
            }
            */
        
        /// <summary>
        /// Initializes datagrid based on the selected class. Filters only through grades associated with the class.
        /// </summary>
        private void InitializeForm()
        {
            context.Students.Load();
            context.Courses.Load();
            context.Grades.Load();

            dataGridViewProfGrades.AllowUserToDeleteRows = true;
            dataGridViewProfGrades.AllowUserToAddRows = true;
            dataGridViewProfGrades.AllowUserToOrderColumns = true;

            dataGridViewProfGrades.DataSource = context.Grades.OrderBy(s => s.Assignment).Where(s => s.CourseId == CourseID).ToList();

        }
    }
}
