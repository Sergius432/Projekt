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
    public partial class Registration : Form
    {
        public Registration()
        {
            InitializeComponent();
        }

        private void SaveUser_Click(object sender, EventArgs e)
        {
            if ((textBox1.Text == "") || (textBox2.Text == "")|| (textBox3.Text == "")|| (textBox4.Text == ""))
            {
                MessageBox.Show("Не все поля заполнены!");
            }
            else
            {
                SqlConnection GC = new SqlConnection(@"Data Source=localhost;Initial Catalog=GameClub;Integrated Security=True");
                GC.Open();
                SqlDataAdapter Data = new SqlDataAdapter("SELECT * FROM users WHERE login1 = '" + textBox1.Text + "'", GC);
                DataSet ds = new DataSet();
                Data.Fill(ds);
                if (Data.SelectCommand.ExecuteScalar() == null)//Проверка, есть ли такой Email уже
                {
                    SqlDataAdapter Data1 = new SqlDataAdapter("INSERT INTO User1 VALUES ('" + textBox1.Text + "','" + textBox2.Text + "','" + textBox3.Text +"'100'"+"'U)", GC);
                    DataSet ds1 = new DataSet();
                    Data1.Fill(ds1, "users");
                    Data1.SelectCommand.ExecuteScalar();//Выполняем запись в базу данных
                    GC.Close();
                    MainMemu MM = new MainMemu();
                    MM.Show();
                    this.Hide();
                }
                 else
                {
                    MessageBox.Show("Такой логин уже существует!");
                }
                GC.Close();
            }
        }

        private void Clear_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
        }

        private void ComeBake_Click(object sender, EventArgs e)
        {
            MainMemu MM = new MainMemu();
            MM.Show();
            this.Hide();
        }

        private void Registration_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void See_MouseDown(object sender, MouseEventArgs e)
        {
            textBox3.PasswordChar = '\0';
        }

        private void Look_MouseDown(object sender, MouseEventArgs e)
        {
            textBox4.PasswordChar = '\0';
        }

        private void See_MouseUp(object sender, MouseEventArgs e)
        {
            textBox3.PasswordChar = '*';
        }

        private void Look_MouseUp(object sender, MouseEventArgs e)
        {
            textBox4.PasswordChar = '*';
        }
    }
}
