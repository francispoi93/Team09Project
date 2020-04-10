namespace ProjectTeam09
{
    partial class ProfessorAdContentForm
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
            this.webBrowserStudentGrades = new System.Windows.Forms.WebBrowser();
            this.labelDragAndDrop = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // webBrowserStudentGrades
            // 
            this.webBrowserStudentGrades.Location = new System.Drawing.Point(12, 28);
            this.webBrowserStudentGrades.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowserStudentGrades.Name = "webBrowserStudentGrades";
            this.webBrowserStudentGrades.Size = new System.Drawing.Size(776, 410);
            this.webBrowserStudentGrades.TabIndex = 0;
            // 
            // labelDragAndDrop
            // 
            this.labelDragAndDrop.AutoSize = true;
            this.labelDragAndDrop.Location = new System.Drawing.Point(167, 9);
            this.labelDragAndDrop.Name = "labelDragAndDrop";
            this.labelDragAndDrop.Size = new System.Drawing.Size(355, 13);
            this.labelDragAndDrop.TabIndex = 1;
            this.labelDragAndDrop.Text = "Drag and drop your content into this box or delete  already added content.";
            // 
            // ProfessorAdContentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.labelDragAndDrop);
            this.Controls.Add(this.webBrowserStudentGrades);
            this.Name = "ProfessorAdContentForm";
            this.Text = "ProfessorAdContentForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.WebBrowser webBrowserStudentGrades;
        private System.Windows.Forms.Label labelDragAndDrop;
    }
}