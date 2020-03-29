namespace ProjectTeam09
{
    partial class ProfessorMainForm
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
            this.buttonAddContent = new System.Windows.Forms.Button();
            this.dataGridViewStudents = new System.Windows.Forms.DataGridView();
            this.listBoxClasses = new System.Windows.Forms.ListBox();
            this.buttonGrades = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewStudents)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonAddContent
            // 
            this.buttonAddContent.Location = new System.Drawing.Point(392, 106);
            this.buttonAddContent.Name = "buttonAddContent";
            this.buttonAddContent.Size = new System.Drawing.Size(209, 46);
            this.buttonAddContent.TabIndex = 0;
            this.buttonAddContent.Text = "Add Content";
            this.buttonAddContent.UseVisualStyleBackColor = true;
            // 
            // dataGridViewStudents
            // 
            this.dataGridViewStudents.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewStudents.Location = new System.Drawing.Point(22, 291);
            this.dataGridViewStudents.Name = "dataGridViewStudents";
            this.dataGridViewStudents.RowHeadersWidth = 102;
            this.dataGridViewStudents.RowTemplate.Height = 40;
            this.dataGridViewStudents.Size = new System.Drawing.Size(690, 441);
            this.dataGridViewStudents.TabIndex = 1;
            // 
            // listBoxClasses
            // 
            this.listBoxClasses.FormattingEnabled = true;
            this.listBoxClasses.ItemHeight = 31;
            this.listBoxClasses.Location = new System.Drawing.Point(22, 30);
            this.listBoxClasses.Name = "listBoxClasses";
            this.listBoxClasses.Size = new System.Drawing.Size(265, 221);
            this.listBoxClasses.TabIndex = 2;
            // 
            // buttonGrades
            // 
            this.buttonGrades.Location = new System.Drawing.Point(825, 530);
            this.buttonGrades.Name = "buttonGrades";
            this.buttonGrades.Size = new System.Drawing.Size(209, 46);
            this.buttonGrades.TabIndex = 3;
            this.buttonGrades.Text = "Modify Grades";
            this.buttonGrades.UseVisualStyleBackColor = true;
            // 
            // ProfessorMainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1116, 756);
            this.Controls.Add(this.buttonGrades);
            this.Controls.Add(this.listBoxClasses);
            this.Controls.Add(this.dataGridViewStudents);
            this.Controls.Add(this.buttonAddContent);
            this.Name = "ProfessorMainForm";
            this.Text = "ProfessorMainForm";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewStudents)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonAddContent;
        private System.Windows.Forms.DataGridView dataGridViewStudents;
        private System.Windows.Forms.ListBox listBoxClasses;
        private System.Windows.Forms.Button buttonGrades;
    }
}