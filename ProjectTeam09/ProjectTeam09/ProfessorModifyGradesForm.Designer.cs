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
            this.labelAssignments = new System.Windows.Forms.Label();
            this.listBoxAssignments = new System.Windows.Forms.ListBox();
            this.buttonAddAssingment = new System.Windows.Forms.Button();
            this.buttonModifyGrades = new System.Windows.Forms.Button();
            this.buttonViewGrades = new System.Windows.Forms.Button();
            this.textBoxAddAssignment = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProfGrades)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewProfGrades
            // 
            this.dataGridViewProfGrades.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewProfGrades.Location = new System.Drawing.Point(54, 242);
            this.dataGridViewProfGrades.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.dataGridViewProfGrades.Name = "dataGridViewProfGrades";
            this.dataGridViewProfGrades.RowHeadersWidth = 102;
            this.dataGridViewProfGrades.RowTemplate.Height = 40;
            this.dataGridViewProfGrades.Size = new System.Drawing.Size(556, 185);
            this.dataGridViewProfGrades.TabIndex = 1;
            // 
            // labelAssignments
            // 
            this.labelAssignments.AutoSize = true;
            this.labelAssignments.Location = new System.Drawing.Point(51, 34);
            this.labelAssignments.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.labelAssignments.Name = "labelAssignments";
            this.labelAssignments.Size = new System.Drawing.Size(61, 13);
            this.labelAssignments.TabIndex = 0;
            this.labelAssignments.Text = "Assignment";
            // 
            // listBoxAssignments
            // 
            this.listBoxAssignments.FormattingEnabled = true;
            this.listBoxAssignments.Location = new System.Drawing.Point(42, 62);
            this.listBoxAssignments.Name = "listBoxAssignments";
            this.listBoxAssignments.Size = new System.Drawing.Size(247, 134);
            this.listBoxAssignments.TabIndex = 2;
            // 
            // buttonAddAssingment
            // 
            this.buttonAddAssingment.Location = new System.Drawing.Point(385, 62);
            this.buttonAddAssingment.Name = "buttonAddAssingment";
            this.buttonAddAssingment.Size = new System.Drawing.Size(156, 43);
            this.buttonAddAssingment.TabIndex = 3;
            this.buttonAddAssingment.Text = "Add Assignment";
            this.buttonAddAssingment.UseVisualStyleBackColor = true;
            // 
            // buttonModifyGrades
            // 
            this.buttonModifyGrades.Location = new System.Drawing.Point(647, 329);
            this.buttonModifyGrades.Name = "buttonModifyGrades";
            this.buttonModifyGrades.Size = new System.Drawing.Size(75, 23);
            this.buttonModifyGrades.TabIndex = 4;
            this.buttonModifyGrades.Text = "Modify Grades";
            this.buttonModifyGrades.UseVisualStyleBackColor = true;
            // 
            // buttonViewGrades
            // 
            this.buttonViewGrades.Location = new System.Drawing.Point(385, 123);
            this.buttonViewGrades.Name = "buttonViewGrades";
            this.buttonViewGrades.Size = new System.Drawing.Size(156, 53);
            this.buttonViewGrades.TabIndex = 5;
            this.buttonViewGrades.Text = "View Grades";
            this.buttonViewGrades.UseVisualStyleBackColor = true;
            // 
            // textBoxAddAssignment
            // 
            this.textBoxAddAssignment.Location = new System.Drawing.Point(385, 27);
            this.textBoxAddAssignment.Name = "textBoxAddAssignment";
            this.textBoxAddAssignment.Size = new System.Drawing.Size(156, 20);
            this.textBoxAddAssignment.TabIndex = 6;
            // 
            // ProfessorModifyGradesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(838, 477);
            this.Controls.Add(this.textBoxAddAssignment);
            this.Controls.Add(this.buttonViewGrades);
            this.Controls.Add(this.buttonModifyGrades);
            this.Controls.Add(this.buttonAddAssingment);
            this.Controls.Add(this.listBoxAssignments);
            this.Controls.Add(this.dataGridViewProfGrades);
            this.Controls.Add(this.labelAssignments);
            this.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.Name = "ProfessorModifyGradesForm";
            this.Text = "ProfessorModifyGradesForm";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProfGrades)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dataGridViewProfGrades;
        private System.Windows.Forms.Label labelAssignments;
        private System.Windows.Forms.ListBox listBoxAssignments;
        private System.Windows.Forms.Button buttonAddAssingment;
        private System.Windows.Forms.Button buttonModifyGrades;
        private System.Windows.Forms.Button buttonViewGrades;
        private System.Windows.Forms.TextBox textBoxAddAssignment;
    }
}