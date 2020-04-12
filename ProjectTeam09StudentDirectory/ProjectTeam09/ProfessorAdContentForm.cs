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
    public partial class ProfessorAdContentForm : Form
    {
        /// <summary>
        /// Loads the path from the databse with the files. Professor can drag and drop items into the path.
        /// </summary>
        /// <param name="path"></param>
        public ProfessorAdContentForm(string path)
        {
            InitializeComponent();
            webBrowserStudentGrades.Url = new Uri(System.IO.Path.GetFullPath(Application.StartupPath + path));
        }
    }
}
