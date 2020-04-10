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
    public partial class AdminProfessorModify : Form
    {
        StudentDirectory context = new StudentDirectory();
        public int ProfessorId { get; set; }
        public AdminProfessorModify(Professor professorModify)
        {
            InitializeComponent();
            InitializeDisplays(professorModify);
            buttonModify.Click += (s, e) => ModifyCommit(professorModify);
        }
        public void InitializeDisplays(Professor professor)
        {
            labelID.Text = professor.ProfessorId.ToString();
            textBoxFirstName.Text = professor.FirstName.ToString();
            textBoxLastName.Text = professor.LastName.ToString();
            textBoxClass1.Text = professor.Class1.ToString();
            textBoxClass2.Text = professor.Class2.ToString();
            textBoxClass3.Text = professor.Class3.ToString();
            textBoxClass4.Text = professor.Class4.ToString();
            textBoxClass5.Text = professor.Class5.ToString();
        }
        public void ModifyCommit(Professor professor) {
            try
            { 
                professor.FirstName = textBoxFirstName.Text; 
                professor.LastName = textBoxLastName.Text;
                TestTextBox(textBoxClass1, professor.Class1);
                TestTextBox(textBoxClass2, professor.Class2);
                TestTextBox(textBoxClass3, professor.Class3);
                TestTextBox(textBoxClass4, professor.Class4);
                TestTextBox(textBoxClass5, professor.Class5);

                context.SaveChanges();
                ProfessorId = professor.ProfessorId;
                context.Dispose();
                this.Close();
            }
            catch (Exception exception)
            {
                MessageBox.Show("An error has occured when updating this Professor. " + exception);
            }
        }
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
