namespace CompClub
{
    partial class Registration
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.SaveUser = new System.Windows.Forms.Button();
            this.ComeBake = new System.Windows.Forms.Button();
            this.See = new System.Windows.Forms.Button();
            this.Look = new System.Windows.Forms.Button();
            this.Clear = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.textBox1.Location = new System.Drawing.Point(223, 84);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(180, 26);
            this.textBox1.TabIndex = 1;
            // 
            // textBox2
            // 
            this.textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.textBox2.Location = new System.Drawing.Point(223, 147);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(180, 26);
            this.textBox2.TabIndex = 2;
            // 
            // textBox3
            // 
            this.textBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.textBox3.Location = new System.Drawing.Point(223, 210);
            this.textBox3.Name = "textBox3";
            this.textBox3.PasswordChar = '*';
            this.textBox3.Size = new System.Drawing.Size(180, 26);
            this.textBox3.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(105, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(310, 24);
            this.label1.TabIndex = 4;
            this.label1.Text = "Создай учетную запись для игры";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(141, 86);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "Логин:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(143, 151);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 20);
            this.label3.TabIndex = 6;
            this.label3.Text = "Почта:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.Location = new System.Drawing.Point(136, 213);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 20);
            this.label4.TabIndex = 7;
            this.label4.Text = "Пароль:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label5.Location = new System.Drawing.Point(12, 257);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(198, 20);
            this.label5.TabIndex = 8;
            this.label5.Text = "Подтверждение пароля:";
            // 
            // textBox4
            // 
            this.textBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.textBox4.Location = new System.Drawing.Point(223, 253);
            this.textBox4.Name = "textBox4";
            this.textBox4.PasswordChar = '*';
            this.textBox4.Size = new System.Drawing.Size(181, 26);
            this.textBox4.TabIndex = 9;
            // 
            // SaveUser
            // 
            this.SaveUser.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.SaveUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.SaveUser.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.SaveUser.Location = new System.Drawing.Point(353, 322);
            this.SaveUser.Name = "SaveUser";
            this.SaveUser.Size = new System.Drawing.Size(166, 35);
            this.SaveUser.TabIndex = 10;
            this.SaveUser.Text = "Заригистрировать";
            this.SaveUser.UseVisualStyleBackColor = false;
            this.SaveUser.Click += new System.EventHandler(this.SaveUser_Click);
            // 
            // ComeBake
            // 
            this.ComeBake.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ComeBake.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.ComeBake.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ComeBake.Location = new System.Drawing.Point(1, 323);
            this.ComeBake.Name = "ComeBake";
            this.ComeBake.Size = new System.Drawing.Size(144, 34);
            this.ComeBake.TabIndex = 11;
            this.ComeBake.Text = "назад";
            this.ComeBake.UseVisualStyleBackColor = false;
            this.ComeBake.Click += new System.EventHandler(this.ComeBake_Click);
            // 
            // See
            // 
            this.See.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.See.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.See.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.See.Location = new System.Drawing.Point(410, 210);
            this.See.Name = "See";
            this.See.Size = new System.Drawing.Size(32, 26);
            this.See.TabIndex = 12;
            this.See.Text = "*";
            this.See.UseVisualStyleBackColor = false;
            this.See.MouseDown += new System.Windows.Forms.MouseEventHandler(this.See_MouseDown);
            this.See.MouseUp += new System.Windows.Forms.MouseEventHandler(this.See_MouseUp);
            // 
            // Look
            // 
            this.Look.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Look.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.Look.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Look.Location = new System.Drawing.Point(410, 253);
            this.Look.Name = "Look";
            this.Look.Size = new System.Drawing.Size(32, 26);
            this.Look.TabIndex = 13;
            this.Look.Text = "*";
            this.Look.UseVisualStyleBackColor = false;
            this.Look.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Look_MouseDown);
            this.Look.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Look_MouseUp);
            // 
            // Clear
            // 
            this.Clear.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Clear.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.Clear.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Clear.Location = new System.Drawing.Point(169, 322);
            this.Clear.Name = "Clear";
            this.Clear.Size = new System.Drawing.Size(161, 35);
            this.Clear.TabIndex = 14;
            this.Clear.Text = "Очистить форму";
            this.Clear.UseVisualStyleBackColor = false;
            this.Clear.Click += new System.EventHandler(this.Clear_Click);
            // 
            // Registration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::CompClub.Properties.Resources._807864_1423970400;
            this.ClientSize = new System.Drawing.Size(519, 359);
            this.Controls.Add(this.Clear);
            this.Controls.Add(this.Look);
            this.Controls.Add(this.See);
            this.Controls.Add(this.ComeBake);
            this.Controls.Add(this.SaveUser);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Name = "Registration";
            this.Text = "Registration";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Registration_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Button SaveUser;
        private System.Windows.Forms.Button ComeBake;
        private System.Windows.Forms.Button See;
        private System.Windows.Forms.Button Look;
        private System.Windows.Forms.Button Clear;
    }
}