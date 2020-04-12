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
    public partial class AdminAdminModifyForm : Form
    {
        StudentDirectory context = new StudentDirectory();
        public int AdminId { get; set; }
        public AdminAdminModifyForm(Admin modifyUser)
        {
            InitializeComponent();
            InitializeDisplays(modifyUser);
            buttonModify.Click +=(s,e) => ModifyCommit(modifyUser);
        }
        /// <summary>
        /// fills text boxes with current values of the user
        /// </summary>
        /// <param name="user"></param>
        public void InitializeDisplays(Admin user)
        {
            labelID.Text = user.AdminId.ToString();
            textBoxFirstName.Text = user.FirstName;
            textBoxLastName.Text = user.LastName;
        }
        /// <summary>
        /// modifies the user values based on what changes where made to the textboxes then saves changes
        /// </summary>
        /// <param name="admin"></param>
        public void ModifyCommit(Admin admin) {
            if (textBoxFirstName.Text != "" && textBoxLastName.Text != "")
            {
                admin.FirstName = textBoxFirstName.Text;
                admin.LastName = textBoxLastName.Text;
            }
            try
            {
                context.SaveChanges();
                AdminId = admin.AdminId;
                context.Dispose();
                this.Close();
            }
            catch (Exception exception)
            {
                MessageBox.Show("An error has occured when updating this Admin. " + exception);
            }
        }
    }
}
