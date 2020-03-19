namespace InventoryProject
{
    partial class LoginPage
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
            this.UsernameBox = new System.Windows.Forms.TextBox();
            this.PasswordBox = new System.Windows.Forms.TextBox();
            this.Usernamelabel = new System.Windows.Forms.Label();
            this.PasswordLabel = new System.Windows.Forms.Label();
            this.LoginButton = new System.Windows.Forms.Button();
            this.NewUserButton = new System.Windows.Forms.Button();
            this.LogInWarning = new System.Windows.Forms.Label();
            this.UserWarning = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // UsernameBox
            // 
            this.UsernameBox.AccessibleName = "UsernameBox";
            this.UsernameBox.Location = new System.Drawing.Point(366, 217);
            this.UsernameBox.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.UsernameBox.Name = "UsernameBox";
            this.UsernameBox.Size = new System.Drawing.Size(604, 31);
            this.UsernameBox.TabIndex = 1;
            this.UsernameBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.UsernameBox_KeyPress);
            // 
            // PasswordBox
            // 
            this.PasswordBox.AccessibleName = "PassWordBox";
            this.PasswordBox.Location = new System.Drawing.Point(366, 335);
            this.PasswordBox.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.PasswordBox.Name = "PasswordBox";
            this.PasswordBox.PasswordChar = '*';
            this.PasswordBox.Size = new System.Drawing.Size(604, 31);
            this.PasswordBox.TabIndex = 2;
            this.PasswordBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.PasswordBox_KeyPress);
            // 
            // Usernamelabel
            // 
            this.Usernamelabel.AccessibleName = "UsernameLabel";
            this.Usernamelabel.AutoSize = true;
            this.Usernamelabel.Location = new System.Drawing.Point(216, 225);
            this.Usernamelabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.Usernamelabel.Name = "Usernamelabel";
            this.Usernamelabel.Size = new System.Drawing.Size(110, 25);
            this.Usernamelabel.TabIndex = 8;
            this.Usernamelabel.Text = "Username";
            // 
            // PasswordLabel
            // 
            this.PasswordLabel.AccessibleName = "PasswordLabel";
            this.PasswordLabel.AutoSize = true;
            this.PasswordLabel.Location = new System.Drawing.Point(216, 340);
            this.PasswordLabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.PasswordLabel.Name = "PasswordLabel";
            this.PasswordLabel.Size = new System.Drawing.Size(106, 25);
            this.PasswordLabel.TabIndex = 9;
            this.PasswordLabel.Text = "Password";
            // 
            // LoginButton
            // 
            this.LoginButton.AccessibleName = "LoginButton";
            this.LoginButton.Location = new System.Drawing.Point(824, 446);
            this.LoginButton.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.LoginButton.Name = "LoginButton";
            this.LoginButton.Size = new System.Drawing.Size(150, 44);
            this.LoginButton.TabIndex = 3;
            this.LoginButton.Text = "Login";
            this.LoginButton.UseVisualStyleBackColor = true;
            this.LoginButton.Click += new System.EventHandler(this.LoginButton_Click);
            // 
            // NewUserButton
            // 
            this.NewUserButton.AccessibleName = "NewUserButton";
            this.NewUserButton.Location = new System.Drawing.Point(822, 390);
            this.NewUserButton.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.NewUserButton.Name = "NewUserButton";
            this.NewUserButton.Size = new System.Drawing.Size(150, 44);
            this.NewUserButton.TabIndex = 4;
            this.NewUserButton.Text = "New user?";
            this.NewUserButton.UseVisualStyleBackColor = true;
            this.NewUserButton.Click += new System.EventHandler(this.NewUserButton_Click);
            // 
            // LogInWarning
            // 
            this.LogInWarning.AccessibleName = "LogInWarning";
            this.LogInWarning.AutoSize = true;
            this.LogInWarning.Location = new System.Drawing.Point(360, 400);
            this.LogInWarning.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.LogInWarning.Name = "LogInWarning";
            this.LogInWarning.Size = new System.Drawing.Size(145, 25);
            this.LogInWarning.TabIndex = 14;
            this.LogInWarning.Text = "LogInWarning";
            this.LogInWarning.Visible = false;
            // 
            // UserWarning
            // 
            this.UserWarning.AccessibleName = "UserWarning";
            this.UserWarning.AutoSize = true;
            this.UserWarning.Location = new System.Drawing.Point(1016, 225);
            this.UserWarning.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.UserWarning.Name = "UserWarning";
            this.UserWarning.Size = new System.Drawing.Size(137, 25);
            this.UserWarning.TabIndex = 15;
            this.UserWarning.Text = "UserWarning";
            this.UserWarning.Visible = false;
            // 
            // LoginPage
            // 
            this.AccessibleName = "LoginPage";
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1624, 879);
            this.Controls.Add(this.UserWarning);
            this.Controls.Add(this.LogInWarning);
            this.Controls.Add(this.NewUserButton);
            this.Controls.Add(this.LoginButton);
            this.Controls.Add(this.PasswordLabel);
            this.Controls.Add(this.Usernamelabel);
            this.Controls.Add(this.PasswordBox);
            this.Controls.Add(this.UsernameBox);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "LoginPage";
            this.Text = "LoginPage";
            this.VisibleChanged += new System.EventHandler(this.LoginPage_VisibleChanged);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        public System.Windows.Forms.TextBox UsernameBox;
        private System.Windows.Forms.TextBox PasswordBox;
        private System.Windows.Forms.Label Usernamelabel;
        private System.Windows.Forms.Label PasswordLabel;
        private System.Windows.Forms.Button LoginButton;
        private System.Windows.Forms.Button NewUserButton;
        private System.Windows.Forms.Label LogInWarning;
        public System.Windows.Forms.Label UserWarning;
    }
}

