namespace CompClub
{
    partial class Aftorization
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
            this.Login = new System.Windows.Forms.TextBox();
            this.Password = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.GoGame = new System.Windows.Forms.Button();
            this.ComeBake = new System.Windows.Forms.Button();
            this.See = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Login
            // 
            this.Login.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.Login.Location = new System.Drawing.Point(119, 75);
            this.Login.MaxLength = 30;
            this.Login.Name = "Login";
            this.Login.Size = new System.Drawing.Size(215, 30);
            this.Login.TabIndex = 0;
            // 
            // Password
            // 
            this.Password.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.Password.Location = new System.Drawing.Point(119, 115);
            this.Password.MaxLength = 32;
            this.Password.Name = "Password";
            this.Password.PasswordChar = '*';
            this.Password.Size = new System.Drawing.Size(215, 30);
            this.Password.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Black;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(97, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(222, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "Форма авторизации";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label2.Location = new System.Drawing.Point(40, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 24);
            this.label2.TabIndex = 3;
            this.label2.Text = "Логин:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label3.Location = new System.Drawing.Point(27, 118);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 24);
            this.label3.TabIndex = 4;
            this.label3.Text = "Пароль:";
            // 
            // GoGame
            // 
            this.GoGame.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.GoGame.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold);
            this.GoGame.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.GoGame.Location = new System.Drawing.Point(304, 193);
            this.GoGame.Name = "GoGame";
            this.GoGame.Size = new System.Drawing.Size(96, 36);
            this.GoGame.TabIndex = 5;
            this.GoGame.Text = "Войти";
            this.GoGame.UseVisualStyleBackColor = false;
            this.GoGame.Click += new System.EventHandler(this.GoGame_Click);
            // 
            // ComeBake
            // 
            this.ComeBake.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ComeBake.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold);
            this.ComeBake.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.ComeBake.Location = new System.Drawing.Point(1, 192);
            this.ComeBake.Name = "ComeBake";
            this.ComeBake.Size = new System.Drawing.Size(106, 36);
            this.ComeBake.TabIndex = 6;
            this.ComeBake.Text = "Назад";
            this.ComeBake.UseVisualStyleBackColor = false;
            this.ComeBake.Click += new System.EventHandler(this.ComeBake_Click);
            // 
            // See
            // 
            this.See.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.See.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold);
            this.See.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.See.Location = new System.Drawing.Point(339, 115);
            this.See.Name = "See";
            this.See.Size = new System.Drawing.Size(38, 30);
            this.See.TabIndex = 7;
            this.See.Text = "*";
            this.See.UseVisualStyleBackColor = false;
            this.See.MouseDown += new System.Windows.Forms.MouseEventHandler(this.See_MouseDown);
            this.See.MouseUp += new System.Windows.Forms.MouseEventHandler(this.See_MouseUp);
            // 
            // Aftorization
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::CompClub.Properties.Resources.a588ca;
            this.ClientSize = new System.Drawing.Size(401, 230);
            this.Controls.Add(this.See);
            this.Controls.Add(this.ComeBake);
            this.Controls.Add(this.GoGame);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Password);
            this.Controls.Add(this.Login);
            this.MaximumSize = new System.Drawing.Size(417, 269);
            this.MinimumSize = new System.Drawing.Size(417, 269);
            this.Name = "Aftorization";
            this.Text = "Aftorization";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Aftorization_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Login;
        private System.Windows.Forms.TextBox Password;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button GoGame;
        private System.Windows.Forms.Button ComeBake;
        private System.Windows.Forms.Button See;
    }
}