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
using System.Diagnostics;
using System.Runtime.InteropServices;

namespace CompClub
{
    public partial class UserContent : Form
    {
        public UserContent()
        {
            InitializeComponent();
        }
        int v;
        private void SeeGame_Click(object sender, EventArgs e)
        {   if (v == 0)
            {
                GameCont.Visible = true;
                SqlConnection ws = new SqlConnection(@"Data Source=localhost;Initial Catalog=GameClub;Integrated Security=True");
                ws.Open();
                SqlDataAdapter data = new SqlDataAdapter("SELECT Content.name_game, Content.icon_game, Content.Diskription, Content.Cost_game FROM Content", ws);
                DataSet ds = new DataSet();
                data.Fill(ds);
                dataGridView1.DataSource = ds.Tables[0];
                ws.Close();
                for (int i = 0; i < dataGridView1.RowCount; i++)
                {
                    GameCont.Rows.Add();
                    GameCont[0, i].Value = dataGridView1[0, i].Value;
                    Bitmap LOGO = new Bitmap(Application.StartupPath + @"\ImagesForGames\" + dataGridView1[1, i].Value);
                    GameCont[1, i].Value = LOGO;
                    GameCont[2, i].Value = dataGridView1[2, i].Value;
                    GameCont[3, i].Value = dataGridView1[3, i].Value;
                }
                v = 1;
            } else
            {
                GameCont.Visible = false;
                v = 0;
            }
        }

        private void UserContent_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
        int RowsIndex,c;
        private void GameCont_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            N_Users = GlobalLogin.GLogin;
            SqlConnection ws = new SqlConnection(@"Data Source=localhost;Initial Catalog=GameClub;Integrated Security=True");
            ws.Open();
            SqlDataAdapter data = new SqlDataAdapter("SELECT users.Money FROM users WHERE users.login1 = '" + N_Users + "'", ws);
            DataSet ds = new DataSet();
            data.Fill(ds);
            dataGridView2.DataSource = ds.Tables[0];
            c = Convert.ToInt32(dataGridView2[0, 0].Value);
            MessageBox.Show("Записано");
            if (c != 0)
            {
                var senderGrid = (DataGridView)sender;
                if (senderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn && e.RowIndex >= 0)
                {
                    RowsIndex = e.RowIndex;
                    GlobalLogin.Name_Game = this.GameCont[0, RowsIndex].Value.ToString();
                    Process poop = Process.Start(@"C:\Users\sv-11\Desktop\Games\" + GlobalLogin.Name_Game + ".lnk");
                    GlobalLogin.PName = poop.ProcessName; // логический флаг
                    var pList = Process.GetProcesses();
                    if (pList.Count() != 0)
                    {
                        foreach (var process in pList)
                        {
                            if (process.ProcessName == GlobalLogin.PName)
                            {
                                GlobalLogin.GameRun_f = 1;
                            }
                        }
                    }
                }
                if (GlobalLogin.GameRun_f == 1)
                {
                    TimeGame TimeGame = new TimeGame();
                    TimeGame.Show();
                    this.Hide();
                }
            } else
            {
                MessageBox.Show("У вас недостаточно средств на счету!");
            }
        }
        int n;
        private void button2_Click(object sender, EventArgs e)
        {
            if (n == 0)
            {
                label1.Visible = true;
                Cash.Visible = true;
                Yes.Visible = true;
                n = 1;
            }
            else
            {
                label1.Visible = false;
                Cash.Visible = false;
                Yes.Visible = false;
                n = 0;
            }
        }
        string N_Users;
        private void Yes_Click(object sender, EventArgs e)
        {
            if (Cash.Text !="")
            {
                N_Users = GlobalLogin.GLogin;
                SqlConnection GC = new SqlConnection(@"Data Source=localhost;Initial Catalog=GameClub;Integrated Security=True");
                GC.Open();
                SqlDataAdapter Data = new SqlDataAdapter("SELECT users.Money FROM users WHERE users.login1 = '" + N_Users + "'",GC);
                DataSet ds = new DataSet();
                Data.Fill(ds);
                dataGridView2.DataSource = ds.Tables[0];
                int Mon = Convert.ToInt32(dataGridView2[0, 0].Value);
                int PP = Mon + Convert.ToInt32(Cash.Text);
                SqlDataAdapter Data1 = new SqlDataAdapter("UPDATE users SET users.Money = '" + PP + "' WHERE users.login1 = '" + N_Users + "'", GC);
                DataSet ds1 = new DataSet();
                Data1.Fill(ds1);
                GC.Close();
                MessageBox.Show("Вы успешно оплатили!");
            } else
            {
                MessageBox.Show("Поле не заполнено!");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Aftorization Afto = new Aftorization();
            Afto.Show();
            this.Hide();
        }
    }
}
