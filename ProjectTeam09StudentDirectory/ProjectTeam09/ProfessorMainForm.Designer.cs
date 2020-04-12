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
            this.buttonGrades = new System.Windows.Forms.Button();
            this.dataGridViewProfessorCourses = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProfessorCourses)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonAddContent
            // 
            this.buttonAddContent.Location = new System.Drawing.Point(41, 238);
            this.buttonAddContent.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.buttonAddContent.Name = "buttonAddContent";
            this.buttonAddContent.Size = new System.Drawing.Size(201, 51);
            this.buttonAddContent.TabIndex = 0;
            this.buttonAddContent.Text = "Add Content";
            this.buttonAddContent.UseVisualStyleBackColor = true;
            // 
            // buttonGrades
            // 
            this.buttonGrades.Location = new System.Drawing.Point(265, 238);
            this.buttonGrades.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.buttonGrades.Name = "buttonGrades";
            this.buttonGrades.Size = new System.Drawing.Size(209, 51);
            this.buttonGrades.TabIndex = 3;
            this.buttonGrades.Text = "Modify Grades";
            this.buttonGrades.UseVisualStyleBackColor = true;
            // 
            // dataGridViewProfessorCourses
            // 
            this.dataGridViewProfessorCourses.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewProfessorCourses.Location = new System.Drawing.Point(13, 12);
            this.dataGridViewProfessorCourses.Name = "dataGridViewProfessorCourses";
            this.dataGridViewProfessorCourses.Size = new System.Drawing.Size(496, 208);
            this.dataGridViewProfessorCourses.TabIndex = 4;
            // 
            // ProfessorMainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(574, 318);
            this.Controls.Add(this.dataGridViewProfessorCourses);
            this.Controls.Add(this.buttonGrades);
            this.Controls.Add(this.buttonAddContent);
            this.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.Name = "ProfessorMainForm";
            this.Text = "ProfessorMainForm";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProfessorCourses)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonAddContent;
        private System.Windows.Forms.Button buttonGrades;
        private System.Windows.Forms.DataGridView dataGridViewProfessorCourses;
    }
}