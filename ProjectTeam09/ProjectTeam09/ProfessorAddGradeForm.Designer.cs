namespace ProjectTeam09
{
    partial class ProfessorAddGradeForm
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
            this.labelStudent = new System.Windows.Forms.Label();
            this.labelAssignment = new System.Windows.Forms.Label();
            this.labelGrade = new System.Windows.Forms.Label();
            this.listBoxStudent = new System.Windows.Forms.ListBox();
            this.textBoxAssignment = new System.Windows.Forms.TextBox();
            this.textBoxGrade = new System.Windows.Forms.TextBox();
            this.buttonAddGrade = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelStudent
            // 
            this.labelStudent.AutoSize = true;
            this.labelStudent.Location = new System.Drawing.Point(61, 34);
            this.labelStudent.Name = "labelStudent";
            this.labelStudent.Size = new System.Drawing.Size(58, 13);
            this.labelStudent.TabIndex = 0;
            this.labelStudent.Text = "Student ID";
            // 
            // labelAssignment
            // 
            this.labelAssignment.AutoSize = true;
            this.labelAssignment.Location = new System.Drawing.Point(61, 163);
            this.labelAssignment.Name = "labelAssignment";
            this.labelAssignment.Size = new System.Drawing.Size(61, 13);
            this.labelAssignment.TabIndex = 1;
            this.labelAssignment.Text = "Assignment";
            // 
            // labelGrade
            // 
            this.labelGrade.AutoSize = true;
            this.labelGrade.Location = new System.Drawing.Point(89, 221);
            this.labelGrade.Name = "labelGrade";
            this.labelGrade.Size = new System.Drawing.Size(36, 13);
            this.labelGrade.TabIndex = 2;
            this.labelGrade.Text = "Grade";
            // 
            // listBoxStudent
            // 
            this.listBoxStudent.FormattingEnabled = true;
            this.listBoxStudent.Location = new System.Drawing.Point(175, 12);
            this.listBoxStudent.Name = "listBoxStudent";
            this.listBoxStudent.Size = new System.Drawing.Size(120, 95);
            this.listBoxStudent.TabIndex = 3;
            // 
            // textBoxAssignment
            // 
            this.textBoxAssignment.Location = new System.Drawing.Point(175, 160);
            this.textBoxAssignment.Name = "textBoxAssignment";
            this.textBoxAssignment.Size = new System.Drawing.Size(100, 20);
            this.textBoxAssignment.TabIndex = 4;
            // 
            // textBoxGrade
            // 
            this.textBoxGrade.Location = new System.Drawing.Point(175, 214);
            this.textBoxGrade.Name = "textBoxGrade";
            this.textBoxGrade.Size = new System.Drawing.Size(100, 20);
            this.textBoxGrade.TabIndex = 5;
            // 
            // buttonAddGrade
            // 
            this.buttonAddGrade.Location = new System.Drawing.Point(338, 348);
            this.buttonAddGrade.Name = "buttonAddGrade";
            this.buttonAddGrade.Size = new System.Drawing.Size(169, 53);
            this.buttonAddGrade.TabIndex = 6;
            this.buttonAddGrade.Text = "Add Grade";
            this.buttonAddGrade.UseVisualStyleBackColor = true;
            // 
            // ProfessorAddGradeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonAddGrade);
            this.Controls.Add(this.textBoxGrade);
            this.Controls.Add(this.textBoxAssignment);
            this.Controls.Add(this.listBoxStudent);
            this.Controls.Add(this.labelGrade);
            this.Controls.Add(this.labelAssignment);
            this.Controls.Add(this.labelStudent);
            this.Name = "ProfessorAddGradeForm";
            this.Text = "ProfessorAddGradeForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelStudent;
        private System.Windows.Forms.Label labelAssignment;
        private System.Windows.Forms.Label labelGrade;
        private System.Windows.Forms.ListBox listBoxStudent;
        private System.Windows.Forms.TextBox textBoxAssignment;
        private System.Windows.Forms.TextBox textBoxGrade;
        private System.Windows.Forms.Button buttonAddGrade;
    }
}