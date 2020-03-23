namespace InventoryProject.Forms
{
    partial class StudioPage
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
            this.GameTitleLabel = new System.Windows.Forms.Label();
            this.GameResultsPanel = new System.Windows.Forms.Panel();
            this.GameDescriptionBox = new System.Windows.Forms.ListBox();
            this.GameStudioLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // GameTitleLabel
            // 
            this.GameTitleLabel.AccessibleName = "";
            this.GameTitleLabel.AutoSize = true;
            this.GameTitleLabel.BackColor = System.Drawing.Color.Transparent;
            this.GameTitleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GameTitleLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.GameTitleLabel.Location = new System.Drawing.Point(272, 9);
            this.GameTitleLabel.Name = "GameTitleLabel";
            this.GameTitleLabel.Size = new System.Drawing.Size(297, 39);
            this.GameTitleLabel.TabIndex = 6;
            this.GameTitleLabel.Text = "GameStudioName";
            // 
            // GameResultsPanel
            // 
            this.GameResultsPanel.AccessibleDescription = "Shows Results";
            this.GameResultsPanel.AccessibleName = "GameResultsPanel";
            this.GameResultsPanel.AutoScroll = true;
            this.GameResultsPanel.AutoScrollMargin = new System.Drawing.Size(0, 2);
            this.GameResultsPanel.BackColor = System.Drawing.Color.Transparent;
            this.GameResultsPanel.Location = new System.Drawing.Point(349, 130);
            this.GameResultsPanel.Name = "GameResultsPanel";
            this.GameResultsPanel.Padding = new System.Windows.Forms.Padding(0, 3, 0, 3);
            this.GameResultsPanel.Size = new System.Drawing.Size(439, 308);
            this.GameResultsPanel.TabIndex = 7;
            // 
            // GameDescriptionBox
            // 
            this.GameDescriptionBox.AccessibleName = "GameDescriptionBox";
            this.GameDescriptionBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(39)))), ((int)(((byte)(50)))));
            this.GameDescriptionBox.ForeColor = System.Drawing.Color.Gainsboro;
            this.GameDescriptionBox.FormattingEnabled = true;
            this.GameDescriptionBox.Location = new System.Drawing.Point(12, 130);
            this.GameDescriptionBox.Name = "GameDescriptionBox";
            this.GameDescriptionBox.SelectionMode = System.Windows.Forms.SelectionMode.None;
            this.GameDescriptionBox.Size = new System.Drawing.Size(331, 238);
            this.GameDescriptionBox.TabIndex = 14;
            // 
            // GameStudioLabel
            // 
            this.GameStudioLabel.AccessibleName = "GameStudioGames";
            this.GameStudioLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.GameStudioLabel.AutoSize = true;
            this.GameStudioLabel.BackColor = System.Drawing.Color.Transparent;
            this.GameStudioLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GameStudioLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.GameStudioLabel.Location = new System.Drawing.Point(526, 101);
            this.GameStudioLabel.Name = "GameStudioLabel";
            this.GameStudioLabel.Size = new System.Drawing.Size(125, 26);
            this.GameStudioLabel.TabIndex = 15;
            this.GameStudioLabel.Text = "Our Games";
            this.GameStudioLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.AccessibleName = "GameStudioAbout";
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label1.Location = new System.Drawing.Point(107, 101);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 26);
            this.label1.TabIndex = 16;
            this.label1.Text = "About Us";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // StudioPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(29)))), ((int)(((byte)(38)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.GameStudioLabel);
            this.Controls.Add(this.GameDescriptionBox);
            this.Controls.Add(this.GameResultsPanel);
            this.Controls.Add(this.GameTitleLabel);
            this.Name = "StudioPage";
            this.Text = "StudioPage";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label GameTitleLabel;
        private System.Windows.Forms.Panel GameResultsPanel;
        private System.Windows.Forms.ListBox GameDescriptionBox;
        private System.Windows.Forms.Label GameStudioLabel;
        private System.Windows.Forms.Label label1;
    }
}