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
    public partial class MainMemu : Form
    {
        public MainMemu()
        {
            InitializeComponent();
        }

        private void GO_Click(object sender, EventArgs e)
        {
            Aftorization Afto = new Aftorization();
            Afto.Show();
            this.Hide();
        }

        private void CreateAK_Click(object sender, EventArgs e)
        {
            Registration CreateAccount = new Registration();
            CreateAccount.Show();
            this.Hide();
        }

        private void GOOUT_Click(object sender, EventArgs e)
        {
            Application.Exit(); 
        }

        private void MainMemu_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
