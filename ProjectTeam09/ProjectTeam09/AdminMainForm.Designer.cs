namespace ProjectTeam09
{
    partial class AdminMainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.buttonBackupXML = new System.Windows.Forms.Button();
            this.textBoxUserID = new System.Windows.Forms.TextBox();
            this.buttonSearch = new System.Windows.Forms.Button();
            this.buttonAddCourse = new System.Windows.Forms.Button();
            this.labelUserID = new System.Windows.Forms.Label();
            this.buttonAddModifyUser = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonBackupXML
            // 
            this.buttonBackupXML.Location = new System.Drawing.Point(149, 377);
            this.buttonBackupXML.Name = "buttonBackupXML";
            this.buttonBackupXML.Size = new System.Drawing.Size(199, 105);
            this.buttonBackupXML.TabIndex = 0;
            this.buttonBackupXML.Text = "back up to XML";
            this.buttonBackupXML.UseVisualStyleBackColor = true;
            // 
            // textBoxUserID
            // 
            this.textBoxUserID.Location = new System.Drawing.Point(34, 138);
            this.textBoxUserID.Name = "textBoxUserID";
            this.textBoxUserID.Size = new System.Drawing.Size(198, 38);
            this.textBoxUserID.TabIndex = 3;
            // 
            // buttonSearch
            // 
            this.buttonSearch.Location = new System.Drawing.Point(300, 109);
            this.buttonSearch.Name = "buttonSearch";
            this.buttonSearch.Size = new System.Drawing.Size(160, 48);
            this.buttonSearch.TabIndex = 4;
            this.buttonSearch.Text = "Search";
            this.buttonSearch.UseVisualStyleBackColor = true;
            // 
            // buttonAddCourse
            // 
            this.buttonAddCourse.Location = new System.Drawing.Point(53, 240);
            this.buttonAddCourse.Name = "buttonAddCourse";
            this.buttonAddCourse.Size = new System.Drawing.Size(147, 96);
            this.buttonAddCourse.TabIndex = 5;
            this.buttonAddCourse.Text = "Add course";
            this.buttonAddCourse.UseVisualStyleBackColor = true;
            // 
            // labelUserID
            // 
            this.labelUserID.AutoSize = true;
            this.labelUserID.Location = new System.Drawing.Point(28, 89);
            this.labelUserID.Name = "labelUserID";
            this.labelUserID.Size = new System.Drawing.Size(108, 32);
            this.labelUserID.TabIndex = 6;
            this.labelUserID.Text = "User ID";
            // 
            // buttonAddModifyUser
            // 
            this.buttonAddModifyUser.Location = new System.Drawing.Point(254, 240);
            this.buttonAddModifyUser.Name = "buttonAddModifyUser";
            this.buttonAddModifyUser.Size = new System.Drawing.Size(206, 96);
            this.buttonAddModifyUser.TabIndex = 7;
            this.buttonAddModifyUser.Text = "Add/Modify User";
            this.buttonAddModifyUser.UseVisualStyleBackColor = true;
            // 
            // AdminMainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(506, 536);
            this.Controls.Add(this.buttonAddModifyUser);
            this.Controls.Add(this.labelUserID);
            this.Controls.Add(this.buttonAddCourse);
            this.Controls.Add(this.buttonSearch);
            this.Controls.Add(this.textBoxUserID);
            this.Controls.Add(this.buttonBackupXML);
            this.Name = "AdminMainForm";
            this.Text = "AdminMainForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonBackupXML;
        private System.Windows.Forms.TextBox textBoxUserID;
        private System.Windows.Forms.Button buttonSearch;
        private System.Windows.Forms.Button buttonAddCourse;
        private System.Windows.Forms.Label labelUserID;
        private System.Windows.Forms.Button buttonAddModifyUser;
    }
}