namespace PhoneBook
{
    partial class Pages
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
            this.PanelLeft = new System.Windows.Forms.Panel();
            this.RefreshButton = new System.Windows.Forms.Button();
            this.AddButton = new System.Windows.Forms.Button();
            this.PanelRight = new System.Windows.Forms.Panel();
            this.ListPhoneBox = new System.Windows.Forms.ListBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.BirthMark = new System.Windows.Forms.MaskedTextBox();
            this.SecondNameTextBox = new System.Windows.Forms.TextBox();
            this.FirstNameTextBox = new System.Windows.Forms.TextBox();
            this.PatronymicTextBox = new System.Windows.Forms.TextBox();
            this.PanelLeft.SuspendLayout();
            this.PanelRight.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // PanelLeft
            // 
            this.PanelLeft.AutoScroll = true;
            this.PanelLeft.BackColor = System.Drawing.Color.Khaki;
            this.PanelLeft.Controls.Add(this.RefreshButton);
            this.PanelLeft.Controls.Add(this.AddButton);
            this.PanelLeft.Location = new System.Drawing.Point(75, 48);
            this.PanelLeft.Name = "PanelLeft";
            this.PanelLeft.Size = new System.Drawing.Size(360, 605);
            this.PanelLeft.TabIndex = 2;
            // 
            // RefreshButton
            // 
            this.RefreshButton.FlatAppearance.BorderSize = 0;
            this.RefreshButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RefreshButton.Image = global::PhoneBook.Properties.Resources.RefreshButton;
            this.RefreshButton.Location = new System.Drawing.Point(140, 3);
            this.RefreshButton.Name = "RefreshButton";
            this.RefreshButton.Size = new System.Drawing.Size(23, 23);
            this.RefreshButton.TabIndex = 1;
            this.RefreshButton.UseVisualStyleBackColor = true;
            this.RefreshButton.Click += new System.EventHandler(this.Refresh_Click);
            // 
            // AddButton
            // 
            this.AddButton.BackColor = System.Drawing.Color.Red;
            this.AddButton.FlatAppearance.BorderColor = System.Drawing.Color.DarkGreen;
            this.AddButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AddButton.Location = new System.Drawing.Point(46, 3);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(75, 23);
            this.AddButton.TabIndex = 0;
            this.AddButton.Text = "Add";
            this.AddButton.UseVisualStyleBackColor = false;
            this.AddButton.MouseClick += new System.Windows.Forms.MouseEventHandler(this.AddButton_MouseClick);
            // 
            // PanelRight
            // 
            this.PanelRight.Controls.Add(this.PatronymicTextBox);
            this.PanelRight.Controls.Add(this.FirstNameTextBox);
            this.PanelRight.Controls.Add(this.SecondNameTextBox);
            this.PanelRight.Controls.Add(this.BirthMark);
            this.PanelRight.Controls.Add(this.ListPhoneBox);
            this.PanelRight.Controls.Add(this.pictureBox1);
            this.PanelRight.Location = new System.Drawing.Point(601, 67);
            this.PanelRight.Name = "PanelRight";
            this.PanelRight.Size = new System.Drawing.Size(350, 585);
            this.PanelRight.TabIndex = 3;
            // 
            // ListPhoneBox
            // 
            this.ListPhoneBox.FormatString = "N0";
            this.ListPhoneBox.FormattingEnabled = true;
            this.ListPhoneBox.Location = new System.Drawing.Point(32, 189);
            this.ListPhoneBox.Name = "ListPhoneBox";
            this.ListPhoneBox.SelectionMode = System.Windows.Forms.SelectionMode.None;
            this.ListPhoneBox.Size = new System.Drawing.Size(197, 108);
            this.ListPhoneBox.TabIndex = 4;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::PhoneBook.Properties.Resources.unnamed;
            this.pictureBox1.Location = new System.Drawing.Point(30, 36);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(94, 112);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.WaitOnLoad = true;
            // 
            // BirthMark
            // 
            this.BirthMark.Location = new System.Drawing.Point(50, 522);
            this.BirthMark.Mask = "00/00/0000";
            this.BirthMark.Name = "BirthMark";
            this.BirthMark.Size = new System.Drawing.Size(104, 20);
            this.BirthMark.TabIndex = 5;
            this.BirthMark.ValidatingType = typeof(System.DateTime);
            // 
            // SecondNameTextBox
            // 
            this.SecondNameTextBox.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.SecondNameTextBox.Location = new System.Drawing.Point(154, 84);
            this.SecondNameTextBox.Name = "SecondNameTextBox";
            this.SecondNameTextBox.Size = new System.Drawing.Size(178, 20);
            this.SecondNameTextBox.TabIndex = 6;
            this.SecondNameTextBox.Text = "Фамилия";
            // 
            // FirstNameTextBox
            // 
            this.FirstNameTextBox.Location = new System.Drawing.Point(154, 42);
            this.FirstNameTextBox.Name = "FirstNameTextBox";
            this.FirstNameTextBox.Size = new System.Drawing.Size(178, 20);
            this.FirstNameTextBox.TabIndex = 7;
            this.FirstNameTextBox.Text = "Имя";
            // 
            // PatronymicTextBox
            // 
            this.PatronymicTextBox.Location = new System.Drawing.Point(154, 128);
            this.PatronymicTextBox.Name = "PatronymicTextBox";
            this.PatronymicTextBox.Size = new System.Drawing.Size(177, 20);
            this.PatronymicTextBox.TabIndex = 8;
            this.PatronymicTextBox.Text = "Отчество";
            // 
            // Pages
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = global::PhoneBook.Properties.Resources.Pages23;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(1016, 721);
            this.Controls.Add(this.PanelRight);
            this.Controls.Add(this.PanelLeft);
            this.Name = "Pages";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pages";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Pages_FormClosed);
            this.PanelLeft.ResumeLayout(false);
            this.PanelRight.ResumeLayout(false);
            this.PanelRight.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel PanelLeft;
        private System.Windows.Forms.Button AddButton;
        private System.Windows.Forms.Button RefreshButton;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.MaskedTextBox BirthMark;
        public System.Windows.Forms.ListBox ListPhoneBox;
        public System.Windows.Forms.TextBox PatronymicTextBox;
        public System.Windows.Forms.TextBox FirstNameTextBox;
        public System.Windows.Forms.TextBox SecondNameTextBox;
        public System.Windows.Forms.Panel PanelRight;
    }
}