namespace InventoryProject.Forms
{
    partial class RegisterPage
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
            this.IGNBox = new System.Windows.Forms.TextBox();
            this.UsernameBox = new System.Windows.Forms.TextBox();
            this.PasswordBox = new System.Windows.Forms.TextBox();
            this.Register = new System.Windows.Forms.Button();
            this.PasswordConfirmBox = new System.Windows.Forms.TextBox();
            this.IGNLabel = new System.Windows.Forms.Label();
            this.UsernameLabel = new System.Windows.Forms.Label();
            this.PasswordLabel = new System.Windows.Forms.Label();
            this.PasswordConfirmLabel = new System.Windows.Forms.Label();
            this.UserWarning = new System.Windows.Forms.Label();
            this.PasswordWarning = new System.Windows.Forms.Label();
            this.IGNWarning = new System.Windows.Forms.Label();
            this.BackButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // IGNBox
            // 
            this.IGNBox.AccessibleName = "IGNBox";
            this.IGNBox.Location = new System.Drawing.Point(416, 154);
            this.IGNBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.IGNBox.Name = "IGNBox";
            this.IGNBox.Size = new System.Drawing.Size(424, 31);
            this.IGNBox.TabIndex = 0;
            this.IGNBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.IGNBox_KeyPress);
            // 
            // UsernameBox
            // 
            this.UsernameBox.Location = new System.Drawing.Point(416, 331);
            this.UsernameBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.UsernameBox.Name = "UsernameBox";
            this.UsernameBox.Size = new System.Drawing.Size(424, 31);
            this.UsernameBox.TabIndex = 1;
            this.UsernameBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.UsernameBox_KeyPress);
            // 
            // PasswordBox
            // 
            this.PasswordBox.Location = new System.Drawing.Point(416, 394);
            this.PasswordBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.PasswordBox.Name = "PasswordBox";
            this.PasswordBox.Size = new System.Drawing.Size(424, 31);
            this.PasswordBox.TabIndex = 2;
            this.PasswordBox.TextChanged += new System.EventHandler(this.PasswordBox_TextChanged);
            // 
            // Register
            // 
            this.Register.Location = new System.Drawing.Point(712, 635);
            this.Register.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Register.Name = "Register";
            this.Register.Size = new System.Drawing.Size(128, 56);
            this.Register.TabIndex = 4;
            this.Register.Text = "Register";
            this.Register.UseVisualStyleBackColor = true;
            this.Register.Click += new System.EventHandler(this.Register_Click);
            // 
            // PasswordConfirmBox
            // 
            this.PasswordConfirmBox.Location = new System.Drawing.Point(416, 462);
            this.PasswordConfirmBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.PasswordConfirmBox.Name = "PasswordConfirmBox";
            this.PasswordConfirmBox.Size = new System.Drawing.Size(424, 31);
            this.PasswordConfirmBox.TabIndex = 3;
            this.PasswordConfirmBox.TextChanged += new System.EventHandler(this.PasswordConfirmBox_TextChanged);
            // 
            // IGNLabel
            // 
            this.IGNLabel.AutoSize = true;
            this.IGNLabel.Location = new System.Drawing.Point(280, 156);
            this.IGNLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.IGNLabel.Name = "IGNLabel";
            this.IGNLabel.Size = new System.Drawing.Size(95, 25);
            this.IGNLabel.TabIndex = 5;
            this.IGNLabel.Text = "IG Name";
            // 
            // UsernameLabel
            // 
            this.UsernameLabel.AutoSize = true;
            this.UsernameLabel.Location = new System.Drawing.Point(280, 333);
            this.UsernameLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.UsernameLabel.Name = "UsernameLabel";
            this.UsernameLabel.Size = new System.Drawing.Size(110, 25);
            this.UsernameLabel.TabIndex = 6;
            this.UsernameLabel.Text = "Username";
            // 
            // PasswordLabel
            // 
            this.PasswordLabel.AutoSize = true;
            this.PasswordLabel.Location = new System.Drawing.Point(280, 394);
            this.PasswordLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.PasswordLabel.Name = "PasswordLabel";
            this.PasswordLabel.Size = new System.Drawing.Size(106, 25);
            this.PasswordLabel.TabIndex = 7;
            this.PasswordLabel.Text = "Password";
            // 
            // PasswordConfirmLabel
            // 
            this.PasswordConfirmLabel.AutoSize = true;
            this.PasswordConfirmLabel.Location = new System.Drawing.Point(204, 462);
            this.PasswordConfirmLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.PasswordConfirmLabel.Name = "PasswordConfirmLabel";
            this.PasswordConfirmLabel.Size = new System.Drawing.Size(186, 25);
            this.PasswordConfirmLabel.TabIndex = 8;
            this.PasswordConfirmLabel.Text = "Password Confirm";
            // 
            // UserWarning
            // 
            this.UserWarning.AccessibleName = "UserWarning";
            this.UserWarning.AutoSize = true;
            this.UserWarning.Location = new System.Drawing.Point(878, 333);
            this.UserWarning.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.UserWarning.Name = "UserWarning";
            this.UserWarning.Size = new System.Drawing.Size(137, 25);
            this.UserWarning.TabIndex = 9;
            this.UserWarning.Text = "UserWarning";
            this.UserWarning.Visible = false;
            // 
            // PasswordWarning
            // 
            this.PasswordWarning.AccessibleName = "PasswordWarning";
            this.PasswordWarning.AutoSize = true;
            this.PasswordWarning.Location = new System.Drawing.Point(878, 462);
            this.PasswordWarning.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.PasswordWarning.Name = "PasswordWarning";
            this.PasswordWarning.Size = new System.Drawing.Size(186, 25);
            this.PasswordWarning.TabIndex = 10;
            this.PasswordWarning.Text = "PasswordWarning";
            this.PasswordWarning.Visible = false;
            // 
            // IGNWarning
            // 
            this.IGNWarning.AccessibleName = "IGNWarning";
            this.IGNWarning.AutoSize = true;
            this.IGNWarning.Location = new System.Drawing.Point(878, 156);
            this.IGNWarning.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.IGNWarning.Name = "IGNWarning";
            this.IGNWarning.Size = new System.Drawing.Size(128, 25);
            this.IGNWarning.TabIndex = 11;
            this.IGNWarning.Text = "IGNWarning";
            this.IGNWarning.Visible = false;
            // 
            // BackButton
            // 
            this.BackButton.AccessibleName = "BackButton";
            this.BackButton.Location = new System.Drawing.Point(0, -4);
            this.BackButton.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.BackButton.Name = "BackButton";
            this.BackButton.Size = new System.Drawing.Size(148, 81);
            this.BackButton.TabIndex = 5;
            this.BackButton.Text = "Back";
            this.BackButton.UseVisualStyleBackColor = true;
            this.BackButton.Click += new System.EventHandler(this.BackButton_Click);
            // 
            // RegisterPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1624, 879);
            this.Controls.Add(this.BackButton);
            this.Controls.Add(this.IGNWarning);
            this.Controls.Add(this.PasswordWarning);
            this.Controls.Add(this.UserWarning);
            this.Controls.Add(this.PasswordConfirmLabel);
            this.Controls.Add(this.PasswordLabel);
            this.Controls.Add(this.UsernameLabel);
            this.Controls.Add(this.IGNLabel);
            this.Controls.Add(this.PasswordConfirmBox);
            this.Controls.Add(this.Register);
            this.Controls.Add(this.PasswordBox);
            this.Controls.Add(this.UsernameBox);
            this.Controls.Add(this.IGNBox);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "RegisterPage";
            this.Text = "RegisterPage";
            this.VisibleChanged += new System.EventHandler(this.RegisterPage_VisibleChanged);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox IGNBox;
        private System.Windows.Forms.TextBox UsernameBox;
        private System.Windows.Forms.TextBox PasswordBox;
        private System.Windows.Forms.Button Register;
        private System.Windows.Forms.TextBox PasswordConfirmBox;
        private System.Windows.Forms.Label IGNLabel;
        private System.Windows.Forms.Label UsernameLabel;
        private System.Windows.Forms.Label PasswordLabel;
        private System.Windows.Forms.Label PasswordConfirmLabel;
        private System.Windows.Forms.Label UserWarning;
        private System.Windows.Forms.Label PasswordWarning;
        private System.Windows.Forms.Label IGNWarning;
        private System.Windows.Forms.Button BackButton;
    }
}