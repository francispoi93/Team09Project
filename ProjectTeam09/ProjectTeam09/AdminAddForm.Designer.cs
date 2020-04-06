namespace ProjectTeam09
{
    partial class AdminAddForm
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
            this.radioButtonAdminSelect = new System.Windows.Forms.RadioButton();
            this.radioButtonProfessorSelect = new System.Windows.Forms.RadioButton();
            this.radioButtonStudentSelect = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // radioButtonAdminSelect
            // 
            this.radioButtonAdminSelect.AutoSize = true;
            this.radioButtonAdminSelect.Location = new System.Drawing.Point(28, 25);
            this.radioButtonAdminSelect.Name = "radioButtonAdminSelect";
            this.radioButtonAdminSelect.Size = new System.Drawing.Size(133, 36);
            this.radioButtonAdminSelect.TabIndex = 0;
            this.radioButtonAdminSelect.TabStop = true;
            this.radioButtonAdminSelect.Text = "Admin";
            this.radioButtonAdminSelect.UseVisualStyleBackColor = true;
            // 
            // radioButtonProfessorSelect
            // 
            this.radioButtonProfessorSelect.AutoSize = true;
            this.radioButtonProfessorSelect.Location = new System.Drawing.Point(28, 135);
            this.radioButtonProfessorSelect.Name = "radioButtonProfessorSelect";
            this.radioButtonProfessorSelect.Size = new System.Drawing.Size(173, 36);
            this.radioButtonProfessorSelect.TabIndex = 1;
            this.radioButtonProfessorSelect.TabStop = true;
            this.radioButtonProfessorSelect.Text = "Professor";
            this.radioButtonProfessorSelect.UseVisualStyleBackColor = true;
            // 
            // radioButtonStudentSelect
            // 
            this.radioButtonStudentSelect.AutoSize = true;
            this.radioButtonStudentSelect.Location = new System.Drawing.Point(28, 82);
            this.radioButtonStudentSelect.Name = "radioButtonStudentSelect";
            this.radioButtonStudentSelect.Size = new System.Drawing.Size(151, 36);
            this.radioButtonStudentSelect.TabIndex = 2;
            this.radioButtonStudentSelect.TabStop = true;
            this.radioButtonStudentSelect.Text = "Student";
            this.radioButtonStudentSelect.UseVisualStyleBackColor = true;
            // 
            // AdminAddForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1127, 719);
            this.Controls.Add(this.radioButtonStudentSelect);
            this.Controls.Add(this.radioButtonProfessorSelect);
            this.Controls.Add(this.radioButtonAdminSelect);
            this.Name = "AdminAddForm";
            this.Text = "AdminAddForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton radioButtonAdminSelect;
        private System.Windows.Forms.RadioButton radioButtonProfessorSelect;
        private System.Windows.Forms.RadioButton radioButtonStudentSelect;
    }
}