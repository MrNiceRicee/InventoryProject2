namespace InventoryProject.Forms
{
    partial class BrowseStore
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
            this.GameResultsPanel = new System.Windows.Forms.Panel();
            this.GameNameSearchBox = new System.Windows.Forms.TextBox();
            this.SearchButton = new System.Windows.Forms.Button();
            this.GenreCheckList = new System.Windows.Forms.CheckedListBox();
            this.FilterBox = new System.Windows.Forms.ComboBox();
            this.OwnedRadio = new System.Windows.Forms.RadioButton();
            this.NotOwnedRadio = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // GameResultsPanel
            // 
            this.GameResultsPanel.AccessibleDescription = "Shows Results";
            this.GameResultsPanel.AccessibleName = "GameResultsPanel";
            this.GameResultsPanel.AutoScroll = true;
            this.GameResultsPanel.AutoScrollMargin = new System.Drawing.Size(0, 2);
            this.GameResultsPanel.BackColor = System.Drawing.Color.Transparent;
            this.GameResultsPanel.Location = new System.Drawing.Point(12, 75);
            this.GameResultsPanel.Name = "GameResultsPanel";
            this.GameResultsPanel.Padding = new System.Windows.Forms.Padding(0, 3, 0, 3);
            this.GameResultsPanel.Size = new System.Drawing.Size(439, 348);
            this.GameResultsPanel.TabIndex = 3;
            this.GameResultsPanel.Scroll += new System.Windows.Forms.ScrollEventHandler(this.GameResultsPanel_Scroll);
            this.GameResultsPanel.MouseEnter += new System.EventHandler(this.GameResultsPanel_Scroll);
            this.GameResultsPanel.MouseHover += new System.EventHandler(this.GameResultsPanel_Scroll);
            // 
            // GameNameSearchBox
            // 
            this.GameNameSearchBox.AccessibleName = "GameNameSearchBox";
            this.GameNameSearchBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(190)))), ((int)(((byte)(200)))));
            this.GameNameSearchBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GameNameSearchBox.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.GameNameSearchBox.Location = new System.Drawing.Point(0, 40);
            this.GameNameSearchBox.Name = "GameNameSearchBox";
            this.GameNameSearchBox.Size = new System.Drawing.Size(776, 26);
            this.GameNameSearchBox.TabIndex = 5;
            this.GameNameSearchBox.Text = "Search Game Title or Studio";
            this.GameNameSearchBox.Enter += new System.EventHandler(this.SearchBoxEnter);
            this.GameNameSearchBox.Leave += new System.EventHandler(this.SearchBoxLeave);
            // 
            // SearchButton
            // 
            this.SearchButton.AccessibleName = "SearchButton";
            this.SearchButton.BackColor = System.Drawing.Color.Gray;
            this.SearchButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SearchButton.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.SearchButton.Location = new System.Drawing.Point(457, 368);
            this.SearchButton.Name = "SearchButton";
            this.SearchButton.Size = new System.Drawing.Size(331, 55);
            this.SearchButton.TabIndex = 5;
            this.SearchButton.Text = "Search";
            this.SearchButton.UseVisualStyleBackColor = false;
            this.SearchButton.Click += new System.EventHandler(this.SearchGames);
            // 
            // GenreCheckList
            // 
            this.GenreCheckList.AccessibleName = "GenreCheckList";
            this.GenreCheckList.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(29)))), ((int)(((byte)(38)))));
            this.GenreCheckList.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GenreCheckList.ForeColor = System.Drawing.SystemColors.MenuBar;
            this.GenreCheckList.FormattingEnabled = true;
            this.GenreCheckList.Items.AddRange(new object[] {
            "Genre1",
            "Genre2",
            "Genre3",
            "Genre1",
            "Genre2",
            "Genre3",
            "Genre1",
            "Genre2",
            "Genre3"});
            this.GenreCheckList.Location = new System.Drawing.Point(457, 75);
            this.GenreCheckList.MultiColumn = true;
            this.GenreCheckList.Name = "GenreCheckList";
            this.GenreCheckList.Size = new System.Drawing.Size(341, 76);
            this.GenreCheckList.TabIndex = 6;
            // 
            // FilterBox
            // 
            this.FilterBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(190)))), ((int)(((byte)(200)))));
            this.FilterBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.FilterBox.ForeColor = System.Drawing.SystemColors.MenuText;
            this.FilterBox.FormattingEnabled = true;
            this.FilterBox.Items.AddRange(new object[] {
            "Alphabetical (A-Z)",
            "Alphabetical (Z-A)",
            "Price ($-$$$)",
            "Price ($$$-$)",
            "Publish Date (Old - New)",
            "Publish Date (New - Old)",
            "Most Liked",
            "Least Liked",
            "Most Popular",
            "Least Popular"});
            this.FilterBox.Location = new System.Drawing.Point(456, 217);
            this.FilterBox.Margin = new System.Windows.Forms.Padding(2);
            this.FilterBox.Name = "FilterBox";
            this.FilterBox.Size = new System.Drawing.Size(341, 21);
            this.FilterBox.TabIndex = 7;
            // 
            // OwnedRadio
            // 
            this.OwnedRadio.AutoSize = true;
            this.OwnedRadio.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OwnedRadio.ForeColor = System.Drawing.SystemColors.MenuBar;
            this.OwnedRadio.Location = new System.Drawing.Point(457, 158);
            this.OwnedRadio.Name = "OwnedRadio";
            this.OwnedRadio.Size = new System.Drawing.Size(133, 24);
            this.OwnedRadio.TabIndex = 8;
            this.OwnedRadio.Text = "Include Owned";
            this.OwnedRadio.UseVisualStyleBackColor = true;
            this.OwnedRadio.Click += new System.EventHandler(this.OwnedRadioButton);
            // 
            // NotOwnedRadio
            // 
            this.NotOwnedRadio.AutoSize = true;
            this.NotOwnedRadio.Checked = true;
            this.NotOwnedRadio.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NotOwnedRadio.ForeColor = System.Drawing.SystemColors.MenuBar;
            this.NotOwnedRadio.Location = new System.Drawing.Point(457, 188);
            this.NotOwnedRadio.Name = "NotOwnedRadio";
            this.NotOwnedRadio.Size = new System.Drawing.Size(137, 24);
            this.NotOwnedRadio.TabIndex = 9;
            this.NotOwnedRadio.TabStop = true;
            this.NotOwnedRadio.Text = "Exclude Owned";
            this.NotOwnedRadio.UseVisualStyleBackColor = true;
            this.NotOwnedRadio.Click += new System.EventHandler(this.OwnedRadioButton);
            // 
            // BrowseStore
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(29)))), ((int)(((byte)(38)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.NotOwnedRadio);
            this.Controls.Add(this.OwnedRadio);
            this.Controls.Add(this.FilterBox);
            this.Controls.Add(this.GenreCheckList);
            this.Controls.Add(this.SearchButton);
            this.Controls.Add(this.GameNameSearchBox);
            this.Controls.Add(this.GameResultsPanel);
            this.Name = "BrowseStore";
            this.Text = "BrowseStore";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel GameResultsPanel;
        private System.Windows.Forms.TextBox GameNameSearchBox;
        private System.Windows.Forms.Button SearchButton;
        private System.Windows.Forms.CheckedListBox GenreCheckList;
        private System.Windows.Forms.ComboBox FilterBox;
        private System.Windows.Forms.RadioButton OwnedRadio;
        private System.Windows.Forms.RadioButton NotOwnedRadio;
    }
}