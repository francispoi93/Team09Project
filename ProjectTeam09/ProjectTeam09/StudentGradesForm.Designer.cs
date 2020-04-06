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
            this.dataGridViewStudentGrades = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewStudentGrades)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewStudentGrades
            // 
            this.dataGridViewStudentGrades.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewStudentGrades.Location = new System.Drawing.Point(10, 10);
            this.dataGridViewStudentGrades.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.dataGridViewStudentGrades.Name = "dataGridViewStudentGrades";
            this.dataGridViewStudentGrades.RowHeadersWidth = 102;
            this.dataGridViewStudentGrades.RowTemplate.Height = 40;
            this.dataGridViewStudentGrades.Size = new System.Drawing.Size(728, 349);
            this.dataGridViewStudentGrades.TabIndex = 2;
            // 
            // StudentGradesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(795, 382);
            this.Controls.Add(this.dataGridViewStudentGrades);
            this.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.Name = "StudentGradesForm";
            this.Text = "StudentGradesForm";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewStudentGrades)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView dataGridViewStudentGrades;
    }
}