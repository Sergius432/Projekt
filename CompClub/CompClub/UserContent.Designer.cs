namespace CompClub
{
    partial class UserContent
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.SeeGame = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.GameCont = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewImageColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewButtonColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.Cash = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Yes = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.labelLogin = new System.Windows.Forms.Label();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.GameCont)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // SeeGame
            // 
            this.SeeGame.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.SeeGame.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.SeeGame.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.SeeGame.Location = new System.Drawing.Point(104, 51);
            this.SeeGame.Name = "SeeGame";
            this.SeeGame.Size = new System.Drawing.Size(303, 33);
            this.SeeGame.TabIndex = 0;
            this.SeeGame.Text = "Показать имеющиеся игры";
            this.SeeGame.UseVisualStyleBackColor = false;
            this.SeeGame.Click += new System.EventHandler(this.SeeGame_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.button2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button2.Location = new System.Drawing.Point(587, 51);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(196, 33);
            this.button2.TabIndex = 1;
            this.button2.Text = "Оплатить услуги";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // GameCont
            // 
            this.GameCont.AllowUserToDeleteRows = false;
            this.GameCont.AllowUserToResizeColumns = false;
            this.GameCont.AllowUserToResizeRows = false;
            this.GameCont.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.GameCont.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.GameCont.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GameCont.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5});
            this.GameCont.Location = new System.Drawing.Point(2, 126);
            this.GameCont.Name = "GameCont";
            this.GameCont.ReadOnly = true;
            this.GameCont.RowHeadersVisible = false;
            this.GameCont.Size = new System.Drawing.Size(545, 350);
            this.GameCont.TabIndex = 2;
            this.GameCont.Visible = false;
            this.GameCont.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.GameCont_CellContentClick);
            // 
            // Column1
            // 
            this.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Column1.Frozen = true;
            this.Column1.HeaderText = "Имя игры";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Column1.Width = 108;
            // 
            // Column2
            // 
            this.Column2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Column2.Frozen = true;
            this.Column2.HeaderText = "Изображение";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Column2.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.Column2.Width = 109;
            // 
            // Column3
            // 
            this.Column3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Column3.Frozen = true;
            this.Column3.HeaderText = "Описание";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.Width = 108;
            // 
            // Column4
            // 
            this.Column4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Column4.Frozen = true;
            this.Column4.HeaderText = "рублей/час";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            this.Column4.Width = 109;
            // 
            // Column5
            // 
            this.Column5.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            this.Column5.DefaultCellStyle = dataGridViewCellStyle2;
            this.Column5.Frozen = true;
            this.Column5.HeaderText = "Старт";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            this.Column5.Text = "Play";
            this.Column5.ToolTipText = "Play";
            this.Column5.UseColumnTextForButtonValue = true;
            this.Column5.Width = 108;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(553, 129);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(256, 24);
            this.label1.TabIndex = 3;
            this.label1.Text = "Введите количество денег";
            this.label1.Visible = false;
            // 
            // Cash
            // 
            this.Cash.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.Cash.Location = new System.Drawing.Point(582, 162);
            this.Cash.Name = "Cash";
            this.Cash.Size = new System.Drawing.Size(201, 29);
            this.Cash.TabIndex = 4;
            this.Cash.Visible = false;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(2, 1);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(36, 35);
            this.dataGridView1.TabIndex = 5;
            this.dataGridView1.Visible = false;
            // 
            // Yes
            // 
            this.Yes.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Yes.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.Yes.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Yes.Location = new System.Drawing.Point(613, 207);
            this.Yes.Name = "Yes";
            this.Yes.Size = new System.Drawing.Size(147, 32);
            this.Yes.TabIndex = 6;
            this.Yes.Text = "Подтвердить";
            this.Yes.UseVisualStyleBackColor = false;
            this.Yes.Visible = false;
            this.Yes.Click += new System.EventHandler(this.Yes_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.button1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button1.Location = new System.Drawing.Point(2, 1);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(81, 35);
            this.button1.TabIndex = 7;
            this.button1.Text = "Выход";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // labelLogin
            // 
            this.labelLogin.AutoSize = true;
            this.labelLogin.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.labelLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.labelLogin.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labelLogin.Location = new System.Drawing.Point(219, 9);
            this.labelLogin.Name = "labelLogin";
            this.labelLogin.Size = new System.Drawing.Size(388, 24);
            this.labelLogin.TabIndex = 8;
            this.labelLogin.Text = "Добро пожаловать в компьютерный клуб:";
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(455, 51);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(37, 24);
            this.dataGridView2.TabIndex = 9;
            this.dataGridView2.Visible = false;
            // 
            // UserContent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::CompClub.Properties.Resources._807864_1423970400;
            this.ClientSize = new System.Drawing.Size(815, 477);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.labelLogin);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Yes);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.Cash);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.GameCont);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.SeeGame);
            this.Name = "UserContent";
            this.Text = "UserContent";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.UserContent_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.GameCont)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button SeeGame;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DataGridView GameCont;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Cash;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewImageColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewButtonColumn Column5;
        private System.Windows.Forms.Button Yes;
        private System.Windows.Forms.Button button1;
        public System.Windows.Forms.Label labelLogin;
        private System.Windows.Forms.DataGridView dataGridView2;
    }
}