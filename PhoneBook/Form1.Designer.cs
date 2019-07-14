namespace PhoneBook
{
    partial class MainWindow
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainWindow));
            this.Title = new System.Windows.Forms.Label();
            this.LoginW = new System.Windows.Forms.Label();
            this.PasswordW = new System.Windows.Forms.Label();
            this.LogIn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Title
            // 
            this.Title.BackColor = System.Drawing.Color.Transparent;
            this.Title.Font = new System.Drawing.Font("Microsoft New Tai Lue", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Title.ForeColor = System.Drawing.Color.Yellow;
            this.Title.Location = new System.Drawing.Point(192, 94);
            this.Title.Name = "Title";
            this.Title.Size = new System.Drawing.Size(465, 23);
            this.Title.TabIndex = 0;
            this.Title.Text = "Телефонная книга";
            this.Title.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LoginW
            // 
            this.LoginW.AutoSize = true;
            this.LoginW.BackColor = System.Drawing.Color.Transparent;
            this.LoginW.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LoginW.ForeColor = System.Drawing.Color.Yellow;
            this.LoginW.Location = new System.Drawing.Point(385, 240);
            this.LoginW.Name = "LoginW";
            this.LoginW.Size = new System.Drawing.Size(44, 18);
            this.LoginW.TabIndex = 1;
            this.LoginW.Text = "Login";
            // 
            // PasswordW
            // 
            this.PasswordW.AutoSize = true;
            this.PasswordW.BackColor = System.Drawing.Color.Transparent;
            this.PasswordW.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PasswordW.ForeColor = System.Drawing.Color.Yellow;
            this.PasswordW.Location = new System.Drawing.Point(369, 356);
            this.PasswordW.Name = "PasswordW";
            this.PasswordW.Size = new System.Drawing.Size(75, 18);
            this.PasswordW.TabIndex = 2;
            this.PasswordW.Text = "Password";
            // 
            // LogIn
            // 
            this.LogIn.BackColor = System.Drawing.Color.White;
            this.LogIn.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LogIn.Location = new System.Drawing.Point(350, 498);
            this.LogIn.Name = "LogIn";
            this.LogIn.Size = new System.Drawing.Size(108, 28);
            this.LogIn.TabIndex = 3;
            this.LogIn.Text = "Log in";
            this.LogIn.UseVisualStyleBackColor = false;
            this.LogIn.MouseClick += new System.Windows.Forms.MouseEventHandler(this.LogIn_MouseClick);
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::PhoneBook.Properties.Resources.MainView4;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(794, 801);
            this.Controls.Add(this.LogIn);
            this.Controls.Add(this.PasswordW);
            this.Controls.Add(this.LoginW);
            this.Controls.Add(this.Title);
            this.HelpButton = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.TransparencyKey = System.Drawing.SystemColors.Control;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Title;
        private System.Windows.Forms.Label LoginW;
        private System.Windows.Forms.Label PasswordW;
        private System.Windows.Forms.Button LogIn;
    }
}

