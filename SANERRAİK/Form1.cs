using System;
using System.Drawing;
using System.Windows.Forms;

namespace SANERRAİK
{
    public partial class Form1 : Form
    {
        bool[,] mayin = new bool[10, 10];
        bool oyunBitti = false;
        Button btnDurum; 
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
            btnDurum = new Button();
            btnDurum.Location = new Point(155, 10);
            btnDurum.Size = new Size(40, 40);
            btnDurum.Font = new Font("Arial", 14);
            btnDurum.Text = "😊";
           
            btnDurum.Click += (s, ev) => Application.Restart();
            this.Controls.Add(btnDurum);

            Random rnd = new Random();

            for (int k = 0; k < 10; k++)
            {
                int col = rnd.Next(10);
                int row = rnd.Next(10);

                if (mayin[col, row] == true)
                {
                    k--;
                    continue;
                }
                mayin[col, row] = true;
            }

            int top = 60; 
            for (int j = 0; j < 10; j++)
            {
                int left = 50;
                for (int i = 0; i < 10; i++)
                {
                    Button btn2 = new Button();
                    btn2.Location = new Point(left, top);
                    btn2.Size = new Size(30, 30);
                    btn2.Font = new Font("Arial", 10, FontStyle.Bold);
                    btn2.MouseDown += btn2_MouseDown;
                    btn2.Tag = new Point(i, j);

                    this.Controls.Add(btn2);
                    left += 30;
                }
                top += 30;
            }
        }

        private void btn2_MouseDown(object sender, MouseEventArgs e)
        {
            if (oyunBitti) return;

            Button tiklananBtn = (Button)sender;
            Point konum = (Point)tiklananBtn.Tag;
            int x = konum.X;
            int y = konum.Y;

            if (e.Button == MouseButtons.Right)
            {
                if (tiklananBtn.Text == "")
                {
                    tiklananBtn.Text = "🚩";
                    tiklananBtn.ForeColor = Color.Red;
                }
                else if (tiklananBtn.Text == "🚩")
                {
                    tiklananBtn.Text = "";
                }
                return;
            }

            if (e.Button == MouseButtons.Left && tiklananBtn.Text != "🚩")
            {
                if (mayin[x, y] == true)
                {
                    tiklananBtn.BackColor = Color.Red;
                    tiklananBtn.Text = "💣";
                    btnDurum.Text = "😡"; 
                    oyunBitti = true;
                    MayinlariGoster();
                }
                else
                {
                    tiklananBtn.BackColor = Color.LightBlue;
                    tiklananBtn.Enabled = false;

                    int etraftakiMayin = 0;

                    for (int i = -1; i <= 1; i++)
                    {
                        for (int j = -1; j <= 1; j++)
                        {
                            int kX = x + i;
                            int kY = y + j;

                            if (kX >= 0 && kX < 10 && kY >= 0 && kY < 10)
                            {
                                if (mayin[kX, kY] == true)
                                {
                                    etraftakiMayin++;
                                }
                            }
                        }
                    }

                    if (etraftakiMayin > 0)
                    {
                        tiklananBtn.Text = etraftakiMayin.ToString();
                    }
                }
            }
        }

        private void MayinlariGoster()
        {
            foreach (Control ctrl in this.Controls)
            {
                if (ctrl is Button btn && btn.Tag is Point konum)
                {
                    if (mayin[konum.X, konum.Y] == true)
                    {
                        btn.BackColor = Color.Red;
                        if (btn.Text != "🚩") btn.Text = "💣";
                    }
                }
            }
        }
    }
}