namespace InventoryProject.Forms
{
    partial class GameCart
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
            this.InCartPanel = new System.Windows.Forms.Panel();
            this.InCartLabel = new System.Windows.Forms.Label();
            this.SubTotal = new System.Windows.Forms.Label();
            this.GameBuyButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // InCartPanel
            // 
            this.InCartPanel.AccessibleDescription = "";
            this.InCartPanel.AccessibleName = "InCartPanel";
            this.InCartPanel.AutoScroll = true;
            this.InCartPanel.AutoScrollMargin = new System.Drawing.Size(0, 2);
            this.InCartPanel.BackColor = System.Drawing.Color.Transparent;
            this.InCartPanel.Location = new System.Drawing.Point(71, 38);
            this.InCartPanel.Name = "InCartPanel";
            this.InCartPanel.Padding = new System.Windows.Forms.Padding(0, 3, 0, 3);
            this.InCartPanel.Size = new System.Drawing.Size(526, 311);
            this.InCartPanel.TabIndex = 3;
            // 
            // InCartLabel
            // 
            this.InCartLabel.AccessibleName = "InCartLabel";
            this.InCartLabel.AutoSize = true;
            this.InCartLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InCartLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.InCartLabel.Location = new System.Drawing.Point(249, 4);
            this.InCartLabel.Name = "InCartLabel";
            this.InCartLabel.Size = new System.Drawing.Size(136, 31);
            this.InCartLabel.TabIndex = 4;
            this.InCartLabel.Text = "Cart (100)";
            // 
            // SubTotal
            // 
            this.SubTotal.AccessibleName = "SubTotal";
            this.SubTotal.AutoSize = true;
            this.SubTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SubTotal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.SubTotal.Location = new System.Drawing.Point(291, 365);
            this.SubTotal.Name = "SubTotal";
            this.SubTotal.Size = new System.Drawing.Size(67, 20);
            this.SubTotal.TabIndex = 5;
            this.SubTotal.Text = "$100.00";
            // 
            // GameBuyButton
            // 
            this.GameBuyButton.AccessibleName = "GameBuyButton";
            this.GameBuyButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(28)))), ((int)(((byte)(39)))));
            this.GameBuyButton.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.GameBuyButton.FlatAppearance.BorderSize = 0;
            this.GameBuyButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GameBuyButton.ForeColor = System.Drawing.Color.White;
            this.GameBuyButton.Location = new System.Drawing.Point(11, 402);
            this.GameBuyButton.Margin = new System.Windows.Forms.Padding(2);
            this.GameBuyButton.Name = "GameBuyButton";
            this.GameBuyButton.Size = new System.Drawing.Size(633, 44);
            this.GameBuyButton.TabIndex = 13;
            this.GameBuyButton.Text = "Buy Games";
            this.GameBuyButton.UseVisualStyleBackColor = false;
            this.GameBuyButton.Click += new System.EventHandler(this.CustomItem_MouseClick);
            // 
            // GameCart
            // 
            this.AccessibleDescription = "In Game Cart";
            this.AccessibleName = "GameCart";
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(29)))), ((int)(((byte)(38)))));
            this.ClientSize = new System.Drawing.Size(655, 457);
            this.Controls.Add(this.GameBuyButton);
            this.Controls.Add(this.SubTotal);
            this.Controls.Add(this.InCartLabel);
            this.Controls.Add(this.InCartPanel);
            this.Name = "GameCart";
            this.Text = "Cart";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel InCartPanel;
        private System.Windows.Forms.Label InCartLabel;
        private System.Windows.Forms.Label SubTotal;
        private System.Windows.Forms.Button GameBuyButton;
    }
}