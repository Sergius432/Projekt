using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace CompClub
{
    public partial class Aftorization : Form
    {
        public Aftorization()
        {
            InitializeComponent();
        }

        private void ComeBake_Click(object sender, EventArgs e)
        {
            MainMemu mit = new MainMemu();
            mit.Show();
            this.Hide();
        }

        private void GoGame_Click(object sender, EventArgs e)
        {
            if ((this.Login.Text == "") || (this.Password.Text == ""))
            {
                MessageBox.Show("Не все поля заполнены!");
            }
            else
            {
                SqlConnection GC = new SqlConnection(@"Data Source=localhost;Initial Catalog=GameClub;Integrated Security=True");
                GC.Open();
                SqlDataAdapter Data = new SqlDataAdapter("Select * From users where Login1 = '" + Login.Text + "'AND PasswordUser = '" + Password.Text + "'", GC);
                SqlDataAdapter Data2 = new SqlDataAdapter("Select RoleUser From users where Login1 = '" + Login.Text + "'AND PasswordUser = '" + Password.Text + "'", GC);
                DataSet ds = new DataSet();
                Data.Fill(ds, "users");
                Data2.Fill(ds, "users");
                if (Data.SelectCommand.ExecuteScalar() != null)
                {
                    if (Data2.SelectCommand.ExecuteScalar().ToString() == "U")
                    {
                        MessageBox.Show("Вы зашли как пользователь!");
                        GlobalLogin.GLogin = Login.Text;
                        UserContent US = new UserContent();
                        US.Show();
                        US.labelLogin.Text = "Добро пожаловать в компьютерный клуб: " + GlobalLogin.GLogin;
                        this.Hide();
                    }
                    else
                    {
                        if (Data2.SelectCommand.ExecuteScalar().ToString() == "A")
                        {
                            MessageBox.Show("Вы зашли как администратор!");
                            GlobalLogin.GLogin = Login.Text;
                            MainAdmin US = new MainAdmin();
                            US.Show();
                            US.label2.Text =GlobalLogin.GLogin;
                            this.Hide();
                        }
                        else
                        {
                            MessageBox.Show("Нет такого пользователя!");
                        }
                        }
                    }
                else
                {
                    MessageBox.Show("Нет такого пользователя!");
                }
                GC.Close();
            }
        }

        private void Aftorization_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void See_MouseDown(object sender, MouseEventArgs e)
        {
            Password.PasswordChar = '\0';
        }

        private void See_MouseUp(object sender, MouseEventArgs e)
        {
            Password.PasswordChar = '*';
        }
    }
}
