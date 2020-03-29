namespace ProjectTeam09
{
    partial class ProfessorModifyGradesForm
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
            this.dataGridViewProfGrades = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProfGrades)).BeginInit();
            this.SuspendLayout();
            // 
            // labelStudent
            // 
            this.labelStudent.AutoSize = true;
            this.labelStudent.Location = new System.Drawing.Point(454, 112);
            this.labelStudent.Name = "labelStudent";
            this.labelStudent.Size = new System.Drawing.Size(114, 32);
            this.labelStudent.TabIndex = 0;
            this.labelStudent.Text = "Student";
            // 
            // dataGridViewProfGrades
            // 
            this.dataGridViewProfGrades.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewProfGrades.Location = new System.Drawing.Point(31, 173);
            this.dataGridViewProfGrades.Name = "dataGridViewProfGrades";
            this.dataGridViewProfGrades.RowHeadersWidth = 102;
            this.dataGridViewProfGrades.RowTemplate.Height = 40;
            this.dataGridViewProfGrades.Size = new System.Drawing.Size(1020, 441);
            this.dataGridViewProfGrades.TabIndex = 1;
            // 
            // ProfessorModifyGradesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1076, 665);
            this.Controls.Add(this.dataGridViewProfGrades);
            this.Controls.Add(this.labelStudent);
            this.Name = "ProfessorModifyGradesForm";
            this.Text = "ProfessorModifyGradesForm";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProfGrades)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelStudent;
        private System.Windows.Forms.DataGridView dataGridViewProfGrades;
    }
}