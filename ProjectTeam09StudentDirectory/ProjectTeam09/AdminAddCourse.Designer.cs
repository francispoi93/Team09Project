namespace ProjectTeam09
{
    partial class AdminAddCourse
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
            this.textBoxCourseID = new System.Windows.Forms.TextBox();
            this.textBoxCourseName = new System.Windows.Forms.TextBox();
            this.labelCourseID = new System.Windows.Forms.Label();
            this.labelCourseName = new System.Windows.Forms.Label();
            this.labelClassSize = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxClassSize = new System.Windows.Forms.TextBox();
            this.textBoxClassProfessor = new System.Windows.Forms.TextBox();
            this.buttonCourseAdd = new System.Windows.Forms.Button();
            this.labelSection = new System.Windows.Forms.Label();
            this.textBoxCourseSection = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // textBoxCourseID
            // 
            this.textBoxCourseID.Location = new System.Drawing.Point(302, 32);
            this.textBoxCourseID.Name = "textBoxCourseID";
            this.textBoxCourseID.Size = new System.Drawing.Size(100, 38);
            this.textBoxCourseID.TabIndex = 0;
            // 
            // textBoxCourseName
            // 
            this.textBoxCourseName.Location = new System.Drawing.Point(302, 212);
            this.textBoxCourseName.Name = "textBoxCourseName";
            this.textBoxCourseName.Size = new System.Drawing.Size(100, 38);
            this.textBoxCourseName.TabIndex = 1;
            // 
            // labelCourseID
            // 
            this.labelCourseID.AutoSize = true;
            this.labelCourseID.Location = new System.Drawing.Point(29, 38);
            this.labelCourseID.Name = "labelCourseID";
            this.labelCourseID.Size = new System.Drawing.Size(140, 32);
            this.labelCourseID.TabIndex = 2;
            this.labelCourseID.Text = "Course ID";
            // 
            // labelCourseName
            // 
            this.labelCourseName.AutoSize = true;
            this.labelCourseName.Location = new System.Drawing.Point(29, 212);
            this.labelCourseName.Name = "labelCourseName";
            this.labelCourseName.Size = new System.Drawing.Size(188, 32);
            this.labelCourseName.TabIndex = 3;
            this.labelCourseName.Text = "Course Name";
            // 
            // labelClassSize
            // 
            this.labelClassSize.AutoSize = true;
            this.labelClassSize.Location = new System.Drawing.Point(29, 316);
            this.labelClassSize.Name = "labelClassSize";
            this.labelClassSize.Size = new System.Drawing.Size(149, 32);
            this.labelClassSize.TabIndex = 4;
            this.labelClassSize.Text = "Class Size";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 399);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(214, 32);
            this.label1.TabIndex = 5;
            this.label1.Text = "Class Professor";
            // 
            // textBoxClassSize
            // 
            this.textBoxClassSize.Location = new System.Drawing.Point(302, 299);
            this.textBoxClassSize.Name = "textBoxClassSize";
            this.textBoxClassSize.Size = new System.Drawing.Size(100, 38);
            this.textBoxClassSize.TabIndex = 6;
            // 
            // textBoxClassProfessor
            // 
            this.textBoxClassProfessor.Location = new System.Drawing.Point(302, 396);
            this.textBoxClassProfessor.Name = "textBoxClassProfessor";
            this.textBoxClassProfessor.Size = new System.Drawing.Size(100, 38);
            this.textBoxClassProfessor.TabIndex = 7;
            // 
            // buttonCourseAdd
            // 
            this.buttonCourseAdd.Location = new System.Drawing.Point(108, 487);
            this.buttonCourseAdd.Name = "buttonCourseAdd";
            this.buttonCourseAdd.Size = new System.Drawing.Size(186, 57);
            this.buttonCourseAdd.TabIndex = 8;
            this.buttonCourseAdd.Text = "Add Course";
            this.buttonCourseAdd.UseVisualStyleBackColor = true;
            // 
            // labelSection
            // 
            this.labelSection.AutoSize = true;
            this.labelSection.Location = new System.Drawing.Point(29, 131);
            this.labelSection.Name = "labelSection";
            this.labelSection.Size = new System.Drawing.Size(111, 32);
            this.labelSection.TabIndex = 9;
            this.labelSection.Text = "Section";
            // 
            // textBoxCourseSection
            // 
            this.textBoxCourseSection.Location = new System.Drawing.Point(302, 128);
            this.textBoxCourseSection.Name = "textBoxCourseSection";
            this.textBoxCourseSection.Size = new System.Drawing.Size(100, 38);
            this.textBoxCourseSection.TabIndex = 10;
            // 
            // AdminAddCourse
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(451, 601);
            this.Controls.Add(this.textBoxCourseSection);
            this.Controls.Add(this.labelSection);
            this.Controls.Add(this.buttonCourseAdd);
            this.Controls.Add(this.textBoxClassProfessor);
            this.Controls.Add(this.textBoxClassSize);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labelClassSize);
            this.Controls.Add(this.labelCourseName);
            this.Controls.Add(this.labelCourseID);
            this.Controls.Add(this.textBoxCourseName);
            this.Controls.Add(this.textBoxCourseID);
            this.Name = "AdminAddCourse";
            this.Text = "AdminAddCourse";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxCourseID;
        private System.Windows.Forms.TextBox textBoxCourseName;
        private System.Windows.Forms.Label labelCourseID;
        private System.Windows.Forms.Label labelCourseName;
        private System.Windows.Forms.Label labelClassSize;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxClassSize;
        private System.Windows.Forms.TextBox textBoxClassProfessor;
        private System.Windows.Forms.Button buttonCourseAdd;
        private System.Windows.Forms.Label labelSection;
        private System.Windows.Forms.TextBox textBoxCourseSection;
    }
}