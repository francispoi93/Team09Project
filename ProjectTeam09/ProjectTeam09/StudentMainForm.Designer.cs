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
            this.dataGridViewRegisteredCourses = new System.Windows.Forms.DataGridView();
            this.dataGridViewAvailableCourses = new System.Windows.Forms.DataGridView();
            this.buttonDropCourse = new System.Windows.Forms.Button();
            this.buttonRegisterCourse = new System.Windows.Forms.Button();
            this.buttonShowGrades = new System.Windows.Forms.Button();
            this.buttonShowContent = new System.Windows.Forms.Button();
            this.buttonEditPersonalInfo = new System.Windows.Forms.Button();
            this.dataGridViewStudentView = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewRegisteredCourses)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAvailableCourses)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewStudentView)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewRegisteredCourses
            // 
            this.dataGridViewRegisteredCourses.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewRegisteredCourses.Location = new System.Drawing.Point(84, 841);
            this.dataGridViewRegisteredCourses.Name = "dataGridViewRegisteredCourses";
            this.dataGridViewRegisteredCourses.RowHeadersWidth = 102;
            this.dataGridViewRegisteredCourses.RowTemplate.Height = 40;
            this.dataGridViewRegisteredCourses.Size = new System.Drawing.Size(902, 204);
            this.dataGridViewRegisteredCourses.TabIndex = 0;
            // 
            // dataGridViewAvailableCourses
            // 
            this.dataGridViewAvailableCourses.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewAvailableCourses.Location = new System.Drawing.Point(84, 423);
            this.dataGridViewAvailableCourses.Name = "dataGridViewAvailableCourses";
            this.dataGridViewAvailableCourses.RowHeadersWidth = 102;
            this.dataGridViewAvailableCourses.RowTemplate.Height = 40;
            this.dataGridViewAvailableCourses.Size = new System.Drawing.Size(402, 363);
            this.dataGridViewAvailableCourses.TabIndex = 1;
            // 
            // buttonDropCourse
            // 
            this.buttonDropCourse.Location = new System.Drawing.Point(677, 670);
            this.buttonDropCourse.Name = "buttonDropCourse";
            this.buttonDropCourse.Size = new System.Drawing.Size(114, 45);
            this.buttonDropCourse.TabIndex = 2;
            this.buttonDropCourse.Text = "Drop";
            this.buttonDropCourse.UseVisualStyleBackColor = true;
            // 
            // buttonRegisterCourse
            // 
            this.buttonRegisterCourse.Location = new System.Drawing.Point(653, 453);
            this.buttonRegisterCourse.Name = "buttonRegisterCourse";
            this.buttonRegisterCourse.Size = new System.Drawing.Size(166, 51);
            this.buttonRegisterCourse.TabIndex = 3;
            this.buttonRegisterCourse.Text = "Register";
            this.buttonRegisterCourse.UseVisualStyleBackColor = true;
            // 
            // buttonShowGrades
            // 
            this.buttonShowGrades.Location = new System.Drawing.Point(574, 296);
            this.buttonShowGrades.Name = "buttonShowGrades";
            this.buttonShowGrades.Size = new System.Drawing.Size(317, 49);
            this.buttonShowGrades.TabIndex = 4;
            this.buttonShowGrades.Text = "Show Student Grades";
            this.buttonShowGrades.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonShowGrades.UseVisualStyleBackColor = true;
            // 
            // buttonShowContent
            // 
            this.buttonShowContent.Location = new System.Drawing.Point(591, 563);
            this.buttonShowContent.Name = "buttonShowContent";
            this.buttonShowContent.Size = new System.Drawing.Size(317, 51);
            this.buttonShowContent.TabIndex = 5;
            this.buttonShowContent.Text = "Show Course Content";
            this.buttonShowContent.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonShowContent.UseVisualStyleBackColor = true;
            // 
            // buttonEditPersonalInfo
            // 
            this.buttonEditPersonalInfo.Location = new System.Drawing.Point(74, 278);
            this.buttonEditPersonalInfo.Name = "buttonEditPersonalInfo";
            this.buttonEditPersonalInfo.Size = new System.Drawing.Size(370, 67);
            this.buttonEditPersonalInfo.TabIndex = 6;
            this.buttonEditPersonalInfo.Text = "Edit Personal Information";
            this.buttonEditPersonalInfo.UseVisualStyleBackColor = true;
            // 
            // dataGridViewStudentView
            // 
            this.dataGridViewStudentView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewStudentView.Location = new System.Drawing.Point(84, 52);
            this.dataGridViewStudentView.Name = "dataGridViewStudentView";
            this.dataGridViewStudentView.RowHeadersWidth = 102;
            this.dataGridViewStudentView.RowTemplate.Height = 40;
            this.dataGridViewStudentView.Size = new System.Drawing.Size(824, 173);
            this.dataGridViewStudentView.TabIndex = 7;
            // 
            // StudentMainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1082, 1092);
            this.Controls.Add(this.dataGridViewStudentView);
            this.Controls.Add(this.buttonEditPersonalInfo);
            this.Controls.Add(this.buttonShowContent);
            this.Controls.Add(this.buttonShowGrades);
            this.Controls.Add(this.buttonRegisterCourse);
            this.Controls.Add(this.buttonDropCourse);
            this.Controls.Add(this.dataGridViewAvailableCourses);
            this.Controls.Add(this.dataGridViewRegisteredCourses);
            this.Name = "StudentMainForm";
            this.Text = "StudentMainForm";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewRegisteredCourses)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAvailableCourses)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewStudentView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewRegisteredCourses;
        private System.Windows.Forms.DataGridView dataGridViewAvailableCourses;
        private System.Windows.Forms.Button buttonDropCourse;
        private System.Windows.Forms.Button buttonRegisterCourse;
        private System.Windows.Forms.Button buttonShowGrades;
        private System.Windows.Forms.Button buttonShowContent;
        private System.Windows.Forms.Button buttonEditPersonalInfo;
        private System.Windows.Forms.DataGridView dataGridViewStudentView;
    }
}