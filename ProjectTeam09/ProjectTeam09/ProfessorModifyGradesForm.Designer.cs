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
            this.labelModify = new System.Windows.Forms.Label();
            this.buttonAddNewGrade = new System.Windows.Forms.Button();
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
            this.dataGridViewProfGrades.Size = new System.Drawing.Size(529, 337);
            this.dataGridViewProfGrades.TabIndex = 1;
            // 
            // buttonModifyGrades
            // 
            this.buttonModifyGrades.Location = new System.Drawing.Point(543, 59);
            this.buttonModifyGrades.Name = "buttonModifyGrades";
            this.buttonModifyGrades.Size = new System.Drawing.Size(285, 69);
            this.buttonModifyGrades.TabIndex = 4;
            this.buttonModifyGrades.Text = "Modify";
            this.buttonModifyGrades.UseVisualStyleBackColor = true;
            // 
            // labelModify
            // 
            this.labelModify.AutoSize = true;
            this.labelModify.Location = new System.Drawing.Point(547, 27);
            this.labelModify.Name = "labelModify";
            this.labelModify.Size = new System.Drawing.Size(281, 13);
            this.labelModify.TabIndex = 5;
            this.labelModify.Text = "Edit a grade on the left and press modify to save changes.";
            // 
            // buttonAddNewGrade
            // 
            this.buttonAddNewGrade.Location = new System.Drawing.Point(543, 148);
            this.buttonAddNewGrade.Name = "buttonAddNewGrade";
            this.buttonAddNewGrade.Size = new System.Drawing.Size(285, 69);
            this.buttonAddNewGrade.TabIndex = 6;
            this.buttonAddNewGrade.Text = "Add a grade";
            this.buttonAddNewGrade.UseVisualStyleBackColor = true;
            // 
            // ProfessorModifyGradesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(838, 477);
            this.Controls.Add(this.buttonAddNewGrade);
            this.Controls.Add(this.labelModify);
            this.Controls.Add(this.buttonModifyGrades);
            this.Controls.Add(this.dataGridViewProfGrades);
            this.Margin = new System.Windows.Forms.Padding(1);
            this.Name = "ProfessorModifyGradesForm";
            this.Text = "ProfessorModifyGradesForm";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProfGrades)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dataGridViewProfGrades;
        private System.Windows.Forms.Button buttonModifyGrades;
        private System.Windows.Forms.Label labelModify;
        private System.Windows.Forms.Button buttonAddNewGrade;
    }
}