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
    public partial class ManagerUser : Form
    {
        public ManagerUser()
        {
            InitializeComponent();
        }

        private void ManagerUser_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void Back_Click(object sender, EventArgs e)
        {
            MainAdmin MA = new MainAdmin();
            MA.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection GC = new SqlConnection(@"Data Source=localhost;Initial Catalog=GameClub;Integrated Security=True");
            GC.Open();
            SqlDataAdapter Data = new SqlDataAdapter("SELECT * FROM users", GC);
            DataSet ds = new DataSet();
            Data.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
            GC.Close();
            dataGridView1.Columns[1].SortMode = DataGridViewColumnSortMode.NotSortable;
            dataGridView1.Columns[2].SortMode = DataGridViewColumnSortMode.NotSortable;
            dataGridView1.Columns[3].SortMode = DataGridViewColumnSortMode.NotSortable;
            dataGridView1.Columns[4].SortMode = DataGridViewColumnSortMode.NotSortable;
            dataGridView1.Columns[5].SortMode = DataGridViewColumnSortMode.NotSortable;
            dataGridView1.Columns[6].SortMode = DataGridViewColumnSortMode.NotSortable;
            button4.Enabled = true;
        }

        private void Search_Click(object sender, EventArgs e)
        {
            SqlConnection GC = new SqlConnection(@"Data Source=localhost;Initial Catalog=GameClub;Integrated Security=True");
            GC.Open();
            SqlDataAdapter Data = new SqlDataAdapter("SELECT * FROM users where login1 ='" + textBox1.Text + "'", GC);
            DataSet ds = new DataSet();
            Data.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
            GC.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (textBox2.Text != "" && textBox3.Text != "" && textBox4.Text != "" && textBox5.Text != "" && comboBox1.Text != "")
            {
                SqlConnection GC = new SqlConnection(@"Data Source=localhost;Initial Catalog=GameClub;Integrated Security=True");
                GC.Open();
                SqlDataAdapter Data = new SqlDataAdapter("INSERT INTO users VALUES ('" + textBox2.Text + "','" + textBox3.Text + "','" + textBox4.Text + "','" + Convert.ToInt32(textBox5.Text) + "','" + RoleId + "')", GC);
                DataSet ds = new DataSet();
                Data.Fill(ds);
                GC.Close();
                MessageBox.Show("Данные сохранены!");
                panel1.Visible = false;
                textBox2.Text = "";
                textBox3.Text = "";
                textBox4.Text = "";
                textBox5.Text = "";
                comboBox1.Text = "";
            }
            else
            {
                MessageBox.Show("Не все поля заполнены!");
            }
            if (textBox2.Text != "" && textBox3.Text != "" && textBox4.Text != "" && textBox5.Text != "" && comboBox1.Text != "")
            {
                SqlConnection GC = new SqlConnection(@"Data Source=localhost;Initial Catalog=GameClub;Integrated Security=True");
                GC.Open();
                SqlDataAdapter Data = new SqlDataAdapter("INSERT INTO users VALUES ('" + textBox2.Text + "','" + textBox3.Text + "','" + textBox4.Text + "','" + Convert.ToInt32(textBox5.Text) + "','" + RoleId + "')", GC);
                DataSet ds = new DataSet();
                Data.Fill(ds);
                GC.Close();
                MessageBox.Show("Данные сохранены!");
                panel1.Visible = false;
                textBox2.Text = "";
                textBox3.Text = "";
                textBox4.Text = "";
                textBox5.Text = "";
                comboBox1.Text = "";
            }
            else
            {
                MessageBox.Show("Не все поля заполнены!");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            panel1.Visible = false;
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            textBox5.Text = "";
            comboBox1.Text = "";
            GlobalLogin.AddUser_f = 0;
            GlobalLogin.UpdateUser_f = 0;
            CreateCont.Enabled = true;
            button4.Enabled = true;
        }

        private void CreateCont_Click(object sender, EventArgs e)
        {
            if (GlobalLogin.UpdateUser_f == 0)
            {
                panel1.Visible = true;
                GlobalLogin.AddUser_f = 1;
                CreateCont.Enabled = false;
            }
            else
            {
                MessageBox.Show("Завершите процедуру редактирования!");
            }
        }
        string RoleId;
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.Text == "Администратор")
            {
                RoleId = "A";
                button3.Enabled = true;
            }
            if (comboBox1.Text == "Пользователь")
            {
                RoleId = "U";
                button3.Enabled = true;
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var senderGrid = (DataGridView)sender;
            if (senderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn && e.RowIndex >= 0)
            {
                var RowIndexx = e.RowIndex;
                var id = dataGridView1[1, RowIndexx].Value;
                SqlConnection GC = new SqlConnection(@"Data Source=localhost;Initial Catalog=GameClub;Integrated Security=True");
                GC.Open();
                SqlDataAdapter Data = new SqlDataAdapter("DELETE FROM users WHERE users.id_user = '" + id + "'", GC);
                DataSet ds = new DataSet();
                Data.Fill(ds);
                SqlDataAdapter Data1 = new SqlDataAdapter("SELECT * FROM users", GC);
                DataSet ds1 = new DataSet();
                Data1.Fill(ds1);
                dataGridView1.DataSource = ds1.Tables[0];
                GC.Close();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (GlobalLogin.AddUser_f == 0)
            {
                if (Index1 != 0)
                {
                    panel1.Visible = true;
                    GlobalLogin.UpdateUser_f = 1;
                    button4.Enabled = false;
                    var LOG = dataGridView1[2, Index1].Value;
                    var Email = dataGridView1[3, Index1].Value.ToString();
                    var Pass = dataGridView1[4, Index1].Value.ToString();
                    var Money = dataGridView1[5, Index1].Value;
                    var Role = dataGridView1[6, Index1].Value.ToString();
                    textBox2.Text = LOG.ToString();
                    textBox3.Text = Email.ToString();
                    textBox4.Text = Pass.ToString();
                    textBox5.Text = Money.ToString();
                    comboBox1.Text = Role.ToString();
                }
                else
                {
                    MessageBox.Show("Выберите что-нибудь из таблицы!");
                }
            }
            else
            {
                MessageBox.Show("Завершите процедуру добавления!");
            }
        }
        int Index1;
        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            Index1 = dataGridView1.CurrentRow.Index;
        }
    }
}