﻿namespace ProjectTeam09
{
    partial class LoginForm
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
            this.labelLoginUsername = new System.Windows.Forms.Label();
            this.labelLoginPassword = new System.Windows.Forms.Label();
            this.buttonLoginSignIn = new System.Windows.Forms.Button();
            this.textBoxLoginUsername = new System.Windows.Forms.TextBox();
            this.textBoxLoginPassword = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // labelLoginUsername
            // 
            this.labelLoginUsername.AutoSize = true;
            this.labelLoginUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelLoginUsername.Location = new System.Drawing.Point(117, 98);
            this.labelLoginUsername.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.labelLoginUsername.Name = "labelLoginUsername";
            this.labelLoginUsername.Size = new System.Drawing.Size(270, 61);
            this.labelLoginUsername.TabIndex = 0;
            this.labelLoginUsername.Text = "Username";
            // 
            // labelLoginPassword
            // 
            this.labelLoginPassword.AutoSize = true;
            this.labelLoginPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelLoginPassword.Location = new System.Drawing.Point(117, 224);
            this.labelLoginPassword.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.labelLoginPassword.Name = "labelLoginPassword";
            this.labelLoginPassword.Size = new System.Drawing.Size(259, 61);
            this.labelLoginPassword.TabIndex = 1;
            this.labelLoginPassword.Text = "Password";
            // 
            // buttonLoginSignIn
            // 
            this.buttonLoginSignIn.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonLoginSignIn.Location = new System.Drawing.Point(221, 364);
            this.buttonLoginSignIn.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.buttonLoginSignIn.Name = "buttonLoginSignIn";
            this.buttonLoginSignIn.Size = new System.Drawing.Size(483, 126);
            this.buttonLoginSignIn.TabIndex = 2;
            this.buttonLoginSignIn.Text = "Sign in";
            this.buttonLoginSignIn.UseVisualStyleBackColor = true;
            // 
            // textBoxLoginUsername
            // 
            this.textBoxLoginUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxLoginUsername.Location = new System.Drawing.Point(468, 98);
            this.textBoxLoginUsername.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.textBoxLoginUsername.Name = "textBoxLoginUsername";
            this.textBoxLoginUsername.Size = new System.Drawing.Size(476, 67);
            this.textBoxLoginUsername.TabIndex = 3;
            // 
            // textBoxLoginPassword
            // 
            this.textBoxLoginPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxLoginPassword.Location = new System.Drawing.Point(468, 218);
            this.textBoxLoginPassword.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.textBoxLoginPassword.Name = "textBoxLoginPassword";
            this.textBoxLoginPassword.Size = new System.Drawing.Size(476, 67);
            this.textBoxLoginPassword.TabIndex = 4;
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1096, 555);
            this.Controls.Add(this.textBoxLoginPassword);
            this.Controls.Add(this.textBoxLoginUsername);
            this.Controls.Add(this.buttonLoginSignIn);
            this.Controls.Add(this.labelLoginPassword);
            this.Controls.Add(this.labelLoginUsername);
            this.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.Name = "LoginForm";
            this.Text = "Login";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelLoginUsername;
        private System.Windows.Forms.Label labelLoginPassword;
        private System.Windows.Forms.Button buttonLoginSignIn;
        private System.Windows.Forms.TextBox textBoxLoginUsername;
        private System.Windows.Forms.TextBox textBoxLoginPassword;
    }
}