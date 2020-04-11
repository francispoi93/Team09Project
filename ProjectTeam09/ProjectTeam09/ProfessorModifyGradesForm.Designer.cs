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
            this.dataGridViewProfGrades = new System.Windows.Forms.DataGridView();
            this.buttonModifyGrades = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProfGrades)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewProfGrades
            // 
            this.dataGridViewProfGrades.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewProfGrades.Location = new System.Drawing.Point(10, 10);
            this.dataGridViewProfGrades.Margin = new System.Windows.Forms.Padding(1);
            this.dataGridViewProfGrades.Name = "dataGridViewProfGrades";
            this.dataGridViewProfGrades.RowHeadersWidth = 102;
            this.dataGridViewProfGrades.RowTemplate.Height = 40;
            this.dataGridViewProfGrades.Size = new System.Drawing.Size(830, 382);
            this.dataGridViewProfGrades.TabIndex = 1;
            // 
            // buttonModifyGrades
            // 
            this.buttonModifyGrades.Location = new System.Drawing.Point(301, 396);
            this.buttonModifyGrades.Name = "buttonModifyGrades";
            this.buttonModifyGrades.Size = new System.Drawing.Size(285, 69);
            this.buttonModifyGrades.TabIndex = 4;
            this.buttonModifyGrades.Text = "Modify Grades";
            this.buttonModifyGrades.UseVisualStyleBackColor = true;
            // 
            // ProfessorModifyGradesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(838, 477);
            this.Controls.Add(this.buttonModifyGrades);
            this.Controls.Add(this.dataGridViewProfGrades);
            this.Margin = new System.Windows.Forms.Padding(1);
            this.Name = "ProfessorModifyGradesForm";
            this.Text = "ProfessorModifyGradesForm";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProfGrades)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView dataGridViewProfGrades;
        private System.Windows.Forms.Button buttonModifyGrades;
    }
}