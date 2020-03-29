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
            this.labelClassGrades = new System.Windows.Forms.Label();
            this.dataGridViewStudentGrades = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewStudentGrades)).BeginInit();
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
            // labelClassGrades
            // 
            this.labelClassGrades.AutoSize = true;
            this.labelClassGrades.Location = new System.Drawing.Point(68, 156);
            this.labelClassGrades.Name = "labelClassGrades";
            this.labelClassGrades.Size = new System.Drawing.Size(164, 32);
            this.labelClassGrades.TabIndex = 1;
            this.labelClassGrades.Text = "Class name";
            // 
            // dataGridViewStudentGrades
            // 
            this.dataGridViewStudentGrades.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewStudentGrades.Location = new System.Drawing.Point(74, 247);
            this.dataGridViewStudentGrades.Name = "dataGridViewStudentGrades";
            this.dataGridViewStudentGrades.RowHeadersWidth = 102;
            this.dataGridViewStudentGrades.RowTemplate.Height = 40;
            this.dataGridViewStudentGrades.Size = new System.Drawing.Size(559, 414);
            this.dataGridViewStudentGrades.TabIndex = 2;
            // 
            // StudentGradesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(726, 700);
            this.Controls.Add(this.dataGridViewStudentGrades);
            this.Controls.Add(this.labelClassGrades);
            this.Controls.Add(this.labelGradeStudent);
            this.Name = "StudentGradesForm";
            this.Text = "StudentGradesForm";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewStudentGrades)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelGradeStudent;
        private System.Windows.Forms.Label labelClassGrades;
        private System.Windows.Forms.DataGridView dataGridViewStudentGrades;
    }
}