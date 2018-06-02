using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Diagnostics;

namespace CompClub
{
    public partial class TimeGame : Form
    {
        public TimeGame()
        {
            InitializeComponent();
        }

        private void TimeGame_Load(object sender, EventArgs e)
        {
            label1.Text = GlobalLogin.Name_Game;
            timer1.Enabled = true;
        }

        int TT = 0, sec, min, newSec, newMin, hour;

        private void timer2_Tick(object sender, EventArgs e)
        {
           var p = Process.GetProcessesByName(GlobalLogin.PName);
            if (p.Length < 1)
            {
                timer1.Enabled = false;
                timer1.Enabled = false;
                UserContent uc = new UserContent();
                uc.Show();
                Close();
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            TT++;
            sec = Convert.ToInt32(TT);
            min = sec / 60;
            newSec = sec - min * 60;
            hour = min / 60;
            newMin = min - hour * 60;
            label2.Text = hour + " часов " + newMin + " минут " + newSec + " секунд ";
        }
    }
}
