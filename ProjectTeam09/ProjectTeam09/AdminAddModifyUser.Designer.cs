namespace ProjectTeam09
{
    partial class AdminAddUser
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
            this.dataGridViewStudents = new System.Windows.Forms.DataGridView();
            this.dataGridViewProfessors = new System.Windows.Forms.DataGridView();
            this.dataGridViewAdmins = new System.Windows.Forms.DataGridView();
            this.buttonAddUser = new System.Windows.Forms.Button();
            this.buttonModifyUser = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewStudents)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProfessors)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAdmins)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewStudents
            // 
            this.dataGridViewStudents.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewStudents.Location = new System.Drawing.Point(65, 59);
            this.dataGridViewStudents.Name = "dataGridViewStudents";
            this.dataGridViewStudents.RowHeadersWidth = 102;
            this.dataGridViewStudents.RowTemplate.Height = 40;
            this.dataGridViewStudents.Size = new System.Drawing.Size(668, 135);
            this.dataGridViewStudents.TabIndex = 0;
            // 
            // dataGridViewProfessors
            // 
            this.dataGridViewProfessors.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewProfessors.Location = new System.Drawing.Point(65, 232);
            this.dataGridViewProfessors.Name = "dataGridViewProfessors";
            this.dataGridViewProfessors.RowHeadersWidth = 102;
            this.dataGridViewProfessors.RowTemplate.Height = 40;
            this.dataGridViewProfessors.Size = new System.Drawing.Size(668, 135);
            this.dataGridViewProfessors.TabIndex = 1;
            // 
            // dataGridViewAdmins
            // 
            this.dataGridViewAdmins.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewAdmins.Location = new System.Drawing.Point(65, 412);
            this.dataGridViewAdmins.Name = "dataGridViewAdmins";
            this.dataGridViewAdmins.RowHeadersWidth = 102;
            this.dataGridViewAdmins.RowTemplate.Height = 40;
            this.dataGridViewAdmins.Size = new System.Drawing.Size(668, 135);
            this.dataGridViewAdmins.TabIndex = 2;
            // 
            // buttonAddUser
            // 
            this.buttonAddUser.Location = new System.Drawing.Point(465, 605);
            this.buttonAddUser.Name = "buttonAddUser";
            this.buttonAddUser.Size = new System.Drawing.Size(193, 55);
            this.buttonAddUser.TabIndex = 3;
            this.buttonAddUser.Text = "Add User";
            this.buttonAddUser.UseVisualStyleBackColor = true;
            // 
            // buttonModifyUser
            // 
            this.buttonModifyUser.Location = new System.Drawing.Point(150, 605);
            this.buttonModifyUser.Name = "buttonModifyUser";
            this.buttonModifyUser.Size = new System.Drawing.Size(209, 55);
            this.buttonModifyUser.TabIndex = 4;
            this.buttonModifyUser.Text = "Modify User";
            this.buttonModifyUser.UseVisualStyleBackColor = true;
            // 
            // AdminAddUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(809, 730);
            this.Controls.Add(this.buttonModifyUser);
            this.Controls.Add(this.buttonAddUser);
            this.Controls.Add(this.dataGridViewAdmins);
            this.Controls.Add(this.dataGridViewProfessors);
            this.Controls.Add(this.dataGridViewStudents);
            this.Name = "AdminAddUser";
            this.Text = "AdminAddUser";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewStudents)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProfessors)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAdmins)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewStudents;
        private System.Windows.Forms.DataGridView dataGridViewProfessors;
        private System.Windows.Forms.DataGridView dataGridViewAdmins;
        private System.Windows.Forms.Button buttonAddUser;
        private System.Windows.Forms.Button buttonModifyUser;
    }
}