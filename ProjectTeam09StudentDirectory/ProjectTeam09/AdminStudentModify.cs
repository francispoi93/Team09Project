﻿using System;
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
    public partial class AdminStudentModify : Form
    {
        StudentDirectory context = new StudentDirectory();
        public int StudentId { get; set; }
        public AdminStudentModify(Student studentModify)
        {
            InitializeComponent();
            InitializeDisplays(studentModify);
            buttonModify.Click += (s, e) => modifyCommit(studentModify);
        }
        /// <summary>
        /// initializes text boxes based on the values of the user
        /// </summary>
        /// <param name="student"></param>
        public void InitializeDisplays(Student student)
        {
            labelID.Text = student.StudentId.ToString();
            textBoxFirstName.Text = student.FirstName.ToString();
            textBoxLastName.Text = student.LastName.ToString();
            textBoxClass1.Text = student.Class1.ToString();
            textBoxClass2.Text = student.Class2.ToString();
            textBoxClass3.Text = student.Class3.ToString();
            textBoxClass4.Text = student.Class4.ToString();
            textBoxClass5.Text = student.Class5.ToString();
        }
        /// <summary>
        /// modifies user based on the changes to the text boxes then saves changes
        /// </summary>
        /// <param name="student"></param>
        public void modifyCommit(Student student)
        {
            student.FirstName = textBoxFirstName.Text;
            student.LastName = textBoxLastName.Text;
            TestTextBox(textBoxClass1,student.Class1);
            TestTextBox(textBoxClass2,student.Class2);
            TestTextBox(textBoxClass3,student.Class3);
            TestTextBox(textBoxClass4,student.Class4);
            TestTextBox(textBoxClass5,student.Class5);
            try 
            {
                context.SaveChanges();
                StudentId = student.StudentId;
                context.Dispose();
                this.Close();
            }
            catch (Exception exception)
            {
                MessageBox.Show("An error has occured when updating this Professor. " + exception);
            }
        }
        /// <summary>
        /// assigns values and checks if the text box has a value
        /// </summary>
        /// <param name="textBox"></param>
        /// <param name="classId"></param>
        private void TestTextBox(TextBox textBox, int? classId)
        {
            if (textBox.Text != "")
            {
                try
                {
                    classId = int.Parse(textBox.Text);
                }
                catch 
                {
                    MessageBox.Show("please enter a proper classID");
                }
            }
        }
    }
}
