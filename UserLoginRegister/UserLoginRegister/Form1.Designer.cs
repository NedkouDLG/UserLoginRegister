
namespace UserLoginRegister
{
    partial class Form1
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
            this.userNameBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.emailBox = new System.Windows.Forms.TextBox();
            this.passwordBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.registerButton = new System.Windows.Forms.Button();
            this.alreadyHaveAnAccLabel = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // userNameBox
            // 
            this.userNameBox.Location = new System.Drawing.Point(95, 8);
            this.userNameBox.Name = "userNameBox";
            this.userNameBox.Size = new System.Drawing.Size(200, 22);
            this.userNameBox.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Username:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Email:";
            // 
            // emailBox
            // 
            this.emailBox.Location = new System.Drawing.Point(95, 42);
            this.emailBox.Name = "emailBox";
            this.emailBox.Size = new System.Drawing.Size(200, 22);
            this.emailBox.TabIndex = 3;
            // 
            // passwordBox
            // 
            this.passwordBox.Location = new System.Drawing.Point(95, 75);
            this.passwordBox.Name = "passwordBox";
            this.passwordBox.PasswordChar = '*';
            this.passwordBox.Size = new System.Drawing.Size(200, 22);
            this.passwordBox.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 75);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = "Password:";
            // 
            // registerButton
            // 
            this.registerButton.Location = new System.Drawing.Point(203, 103);
            this.registerButton.Name = "registerButton";
            this.registerButton.Size = new System.Drawing.Size(92, 35);
            this.registerButton.TabIndex = 6;
            this.registerButton.Text = "Register";
            this.registerButton.UseVisualStyleBackColor = true;
            this.registerButton.Click += new System.EventHandler(this.registerButton_Click);
            // 
            // alreadyHaveAnAccLabel
            // 
            this.alreadyHaveAnAccLabel.AutoSize = true;
            this.alreadyHaveAnAccLabel.Location = new System.Drawing.Point(12, 112);
            this.alreadyHaveAnAccLabel.Name = "alreadyHaveAnAccLabel";
            this.alreadyHaveAnAccLabel.Size = new System.Drawing.Size(173, 17);
            this.alreadyHaveAnAccLabel.TabIndex = 7;
            this.alreadyHaveAnAccLabel.TabStop = true;
            this.alreadyHaveAnAccLabel.Text = "Already have an account?";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(315, 152);
            this.Controls.Add(this.alreadyHaveAnAccLabel);
            this.Controls.Add(this.registerButton);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.passwordBox);
            this.Controls.Add(this.emailBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.userNameBox);
            this.Name = "Form1";
            this.Text = "Register Form";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox userNameBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox emailBox;
        private System.Windows.Forms.TextBox passwordBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button registerButton;
        private System.Windows.Forms.LinkLabel alreadyHaveAnAccLabel;
    }
}

