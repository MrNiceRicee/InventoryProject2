namespace InventoryProject.Forms
{
    partial class AdminPage
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
            this.ModeSelection = new System.Windows.Forms.ComboBox();
            this.ModeLabel = new System.Windows.Forms.Label();
            this.AddTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.Notification = new System.Windows.Forms.TextBox();
            this.TextLabel7 = new System.Windows.Forms.TextBox();
            this.TextLabel6 = new System.Windows.Forms.TextBox();
            this.TextLabel5 = new System.Windows.Forms.TextBox();
            this.TextLabel4 = new System.Windows.Forms.TextBox();
            this.TextLabel3 = new System.Windows.Forms.TextBox();
            this.TextLabel2 = new System.Windows.Forms.TextBox();
            this.TextLabel1 = new System.Windows.Forms.TextBox();
            this.TextBox1 = new System.Windows.Forms.TextBox();
            this.TextBox2 = new System.Windows.Forms.TextBox();
            this.TextBox4 = new System.Windows.Forms.TextBox();
            this.TextBox5 = new System.Windows.Forms.TextBox();
            this.TextBox6 = new System.Windows.Forms.TextBox();
            this.TextBox7 = new System.Windows.Forms.TextBox();
            this.ConfirmButton = new System.Windows.Forms.Button();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.ComboBoxLayOut = new System.Windows.Forms.ComboBox();
            this.AddTableLayoutPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // ModeSelection
            // 
            this.ModeSelection.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ModeSelection.FormattingEnabled = true;
            this.ModeSelection.Items.AddRange(new object[] {
            "Add Game",
            "Edit Game",
            "Remove Game",
            "Add User",
            "Edit User",
            "Remove User"});
            this.ModeSelection.Location = new System.Drawing.Point(623, 57);
            this.ModeSelection.Name = "ModeSelection";
            this.ModeSelection.Size = new System.Drawing.Size(165, 21);
            this.ModeSelection.TabIndex = 2;
            this.ModeSelection.SelectionChangeCommitted += new System.EventHandler(this.ModeSelect);
            // 
            // ModeLabel
            // 
            this.ModeLabel.AccessibleName = "Mode";
            this.ModeLabel.AutoSize = true;
            this.ModeLabel.BackColor = System.Drawing.Color.Transparent;
            this.ModeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ModeLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ModeLabel.Location = new System.Drawing.Point(618, 29);
            this.ModeLabel.Name = "ModeLabel";
            this.ModeLabel.Size = new System.Drawing.Size(62, 25);
            this.ModeLabel.TabIndex = 5;
            this.ModeLabel.Text = "Mode";
            // 
            // AddTableLayoutPanel
            // 
            this.AddTableLayoutPanel.ColumnCount = 2;
            this.AddTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.AddTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.AddTableLayoutPanel.Controls.Add(this.ComboBoxLayOut, 1, 2);
            this.AddTableLayoutPanel.Controls.Add(this.Notification, 0, 7);
            this.AddTableLayoutPanel.Controls.Add(this.TextLabel7, 0, 6);
            this.AddTableLayoutPanel.Controls.Add(this.TextLabel6, 0, 5);
            this.AddTableLayoutPanel.Controls.Add(this.TextLabel5, 0, 4);
            this.AddTableLayoutPanel.Controls.Add(this.TextLabel4, 0, 3);
            this.AddTableLayoutPanel.Controls.Add(this.TextLabel3, 0, 2);
            this.AddTableLayoutPanel.Controls.Add(this.TextLabel2, 0, 1);
            this.AddTableLayoutPanel.Controls.Add(this.TextLabel1, 0, 0);
            this.AddTableLayoutPanel.Controls.Add(this.TextBox1, 1, 0);
            this.AddTableLayoutPanel.Controls.Add(this.TextBox2, 1, 1);
            this.AddTableLayoutPanel.Controls.Add(this.TextBox4, 1, 3);
            this.AddTableLayoutPanel.Controls.Add(this.TextBox5, 1, 4);
            this.AddTableLayoutPanel.Controls.Add(this.TextBox6, 1, 5);
            this.AddTableLayoutPanel.Controls.Add(this.TextBox7, 1, 6);
            this.AddTableLayoutPanel.Controls.Add(this.ConfirmButton, 1, 7);
            this.AddTableLayoutPanel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddTableLayoutPanel.Location = new System.Drawing.Point(46, 57);
            this.AddTableLayoutPanel.Name = "AddTableLayoutPanel";
            this.AddTableLayoutPanel.RowCount = 8;
            this.AddTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.AddTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.AddTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.AddTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.AddTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.AddTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.AddTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.AddTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.AddTableLayoutPanel.Size = new System.Drawing.Size(430, 294);
            this.AddTableLayoutPanel.TabIndex = 6;
            this.AddTableLayoutPanel.Visible = false;
            // 
            // Notification
            // 
            this.Notification.Location = new System.Drawing.Point(3, 255);
            this.Notification.Name = "Notification";
            this.Notification.ReadOnly = true;
            this.Notification.Size = new System.Drawing.Size(209, 30);
            this.Notification.TabIndex = 16;
            // 
            // TextLabel7
            // 
            this.TextLabel7.Location = new System.Drawing.Point(3, 219);
            this.TextLabel7.Name = "TextLabel7";
            this.TextLabel7.ReadOnly = true;
            this.TextLabel7.Size = new System.Drawing.Size(209, 30);
            this.TextLabel7.TabIndex = 14;
            // 
            // TextLabel6
            // 
            this.TextLabel6.Location = new System.Drawing.Point(3, 183);
            this.TextLabel6.Name = "TextLabel6";
            this.TextLabel6.ReadOnly = true;
            this.TextLabel6.Size = new System.Drawing.Size(209, 30);
            this.TextLabel6.TabIndex = 13;
            // 
            // TextLabel5
            // 
            this.TextLabel5.Location = new System.Drawing.Point(3, 147);
            this.TextLabel5.Name = "TextLabel5";
            this.TextLabel5.ReadOnly = true;
            this.TextLabel5.Size = new System.Drawing.Size(209, 30);
            this.TextLabel5.TabIndex = 12;
            // 
            // TextLabel4
            // 
            this.TextLabel4.Location = new System.Drawing.Point(3, 111);
            this.TextLabel4.Name = "TextLabel4";
            this.TextLabel4.ReadOnly = true;
            this.TextLabel4.Size = new System.Drawing.Size(209, 30);
            this.TextLabel4.TabIndex = 11;
            // 
            // TextLabel3
            // 
            this.TextLabel3.Location = new System.Drawing.Point(3, 75);
            this.TextLabel3.Name = "TextLabel3";
            this.TextLabel3.ReadOnly = true;
            this.TextLabel3.Size = new System.Drawing.Size(209, 30);
            this.TextLabel3.TabIndex = 10;
            // 
            // TextLabel2
            // 
            this.TextLabel2.Location = new System.Drawing.Point(3, 39);
            this.TextLabel2.Name = "TextLabel2";
            this.TextLabel2.ReadOnly = true;
            this.TextLabel2.Size = new System.Drawing.Size(209, 30);
            this.TextLabel2.TabIndex = 9;
            // 
            // TextLabel1
            // 
            this.TextLabel1.Location = new System.Drawing.Point(3, 3);
            this.TextLabel1.Name = "TextLabel1";
            this.TextLabel1.ReadOnly = true;
            this.TextLabel1.Size = new System.Drawing.Size(209, 30);
            this.TextLabel1.TabIndex = 8;
            // 
            // TextBox1
            // 
            this.TextBox1.Location = new System.Drawing.Point(218, 3);
            this.TextBox1.Name = "TextBox1";
            this.TextBox1.Size = new System.Drawing.Size(209, 30);
            this.TextBox1.TabIndex = 0;
            // 
            // TextBox2
            // 
            this.TextBox2.Location = new System.Drawing.Point(218, 39);
            this.TextBox2.Name = "TextBox2";
            this.TextBox2.Size = new System.Drawing.Size(209, 30);
            this.TextBox2.TabIndex = 1;
            // 
            // TextBox4
            // 
            this.TextBox4.Location = new System.Drawing.Point(218, 111);
            this.TextBox4.Name = "TextBox4";
            this.TextBox4.Size = new System.Drawing.Size(209, 30);
            this.TextBox4.TabIndex = 3;
            // 
            // TextBox5
            // 
            this.TextBox5.Location = new System.Drawing.Point(218, 147);
            this.TextBox5.Name = "TextBox5";
            this.TextBox5.Size = new System.Drawing.Size(209, 30);
            this.TextBox5.TabIndex = 4;
            // 
            // TextBox6
            // 
            this.TextBox6.Location = new System.Drawing.Point(218, 183);
            this.TextBox6.Name = "TextBox6";
            this.TextBox6.Size = new System.Drawing.Size(209, 30);
            this.TextBox6.TabIndex = 5;
            // 
            // TextBox7
            // 
            this.TextBox7.Location = new System.Drawing.Point(218, 219);
            this.TextBox7.Name = "TextBox7";
            this.TextBox7.Size = new System.Drawing.Size(209, 30);
            this.TextBox7.TabIndex = 6;
            // 
            // ConfirmButton
            // 
            this.ConfirmButton.Location = new System.Drawing.Point(218, 255);
            this.ConfirmButton.Name = "ConfirmButton";
            this.ConfirmButton.Size = new System.Drawing.Size(209, 36);
            this.ConfirmButton.TabIndex = 15;
            this.ConfirmButton.Text = "Confirm";
            this.ConfirmButton.UseVisualStyleBackColor = true;
            this.ConfirmButton.Click += new System.EventHandler(this.ConfirmButton_Click);
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(500, 61);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(85, 17);
            this.radioButton1.TabIndex = 7;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "radioButton1";
            this.radioButton1.UseVisualStyleBackColor = true;
            this.radioButton1.Visible = false;
            this.radioButton1.Click += new System.EventHandler(this.RadioButton_Click);
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(500, 83);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(85, 17);
            this.radioButton2.TabIndex = 8;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "radioButton2";
            this.radioButton2.UseVisualStyleBackColor = true;
            this.radioButton2.Visible = false;
            this.radioButton2.Click += new System.EventHandler(this.RadioButton_Click);
            // 
            // ComboBoxLayOut
            // 
            this.ComboBoxLayOut.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComboBoxLayOut.FormattingEnabled = true;
            this.ComboBoxLayOut.Items.AddRange(new object[] {
            "Add Game",
            "Edit Game",
            "Remove Game",
            "Add User",
            "Edit User",
            "Remove User"});
            this.ComboBoxLayOut.Location = new System.Drawing.Point(218, 75);
            this.ComboBoxLayOut.Name = "ComboBoxLayOut";
            this.ComboBoxLayOut.Size = new System.Drawing.Size(209, 33);
            this.ComboBoxLayOut.TabIndex = 9;
            // 
            // AdminPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.radioButton2);
            this.Controls.Add(this.radioButton1);
            this.Controls.Add(this.AddTableLayoutPanel);
            this.Controls.Add(this.ModeLabel);
            this.Controls.Add(this.ModeSelection);
            this.Name = "AdminPage";
            this.Text = "AdminPage";
            this.AddTableLayoutPanel.ResumeLayout(false);
            this.AddTableLayoutPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox ModeSelection;
        private System.Windows.Forms.Label ModeLabel;
        private System.Windows.Forms.TableLayoutPanel AddTableLayoutPanel;
        private System.Windows.Forms.TextBox TextBox1;
        private System.Windows.Forms.TextBox TextBox2;
        private System.Windows.Forms.TextBox TextBox4;
        private System.Windows.Forms.TextBox TextBox5;
        private System.Windows.Forms.TextBox TextLabel7;
        private System.Windows.Forms.TextBox TextLabel6;
        private System.Windows.Forms.TextBox TextLabel5;
        private System.Windows.Forms.TextBox TextLabel4;
        private System.Windows.Forms.TextBox TextLabel3;
        private System.Windows.Forms.TextBox TextLabel2;
        private System.Windows.Forms.TextBox TextLabel1;
        private System.Windows.Forms.TextBox TextBox6;
        private System.Windows.Forms.TextBox TextBox7;
        private System.Windows.Forms.Button ConfirmButton;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.TextBox Notification;
        private System.Windows.Forms.ComboBox ComboBoxLayOut;
    }
}