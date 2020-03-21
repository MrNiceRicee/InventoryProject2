namespace InventoryProject.Forms
{
    partial class UserProfile
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
            this.PersonalGamesPanel = new System.Windows.Forms.Panel();
            this.PersonalGamesLabel = new System.Windows.Forms.Label();
            this.WelcomeLabel = new System.Windows.Forms.Label();
            this.UserFunds = new System.Windows.Forms.Label();
            this.BackButtonLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // PersonalGamesPanel
            // 
            this.PersonalGamesPanel.AccessibleName = "PersonalGamesPanel";
            this.PersonalGamesPanel.Location = new System.Drawing.Point(42, 84);
            this.PersonalGamesPanel.Name = "PersonalGamesPanel";
            this.PersonalGamesPanel.Size = new System.Drawing.Size(425, 326);
            this.PersonalGamesPanel.TabIndex = 0;
            // 
            // PersonalGamesLabel
            // 
            this.PersonalGamesLabel.AccessibleName = "PersonalGamesLabel";
            this.PersonalGamesLabel.AutoSize = true;
            this.PersonalGamesLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PersonalGamesLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.PersonalGamesLabel.Location = new System.Drawing.Point(37, 55);
            this.PersonalGamesLabel.Name = "PersonalGamesLabel";
            this.PersonalGamesLabel.Size = new System.Drawing.Size(78, 26);
            this.PersonalGamesLabel.TabIndex = 1;
            this.PersonalGamesLabel.Text = "Library";
            // 
            // WelcomeLabel
            // 
            this.WelcomeLabel.AccessibleName = "WelcomeLabel";
            this.WelcomeLabel.AutoSize = true;
            this.WelcomeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WelcomeLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.WelcomeLabel.Location = new System.Drawing.Point(468, 55);
            this.WelcomeLabel.Name = "WelcomeLabel";
            this.WelcomeLabel.Size = new System.Drawing.Size(89, 26);
            this.WelcomeLabel.TabIndex = 2;
            this.WelcomeLabel.Text = "Name_ ";
            // 
            // UserFunds
            // 
            this.UserFunds.AccessibleName = "UserFunds";
            this.UserFunds.AutoSize = true;
            this.UserFunds.BackColor = System.Drawing.Color.Transparent;
            this.UserFunds.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.UserFunds.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UserFunds.ForeColor = System.Drawing.Color.Silver;
            this.UserFunds.Location = new System.Drawing.Point(500, 10);
            this.UserFunds.Name = "UserFunds";
            this.UserFunds.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.UserFunds.Size = new System.Drawing.Size(44, 17);
            this.UserFunds.TabIndex = 11;
            this.UserFunds.Text = "$0.00";
            // 
            // BackButtonLabel
            // 
            this.BackButtonLabel.AccessibleName = "BackButtonLabel";
            this.BackButtonLabel.AutoSize = true;
            this.BackButtonLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BackButtonLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.BackButtonLabel.Location = new System.Drawing.Point(12, 9);
            this.BackButtonLabel.Name = "BackButtonLabel";
            this.BackButtonLabel.Size = new System.Drawing.Size(52, 20);
            this.BackButtonLabel.TabIndex = 12;
            this.BackButtonLabel.Text = "Home";
            this.BackButtonLabel.DoubleClick += new System.EventHandler(this.CustomItem_DoubleClick);
            this.BackButtonLabel.MouseLeave += new System.EventHandler(this.CustomItem_MouseLeave);
            this.BackButtonLabel.MouseHover += new System.EventHandler(this.CustomItem_Hover);
            // 
            // UserProfile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(29)))), ((int)(((byte)(38)))));
            this.ClientSize = new System.Drawing.Size(812, 457);
            this.Controls.Add(this.BackButtonLabel);
            this.Controls.Add(this.UserFunds);
            this.Controls.Add(this.WelcomeLabel);
            this.Controls.Add(this.PersonalGamesLabel);
            this.Controls.Add(this.PersonalGamesPanel);
            this.Name = "UserProfile";
            this.Text = "UserProfile";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel PersonalGamesPanel;
        private System.Windows.Forms.Label PersonalGamesLabel;
        private System.Windows.Forms.Label WelcomeLabel;
        private System.Windows.Forms.Label UserFunds;
        private System.Windows.Forms.Label BackButtonLabel;
    }
}