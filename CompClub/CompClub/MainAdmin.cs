using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CompClub
{
    public partial class MainAdmin : Form
    {
        public MainAdmin()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            UserContent UC = new UserContent();
            UC.Show();
            UC.labelLogin.Text = "Добро пожаловать в компьютерный клуб:" + label2.Text;
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ManagerUser MU = new ManagerUser();
            MU.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ManagerCont MC = new ManagerCont();
            MC.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Aftorization Back1 = new Aftorization();
            Back1.Show();
            this.Hide();
        }
    }
}
