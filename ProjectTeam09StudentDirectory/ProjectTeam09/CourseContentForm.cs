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
    public partial class CourseContentForm : Form
    {/// <summary>
    /// Looks up the path from the database and loads the files.
    /// </summary>
    /// <param name="path"></param>
        public CourseContentForm(string path)
        {
            
            InitializeComponent();
            buttonBack.Click += ButtonBack_Click;
            webBrowserContent.Url = new Uri(System.IO.Path.GetFullPath(Application.StartupPath + path));
        }
        /// <summary>
        /// Closes the window.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonBack_Click(object sender, EventArgs e)
        {
            
            this.Dispose();
            this.Hide();
        }
    }
}
