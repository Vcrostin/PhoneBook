namespace PhoneBook
{
    partial class AdditonForm
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
            this.NameW = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.PhoneName = new System.Windows.Forms.TextBox();
            this.PhoneNumber = new System.Windows.Forms.TextBox();
            this.CreateButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // NameW
            // 
            this.NameW.Location = new System.Drawing.Point(86, 9);
            this.NameW.Name = "NameW";
            this.NameW.Size = new System.Drawing.Size(339, 23);
            this.NameW.TabIndex = 0;
            this.NameW.Text = "Введите имя нового контакта";
            this.NameW.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(86, 75);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(339, 23);
            this.label1.TabIndex = 2;
            this.label1.Text = "Введите номер телефона";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // PhoneName
            // 
            this.PhoneName.Location = new System.Drawing.Point(89, 35);
            this.PhoneName.Name = "PhoneName";
            this.PhoneName.Size = new System.Drawing.Size(336, 20);
            this.PhoneName.TabIndex = 3;
            this.PhoneName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // PhoneNumber
            // 
            this.PhoneNumber.Location = new System.Drawing.Point(89, 102);
            this.PhoneNumber.Name = "PhoneNumber";
            this.PhoneNumber.Size = new System.Drawing.Size(336, 20);
            this.PhoneNumber.TabIndex = 4;
            // 
            // CreateButton
            // 
            this.CreateButton.BackColor = System.Drawing.Color.White;
            this.CreateButton.Location = new System.Drawing.Point(216, 128);
            this.CreateButton.Name = "CreateButton";
            this.CreateButton.Size = new System.Drawing.Size(67, 23);
            this.CreateButton.TabIndex = 5;
            this.CreateButton.Text = "Create";
            this.CreateButton.UseVisualStyleBackColor = false;
            this.CreateButton.Click += new System.EventHandler(this.CreateButton_Click);
            // 
            // AdditonForm
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(502, 196);
            this.ControlBox = false;
            this.Controls.Add(this.CreateButton);
            this.Controls.Add(this.PhoneNumber);
            this.Controls.Add(this.PhoneName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.NameW);
            this.Name = "AdditonForm";
            this.Text = "AdditonForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label NameW;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button CreateButton;
        public System.Windows.Forms.TextBox PhoneName;
        public System.Windows.Forms.TextBox PhoneNumber;
    }
}