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
    public partial class ManagerCont : Form
    {
        public ManagerCont()
        {
            InitializeComponent();
        }

        private void ManagerCont_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void Back_Click(object sender, EventArgs e)
        {
            MainAdmin MA = new MainAdmin();
            MA.Show();
            this.Hide();
        }

        private void LookCont_Click(object sender, EventArgs e)
        {
            SqlConnection GC = new SqlConnection(@"Data Source=localhost;Initial Catalog=GameClub;Integrated Security=True");
            GC.Open();
            SqlDataAdapter Data = new SqlDataAdapter("SELECT * FROM Content", GC);
            DataSet ds = new DataSet();
            Data.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
            GC.Close();
        }

        private void Search_Click(object sender, EventArgs e)
        {

        }

        private void CreateUser_Click(object sender, EventArgs e)
        {
            panel1.Visible = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            panel1.Visible = false;
            textBox2.Text = "";
            textBox3.Text = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //if (textBox2.Text != "" && textBox3.Text != "" && textBox4.Text != "" && textBox5.Text != "" && comboBox1.Text != "")
            //{
            //    SqlConnection GC = new SqlConnection(@"Data Source=localhost;Initial Catalog=GameClub;Integrated Security=True");
            //    GC.Open();
            //    SqlDataAdapter Data = new SqlDataAdapter("INSERT INTO users VALUES ('" + textBox2.Text + "','" + textBox3.Text + "','" + textBox4.Text + "','" + Convert.ToInt32(textBox5.Text) + "','" + RoleId + "')", GC);
            //    DataSet ds = new DataSet();
            //    Data.Fill(ds);
            //    GC.Close();
            //    MessageBox.Show("Данные сохранены!");
            //    panel1.Visible = false;
            //    textBox2.Text = "";
            //    textBox3.Text = "";
            //}
            //else
            //{
            //    MessageBox.Show("Не все поля заполнены!");
            //}
        }
        string RoleId;
        private void comboBox1_SelectedValueChanged(object sender, EventArgs e)
        {
        }
    }
}
