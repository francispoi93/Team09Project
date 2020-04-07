namespace ProjectTeam09
{
    partial class StudentMainForm
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
            this.dataGridViewAvailableCourses = new System.Windows.Forms.DataGridView();
            this.buttonDropCourse = new System.Windows.Forms.Button();
            this.buttonRegisterCourse = new System.Windows.Forms.Button();
            this.buttonShowGrades = new System.Windows.Forms.Button();
            this.buttonShowContent = new System.Windows.Forms.Button();
            this.buttonEditPersonalInfo = new System.Windows.Forms.Button();
            this.dataGridViewAvailable = new System.Windows.Forms.DataGridView();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.fileSystemWatcher1 = new System.IO.FileSystemWatcher();
            this.labelSelection = new System.Windows.Forms.Label();
            this.labelCurrentCourses = new System.Windows.Forms.Label();
            this.labelAvailableCourses = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAvailableCourses)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAvailable)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewAvailableCourses
            // 
            this.dataGridViewAvailableCourses.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewAvailableCourses.Location = new System.Drawing.Point(10, 241);
            this.dataGridViewAvailableCourses.Margin = new System.Windows.Forms.Padding(1);
            this.dataGridViewAvailableCourses.Name = "dataGridViewAvailableCourses";
            this.dataGridViewAvailableCourses.RowHeadersWidth = 102;
            this.dataGridViewAvailableCourses.RowTemplate.Height = 40;
            this.dataGridViewAvailableCourses.Size = new System.Drawing.Size(457, 152);
            this.dataGridViewAvailableCourses.TabIndex = 1;
            // 
            // buttonDropCourse
            // 
            this.buttonDropCourse.Location = new System.Drawing.Point(508, 100);
            this.buttonDropCourse.Margin = new System.Windows.Forms.Padding(1);
            this.buttonDropCourse.Name = "buttonDropCourse";
            this.buttonDropCourse.Size = new System.Drawing.Size(119, 34);
            this.buttonDropCourse.TabIndex = 2;
            this.buttonDropCourse.Text = "Drop Course";
            this.buttonDropCourse.UseVisualStyleBackColor = true;
            // 
            // buttonRegisterCourse
            // 
            this.buttonRegisterCourse.Location = new System.Drawing.Point(532, 301);
            this.buttonRegisterCourse.Margin = new System.Windows.Forms.Padding(1);
            this.buttonRegisterCourse.Name = "buttonRegisterCourse";
            this.buttonRegisterCourse.Size = new System.Drawing.Size(79, 31);
            this.buttonRegisterCourse.TabIndex = 3;
            this.buttonRegisterCourse.Text = "Register";
            this.buttonRegisterCourse.UseVisualStyleBackColor = true;
            // 
            // buttonShowGrades
            // 
            this.buttonShowGrades.Location = new System.Drawing.Point(508, 32);
            this.buttonShowGrades.Margin = new System.Windows.Forms.Padding(1);
            this.buttonShowGrades.Name = "buttonShowGrades";
            this.buttonShowGrades.Size = new System.Drawing.Size(119, 30);
            this.buttonShowGrades.TabIndex = 4;
            this.buttonShowGrades.Text = "Show Course Grades";
            this.buttonShowGrades.UseVisualStyleBackColor = true;
            // 
            // buttonShowContent
            // 
            this.buttonShowContent.Location = new System.Drawing.Point(508, 64);
            this.buttonShowContent.Margin = new System.Windows.Forms.Padding(1);
            this.buttonShowContent.Name = "buttonShowContent";
            this.buttonShowContent.Size = new System.Drawing.Size(119, 34);
            this.buttonShowContent.TabIndex = 5;
            this.buttonShowContent.Text = "Show Course Content";
            this.buttonShowContent.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonShowContent.UseVisualStyleBackColor = true;
            // 
            // buttonEditPersonalInfo
            // 
            this.buttonEditPersonalInfo.Location = new System.Drawing.Point(508, 417);
            this.buttonEditPersonalInfo.Margin = new System.Windows.Forms.Padding(1);
            this.buttonEditPersonalInfo.Name = "buttonEditPersonalInfo";
            this.buttonEditPersonalInfo.Size = new System.Drawing.Size(139, 28);
            this.buttonEditPersonalInfo.TabIndex = 6;
            this.buttonEditPersonalInfo.Text = "Edit Personal Information";
            this.buttonEditPersonalInfo.UseVisualStyleBackColor = true;
            // 
            // dataGridViewAvailable
            // 
            this.dataGridViewAvailable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewAvailable.Location = new System.Drawing.Point(10, 19);
            this.dataGridViewAvailable.Margin = new System.Windows.Forms.Padding(1);
            this.dataGridViewAvailable.Name = "dataGridViewAvailable";
            this.dataGridViewAvailable.RowHeadersWidth = 102;
            this.dataGridViewAvailable.RowTemplate.Height = 40;
            this.dataGridViewAvailable.Size = new System.Drawing.Size(469, 132);
            this.dataGridViewAvailable.TabIndex = 7;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // fileSystemWatcher1
            // 
            this.fileSystemWatcher1.EnableRaisingEvents = true;
            this.fileSystemWatcher1.SynchronizingObject = this;
            // 
            // labelSelection
            // 
            this.labelSelection.AutoSize = true;
            this.labelSelection.Location = new System.Drawing.Point(483, 5);
            this.labelSelection.Name = "labelSelection";
            this.labelSelection.Size = new System.Drawing.Size(209, 26);
            this.labelSelection.TabIndex = 8;
            this.labelSelection.Text = "Please select a class to look at your grade,\r\nlook at contents or drop the class";
            // 
            // labelCurrentCourses
            // 
            this.labelCurrentCourses.AutoSize = true;
            this.labelCurrentCourses.Location = new System.Drawing.Point(32, 5);
            this.labelCurrentCourses.Name = "labelCurrentCourses";
            this.labelCurrentCourses.Size = new System.Drawing.Size(82, 13);
            this.labelCurrentCourses.TabIndex = 9;
            this.labelCurrentCourses.Text = "Current Courses";
            // 
            // labelAvailableCourses
            // 
            this.labelAvailableCourses.AutoSize = true;
            this.labelAvailableCourses.Location = new System.Drawing.Point(29, 218);
            this.labelAvailableCourses.Name = "labelAvailableCourses";
            this.labelAvailableCourses.Size = new System.Drawing.Size(91, 13);
            this.labelAvailableCourses.TabIndex = 10;
            this.labelAvailableCourses.Text = "Available Courses";
            // 
            // StudentMainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(704, 511);
            this.Controls.Add(this.labelAvailableCourses);
            this.Controls.Add(this.labelCurrentCourses);
            this.Controls.Add(this.labelSelection);
            this.Controls.Add(this.dataGridViewAvailable);
            this.Controls.Add(this.buttonEditPersonalInfo);
            this.Controls.Add(this.buttonShowContent);
            this.Controls.Add(this.buttonShowGrades);
            this.Controls.Add(this.buttonRegisterCourse);
            this.Controls.Add(this.buttonDropCourse);
            this.Controls.Add(this.dataGridViewAvailableCourses);
            this.Margin = new System.Windows.Forms.Padding(1);
            this.Name = "StudentMainForm";
            this.Text = "StudentMainForm";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAvailableCourses)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAvailable)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dataGridViewAvailableCourses;
        private System.Windows.Forms.Button buttonDropCourse;
        private System.Windows.Forms.Button buttonRegisterCourse;
        private System.Windows.Forms.Button buttonShowGrades;
        private System.Windows.Forms.Button buttonShowContent;
        private System.Windows.Forms.Button buttonEditPersonalInfo;
        private System.Windows.Forms.DataGridView dataGridViewAvailable;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.IO.FileSystemWatcher fileSystemWatcher1;
        private System.Windows.Forms.Label labelSelection;
        private System.Windows.Forms.Label labelAvailableCourses;
        private System.Windows.Forms.Label labelCurrentCourses;
    }
}