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
            this.SaveButton = new System.Windows.Forms.Button();
            this.AddNumberTextBox = new System.Windows.Forms.TextBox();
            this.AddNumberToChosePeople = new System.Windows.Forms.Button();
            this.ComboBoxNumber = new System.Windows.Forms.ComboBox();
            this.PatronymicTextBox = new System.Windows.Forms.TextBox();
            this.FirstNameTextBox = new System.Windows.Forms.TextBox();
            this.SecondNameTextBox = new System.Windows.Forms.TextBox();
            this.BirthMark = new System.Windows.Forms.MaskedTextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.OpenFileDialogForAddImage = new System.Windows.Forms.OpenFileDialog();
            this.SelectFileButton = new System.Windows.Forms.Button();
            this.ErrorText = new System.Windows.Forms.Label();
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
            this.PanelRight.Controls.Add(this.ErrorText);
            this.PanelRight.Controls.Add(this.SelectFileButton);
            this.PanelRight.Controls.Add(this.SaveButton);
            this.PanelRight.Controls.Add(this.AddNumberTextBox);
            this.PanelRight.Controls.Add(this.AddNumberToChosePeople);
            this.PanelRight.Controls.Add(this.ComboBoxNumber);
            this.PanelRight.Controls.Add(this.PatronymicTextBox);
            this.PanelRight.Controls.Add(this.FirstNameTextBox);
            this.PanelRight.Controls.Add(this.SecondNameTextBox);
            this.PanelRight.Controls.Add(this.BirthMark);
            this.PanelRight.Controls.Add(this.pictureBox1);
            this.PanelRight.Location = new System.Drawing.Point(601, 67);
            this.PanelRight.Name = "PanelRight";
            this.PanelRight.Size = new System.Drawing.Size(350, 585);
            this.PanelRight.TabIndex = 3;
            this.PanelRight.Paint += new System.Windows.Forms.PaintEventHandler(this.PanelRight_Paint);
            // 
            // SaveButton
            // 
            this.SaveButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.SaveButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.SaveButton.Font = new System.Drawing.Font("Palatino Linotype", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SaveButton.Location = new System.Drawing.Point(227, 516);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(72, 26);
            this.SaveButton.TabIndex = 12;
            this.SaveButton.Text = "Save";
            this.SaveButton.UseVisualStyleBackColor = false;
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // AddNumberTextBox
            // 
            this.AddNumberTextBox.Location = new System.Drawing.Point(203, 202);
            this.AddNumberTextBox.Name = "AddNumberTextBox";
            this.AddNumberTextBox.Size = new System.Drawing.Size(129, 20);
            this.AddNumberTextBox.TabIndex = 11;
            // 
            // AddNumberToChosePeople
            // 
            this.AddNumberToChosePeople.BackColor = System.Drawing.Color.Blue;
            this.AddNumberToChosePeople.ForeColor = System.Drawing.Color.Snow;
            this.AddNumberToChosePeople.Location = new System.Drawing.Point(227, 228);
            this.AddNumberToChosePeople.Name = "AddNumberToChosePeople";
            this.AddNumberToChosePeople.Size = new System.Drawing.Size(81, 50);
            this.AddNumberToChosePeople.TabIndex = 10;
            this.AddNumberToChosePeople.Text = "Добавить номер";
            this.AddNumberToChosePeople.UseVisualStyleBackColor = false;
            this.AddNumberToChosePeople.MouseClick += new System.Windows.Forms.MouseEventHandler(this.AddNumberToChosePeople_MouseClick);
            // 
            // ComboBoxNumber
            // 
            this.ComboBoxNumber.FormattingEnabled = true;
            this.ComboBoxNumber.Location = new System.Drawing.Point(30, 201);
            this.ComboBoxNumber.Name = "ComboBoxNumber";
            this.ComboBoxNumber.Size = new System.Drawing.Size(162, 21);
            this.ComboBoxNumber.TabIndex = 9;
            // 
            // PatronymicTextBox
            // 
            this.PatronymicTextBox.Location = new System.Drawing.Point(154, 128);
            this.PatronymicTextBox.Name = "PatronymicTextBox";
            this.PatronymicTextBox.Size = new System.Drawing.Size(177, 20);
            this.PatronymicTextBox.TabIndex = 8;
            this.PatronymicTextBox.Text = "Отчество";
            // 
            // FirstNameTextBox
            // 
            this.FirstNameTextBox.Location = new System.Drawing.Point(154, 42);
            this.FirstNameTextBox.Name = "FirstNameTextBox";
            this.FirstNameTextBox.Size = new System.Drawing.Size(178, 20);
            this.FirstNameTextBox.TabIndex = 7;
            this.FirstNameTextBox.Text = "Имя";
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
            // BirthMark
            // 
            this.BirthMark.Location = new System.Drawing.Point(50, 522);
            this.BirthMark.Mask = "00/00/0000";
            this.BirthMark.Name = "BirthMark";
            this.BirthMark.Size = new System.Drawing.Size(104, 20);
            this.BirthMark.TabIndex = 5;
            this.BirthMark.ValidatingType = typeof(System.DateTime);
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
            // OpenFileDialogForAddImage
            // 
            this.OpenFileDialogForAddImage.FileName = "openFileDialog1";
            this.OpenFileDialogForAddImage.FileOk += new System.ComponentModel.CancelEventHandler(this.OpenFileDialogForAddImage_FileOk);
            // 
            // SelectFileButton
            // 
            this.SelectFileButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SelectFileButton.Location = new System.Drawing.Point(38, 175);
            this.SelectFileButton.Name = "SelectFileButton";
            this.SelectFileButton.Size = new System.Drawing.Size(54, 20);
            this.SelectFileButton.TabIndex = 13;
            this.SelectFileButton.Text = "Обзор";
            this.SelectFileButton.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.SelectFileButton.UseVisualStyleBackColor = true;
            this.SelectFileButton.Click += new System.EventHandler(this.SelectFileButton_Click);
            // 
            // ErrorText
            // 
            this.ErrorText.AutoSize = true;
            this.ErrorText.ForeColor = System.Drawing.Color.Lime;
            this.ErrorText.Location = new System.Drawing.Point(31, 161);
            this.ErrorText.Name = "ErrorText";
            this.ErrorText.Size = new System.Drawing.Size(0, 13);
            this.ErrorText.TabIndex = 14;
            this.ErrorText.Click += new System.EventHandler(this.ErrorText_Click);
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
            this.MaximizeBox = false;
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
        public System.Windows.Forms.TextBox PatronymicTextBox;
        public System.Windows.Forms.TextBox FirstNameTextBox;
        public System.Windows.Forms.TextBox SecondNameTextBox;
        public System.Windows.Forms.Panel PanelRight;
        private System.Windows.Forms.ComboBox ComboBoxNumber;
        private System.Windows.Forms.Button AddNumberToChosePeople;
        private System.Windows.Forms.TextBox AddNumberTextBox;
        private System.Windows.Forms.Button SaveButton;
        private System.Windows.Forms.OpenFileDialog OpenFileDialogForAddImage;
        private System.Windows.Forms.Button SelectFileButton;
        private System.Windows.Forms.Label ErrorText;
    }
}