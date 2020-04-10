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
        public ProfessorAdContentForm(string path)
        {
            InitializeComponent();
            webBrowserStudentGrades.Url = new Uri(System.IO.Path.GetFullPath(Application.StartupPath + path));
        }
    }
}
