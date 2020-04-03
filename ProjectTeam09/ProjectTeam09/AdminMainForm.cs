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
    public partial class AdminMainForm : Form
    {
        public StudentDirectory context = new StudentDirectory();
        public AdminMainForm(int userId)
        {
            InitializeComponent();
            //make it so that if student is selected and search is blank takes to student main, same with prof
        }
        public void BackupDataSetToXML()
        {
            if (context == null)
            {
                return;
            }

            context. //(dataSet.DataSetName + ".xml", XmlWriteMode.WriteSchema);
        }
    }
}
