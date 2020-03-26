namespace ProjectTeam09
{
    partial class StudentGradesForm
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
            this.labelGradeStudent = new System.Windows.Forms.Label();
            this.labelClass1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelGradeStudent
            // 
            this.labelGradeStudent.AutoSize = true;
            this.labelGradeStudent.Location = new System.Drawing.Point(290, 64);
            this.labelGradeStudent.Name = "labelGradeStudent";
            this.labelGradeStudent.Size = new System.Drawing.Size(114, 32);
            this.labelGradeStudent.TabIndex = 0;
            this.labelGradeStudent.Text = "Student";
            // 
            // labelClass1
            // 
            this.labelClass1.AutoSize = true;
            this.labelClass1.Location = new System.Drawing.Point(68, 156);
            this.labelClass1.Name = "labelClass1";
            this.labelClass1.Size = new System.Drawing.Size(102, 32);
            this.labelClass1.TabIndex = 1;
            this.labelClass1.Text = "Class1";
            // 
            // StudentGradesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(726, 700);
            this.Controls.Add(this.labelClass1);
            this.Controls.Add(this.labelGradeStudent);
            this.Name = "StudentGradesForm";
            this.Text = "StudentGradesForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelGradeStudent;
        private System.Windows.Forms.Label labelClass1;
    }
}