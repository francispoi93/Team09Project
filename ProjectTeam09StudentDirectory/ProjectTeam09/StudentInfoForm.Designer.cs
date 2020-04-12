namespace ProjectTeam09
{
    partial class StudentInfoForm
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
            this.labelFirstName = new System.Windows.Forms.Label();
            this.labelNumber = new System.Windows.Forms.Label();
            this.labelEmail = new System.Windows.Forms.Label();
            this.textBoxPhone = new System.Windows.Forms.TextBox();
            this.textBoxEmail = new System.Windows.Forms.TextBox();
            this.labelLastName = new System.Windows.Forms.Label();
            this.buttonUpdate = new System.Windows.Forms.Button();
            this.labelFirstNameServer = new System.Windows.Forms.Label();
            this.labelLastNameServer = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelFirstName
            // 
            this.labelFirstName.AutoSize = true;
            this.labelFirstName.Location = new System.Drawing.Point(49, 58);
            this.labelFirstName.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.labelFirstName.Name = "labelFirstName";
            this.labelFirstName.Size = new System.Drawing.Size(57, 13);
            this.labelFirstName.TabIndex = 0;
            this.labelFirstName.Text = "First Name";
            // 
            // labelNumber
            // 
            this.labelNumber.AutoSize = true;
            this.labelNumber.Location = new System.Drawing.Point(31, 129);
            this.labelNumber.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.labelNumber.Name = "labelNumber";
            this.labelNumber.Size = new System.Drawing.Size(76, 13);
            this.labelNumber.TabIndex = 1;
            this.labelNumber.Text = "Phone number";
            // 
            // labelEmail
            // 
            this.labelEmail.AutoSize = true;
            this.labelEmail.Location = new System.Drawing.Point(49, 162);
            this.labelEmail.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.labelEmail.Name = "labelEmail";
            this.labelEmail.Size = new System.Drawing.Size(32, 13);
            this.labelEmail.TabIndex = 2;
            this.labelEmail.Text = "Email";
            // 
            // textBoxPhone
            // 
            this.textBoxPhone.Location = new System.Drawing.Point(117, 126);
            this.textBoxPhone.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.textBoxPhone.Name = "textBoxPhone";
            this.textBoxPhone.Size = new System.Drawing.Size(142, 20);
            this.textBoxPhone.TabIndex = 4;
            // 
            // textBoxEmail
            // 
            this.textBoxEmail.Location = new System.Drawing.Point(117, 162);
            this.textBoxEmail.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.textBoxEmail.Name = "textBoxEmail";
            this.textBoxEmail.Size = new System.Drawing.Size(142, 20);
            this.textBoxEmail.TabIndex = 5;
            // 
            // labelLastName
            // 
            this.labelLastName.AutoSize = true;
            this.labelLastName.Location = new System.Drawing.Point(49, 92);
            this.labelLastName.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.labelLastName.Name = "labelLastName";
            this.labelLastName.Size = new System.Drawing.Size(58, 13);
            this.labelLastName.TabIndex = 6;
            this.labelLastName.Text = "Last Name";
            // 
            // buttonUpdate
            // 
            this.buttonUpdate.Location = new System.Drawing.Point(117, 225);
            this.buttonUpdate.Name = "buttonUpdate";
            this.buttonUpdate.Size = new System.Drawing.Size(151, 41);
            this.buttonUpdate.TabIndex = 8;
            this.buttonUpdate.Text = "Update";
            this.buttonUpdate.UseVisualStyleBackColor = true;
            // 
            // labelFirstNameServer
            // 
            this.labelFirstNameServer.AutoSize = true;
            this.labelFirstNameServer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelFirstNameServer.Location = new System.Drawing.Point(117, 58);
            this.labelFirstNameServer.Name = "labelFirstNameServer";
            this.labelFirstNameServer.Size = new System.Drawing.Size(37, 15);
            this.labelFirstNameServer.TabIndex = 9;
            this.labelFirstNameServer.Text = "label1";
            // 
            // labelLastNameServer
            // 
            this.labelLastNameServer.AutoSize = true;
            this.labelLastNameServer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelLastNameServer.Location = new System.Drawing.Point(117, 90);
            this.labelLastNameServer.Name = "labelLastNameServer";
            this.labelLastNameServer.Size = new System.Drawing.Size(37, 15);
            this.labelLastNameServer.TabIndex = 10;
            this.labelLastNameServer.Text = "label1";
            // 
            // StudentInfoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(364, 292);
            this.Controls.Add(this.labelLastNameServer);
            this.Controls.Add(this.labelFirstNameServer);
            this.Controls.Add(this.buttonUpdate);
            this.Controls.Add(this.labelLastName);
            this.Controls.Add(this.textBoxEmail);
            this.Controls.Add(this.textBoxPhone);
            this.Controls.Add(this.labelEmail);
            this.Controls.Add(this.labelNumber);
            this.Controls.Add(this.labelFirstName);
            this.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.Name = "StudentInfoForm";
            this.Text = "StudentInfoForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelFirstName;
        private System.Windows.Forms.Label labelNumber;
        private System.Windows.Forms.Label labelEmail;
        private System.Windows.Forms.TextBox textBoxPhone;
        private System.Windows.Forms.TextBox textBoxEmail;
        private System.Windows.Forms.Label labelLastName;
        private System.Windows.Forms.Button buttonUpdate;
        private System.Windows.Forms.Label labelFirstNameServer;
        private System.Windows.Forms.Label labelLastNameServer;
    }
}