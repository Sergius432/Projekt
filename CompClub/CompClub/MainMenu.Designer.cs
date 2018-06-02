namespace CompClub
{
    partial class MainMemu
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
            this.label1 = new System.Windows.Forms.Label();
            this.GO = new System.Windows.Forms.Button();
            this.CreateAK = new System.Windows.Forms.Button();
            this.GOOUT = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(29, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(568, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "Добро пожаловать в компьютерный клуб";
            // 
            // GO
            // 
            this.GO.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.GO.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold);
            this.GO.ForeColor = System.Drawing.Color.White;
            this.GO.Location = new System.Drawing.Point(180, 147);
            this.GO.Name = "GO";
            this.GO.Size = new System.Drawing.Size(250, 38);
            this.GO.TabIndex = 5;
            this.GO.Text = "Войти";
            this.GO.UseVisualStyleBackColor = false;
            this.GO.Click += new System.EventHandler(this.GO_Click);
            // 
            // CreateAK
            // 
            this.CreateAK.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.CreateAK.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold);
            this.CreateAK.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.CreateAK.Location = new System.Drawing.Point(180, 212);
            this.CreateAK.Name = "CreateAK";
            this.CreateAK.Size = new System.Drawing.Size(250, 37);
            this.CreateAK.TabIndex = 6;
            this.CreateAK.Text = "Зарегистрироваться";
            this.CreateAK.UseVisualStyleBackColor = false;
            this.CreateAK.Click += new System.EventHandler(this.CreateAK_Click);
            // 
            // GOOUT
            // 
            this.GOOUT.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.GOOUT.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold);
            this.GOOUT.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.GOOUT.Location = new System.Drawing.Point(180, 274);
            this.GOOUT.Name = "GOOUT";
            this.GOOUT.Size = new System.Drawing.Size(250, 37);
            this.GOOUT.TabIndex = 7;
            this.GOOUT.Text = "Выйти";
            this.GOOUT.UseVisualStyleBackColor = false;
            this.GOOUT.Click += new System.EventHandler(this.GOOUT_Click);
            // 
            // MainMemu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::CompClub.Properties.Resources.elitefon_ru_149;
            this.ClientSize = new System.Drawing.Size(626, 430);
            this.Controls.Add(this.GOOUT);
            this.Controls.Add(this.CreateAK);
            this.Controls.Add(this.GO);
            this.Controls.Add(this.label1);
            this.MaximumSize = new System.Drawing.Size(642, 469);
            this.MinimumSize = new System.Drawing.Size(642, 469);
            this.Name = "MainMemu";
            this.Text = "MainMenu";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainMemu_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button GO;
        private System.Windows.Forms.Button CreateAK;
        private System.Windows.Forms.Button GOOUT;
    }
}

