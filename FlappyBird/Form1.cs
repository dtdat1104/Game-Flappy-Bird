using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Media;

namespace FlappyBird
{
    public partial class Form1 : Form
    {
        #region biến
        //
        int KhoangCachGiuaHaiOng = 80, DoRongGiuaHaiOng = 100;
        //
        int XOng1, XOng2;
        //
        int YOngTren1, YOngTren2;
        //
        int YOngDuoi1, YOngDuoi2;
        //
        int XConChim, YConChim;
        //
        int Diem1 = 0;
        int DiemMax = 0;

        //
        bool checkkey = true;
        bool checkplayagain = false;
        int flagplay = 1;
        bool Check;
        int kq;
        #endregion
        public Form1()
        {
            InitializeComponent();
        }
        //
        #region cờ tắt
        public void FlagTat()
        {
            this.OngTren1.Hide();
            this.OngDuoi1.Hide();
            this.OngTren2.Hide();
            this.OngDuoi2.Hide();
        }
        #endregion
        #region form load
        public void FormLoad()
        {
            //
            ConChim.BackColor = Color.Transparent;
            ButtonPlay.BackColor = Color.Transparent;
            //
            Check = true;
            
            HuongDan.Show();
            panel1.Hide();
            //
            Random rd = new Random();
            kq = rd.Next(1, 4);
            if (kq == 1)
            {
                ConChim.Image = Image.FromFile(@"F:\Project\LapTrinh\LapTrinhC#\DoAnGiuaKiWD\chim doi mau\mau-1.gif");
            }
            if (kq == 2)
            {
                ConChim.Image = Image.FromFile(@"F:\Project\LapTrinh\LapTrinhC#\DoAnGiuaKiWD\chim doi mau\mau-2.gif");
            }
            if (kq == 3)
            {
                ConChim.Image = Image.FromFile(@"F:\Project\LapTrinh\LapTrinhC#\DoAnGiuaKiWD\chim doi mau\mau-3.gif");
            }
            if (kq == 4)
            {
                ConChim.Image = Image.FromFile(@"F:\Project\LapTrinh\LapTrinhC#\DoAnGiuaKiWD\chim doi mau\mau-4.gif");
            }
            ConChim.Hide(); // chim ẩn đi
            //Ống thứ nhất.
            XOng1 = this.Width + 800;
            YOngTren1 = -750;//Chiều cao của ống trên = chiều cao + tọa độ y;
            this.OngTren1.Location = new Point(XOng1, YOngTren1);
            //
            YOngDuoi1 = (1000 + YOngTren1) + KhoangCachGiuaHaiOng;
            this.OngDuoi1.Location = new Point(XOng1, YOngDuoi1);

            //Ống thứ 2
            XOng2 = 800 + OngTren1.Width + DoRongGiuaHaiOng;//Do rong giua hai ong
            YOngTren2 = -800;//Chiều cao của ống trên = chiều cao + tọa độ y;
            this.OngTren2.Location = new Point(XOng2, YOngTren2);
            //
            YOngDuoi2 = (1000 + YOngTren2) + KhoangCachGiuaHaiOng;
            this.OngDuoi2.Location = new Point(XOng2, YOngDuoi2);

            //tọa độ của con chim
            XConChim = ConChim.Location.X;
            YConChim = ConChim.Location.Y;

            ConChim.Hide();

            //
            ButtonPlay.Size = new Size(50, 50);
            //
            timer1.Interval = 1;
            //Xếp hạng  
            int DiemMaxHT = 0;
            using (StreamReader sr = new StreamReader("xephang.txt"))
            {
                DiemMaxHT = int.Parse(sr.ReadLine().ToString());

            }
            label2.Text = Diem1.ToString(); // hiển thị điểm
            label1.Text = DiemMaxHT.ToString(); // hiển thị điểm cao nhất
        }
        
        public void Form1_Load(object sender, EventArgs e)
        {
            FormLoad();
        }
        #endregion
        #region bắt phím
        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            //Nhấn space lần đầu tiên để chơi
            
            if (e.KeyCode == Keys.Space) //Nhấn space để chim bay lên
            {
                if(checkplayagain == true)
                {
                    PlayAgain();
                    checkplayagain = false;
                }
                if (Check == true)
                {
                    timer1.Start();
                    this.PlayFirst.Hide();
                    this.HuongDan.Hide();
                    this.label1.Hide();
                    this.label2.Hide();
                    this.panel1.Hide();
                    ConChim.Show();
                    Check = false;
                }

                if (checkkey == true)//
                {
                    YConChim -= 65;
                    ConChim.Location = new Point(XConChim, YConChim);
                }

            }
            if (e.KeyCode == Keys.Down)
            {
                if (checkkey == true)//Kiểm tra lúc chết không cho nhấn phím
                {
                    YConChim += 20;
                    ConChim.Location = new Point(XConChim, YConChim);
                }

            }
        }
        #endregion
        #region nút play
        private void pictureBox1_Click_1(object sender, EventArgs e)
        {
            if (flagplay == 1)
            {
                timer1.Start();
                ConChim.Show();
                PlayFirst.Hide();
                HuongDan.Hide();
                flagplay++;
            }
        }
        public void PlayAgain()
        {
            this.Hide();
            Form1 f = new Form1();
            f.Show();
            HuongDan.Hide();
            PlayFirst.Hide();
            timer1.Start();
        }



        private void ButtonPlay_Click_1(object sender, EventArgs e)
        {
            PlayAgain();
        }
        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        #endregion
        #region timer1
        private void timer1_Tick(object sender, EventArgs e)
        {
            SetStyle(ControlStyles.OptimizedDoubleBuffer, true);
            this.SetStyle(ControlStyles.AllPaintingInWmPaint | ControlStyles.UserPaint | ControlStyles.DoubleBuffer, true);
            //Tốc độ chạy của hai ống cống.
            XOng1 -= 8;
            XOng2 -= 8;
            //Ống thứ nhất
            this.OngTren1.Location = new Point(XOng1, YOngTren1);
            //YOngDuoi1 = (1000 + YOngTren1) + KhoangCachGiuaHaiOng;
            this.OngDuoi1.Location = new Point(XOng1, YOngDuoi1);
            //Ống thứ hai.
            this.OngTren2.Location = new Point(XOng2, YOngTren2);
            //YOngDuoi2 = (1000 + YOngTren2) + KhoangCachGiuaHaiOng;
            this.OngDuoi2.Location = new Point(XOng2, YOngDuoi2);
            //
            if(YConChim  <= 0  )
            {
                //Hit();
                timer1.Stop();
                timer3.Start();
            }
            //Kiểm tra tọa độ ống cống để quay trở lại
            if (XOng1 + OngTren1.Width <= 0)
            {
                //Point();
                Diem1++;
                XOng1 = 800 + OngTren2.Width + DoRongGiuaHaiOng; // ống một trở lại sau ống hai
                //Random độ cao;
                Random r = new Random();
                YOngTren1 = r.Next(-880, -700);
                YOngDuoi1 = (1000 + YOngTren1) + KhoangCachGiuaHaiOng;
                OngTren1.Location = new Point(XOng1, YOngTren1);
                OngDuoi1.Location = new Point(XOng1, YOngDuoi1);
            }
            if (XOng2 + OngTren2.Width <= 0)
            {
                //Point();
                Diem1++;
                XOng2 = 800 + OngTren1.Width + DoRongGiuaHaiOng;

                Random r = new Random();
                YOngTren2 = r.Next(-700, -650);
                YOngDuoi2 = (1000 + YOngTren2) + KhoangCachGiuaHaiOng;
                OngTren2.Location = new Point(XOng2, YOngTren2);
                OngDuoi2.Location = new Point(XOng2, YOngDuoi2);
            }
            //Con Chim rớt
            if (YConChim + ConChim.Height <= this.Height - 39)
            {
                YConChim += 4;
                ConChim.Location = new Point(XConChim, YConChim);
                if (XConChim + ConChim.Width >= XOng1 && XConChim + ConChim.Width <= XOng1 + OngTren1.Width) // điều kiện để chim chết
                {
                    if (YConChim <= 934 + YOngTren1 || YConChim + ConChim.Height >= YOngDuoi1)
                    {
                        //Hit();
                        timer1.Stop();
                        FlagTat();
                        YConChim -= 60;
                        timer3.Start();
                    }
                }

                if (XConChim + ConChim.Width >= XOng2 && XConChim + ConChim.Width <= XOng2 + OngTren2.Width)
                {
                    if (YConChim <= 934 + YOngTren2 || YConChim + ConChim.Height >= YOngDuoi2)
                    {
                        //Hit();
                        timer1.Stop();
                        FlagTat();
                        YConChim -= 60;
                        timer3.Start();
                    }
                }
            }
            else
            {
                //Hit();
                timer1.Stop();
                timer3.Start();
            }
            Diem.Text = Diem1.ToString();
        }
        #endregion
        #region nhạc
        public static void Point()
        {
            SoundPlayer sound = new SoundPlayer(@"C:\Users\Diep Thanh Dat\Desktop\GameFlappyBird\sound\sfx_point.wav");
            //sound.LoadAsync();
            sound.Play();
        }
        public static void Hit()
        {
            SoundPlayer sound = new SoundPlayer(@"C:\Users\Diep Thanh Dat\Desktop\GameFlappyBird\sound\sfx_hit.wav");
            //sound.LoadAsync();
            sound.Play();
        }
        #endregion
        #region timer3
        private void timer3_Tick(object sender, EventArgs e)
        {
            
            this.SetStyle(ControlStyles.AllPaintingInWmPaint | ControlStyles.UserPaint | ControlStyles.DoubleBuffer, true);
            //tính điểm cao nhất
            using (StreamReader sr = new StreamReader("xephang.txt"))
            {
                DiemMax = int.Parse(sr.ReadLine().ToString());
            }
            //
            if (DiemMax < Diem1)
            {
                DiemMax = Diem1;
                using (StreamWriter sw = new StreamWriter("xephang.txt"))
                {
                    sw.WriteLine(DiemMax);
                }
            }
            //
            int DiemMaxHT = 0;
            using (StreamReader sr = new StreamReader("xephang.txt"))
            {
                DiemMaxHT = int.Parse(sr.ReadLine().ToString());

            }
            //
            if (kq == 1)
            {
                ConChim.Image = Image.FromFile(@"F:\Project\LapTrinh\LapTrinhC#\DoAnGiuaKiWD\chim doi mau\mau-1.gif");
            }
            if (kq == 2)
            {
                ConChim.Image = Image.FromFile(@"F:\Project\LapTrinh\LapTrinhC#\DoAnGiuaKiWD\chim doi mau\mau-2.gif");
            }
            if (kq == 3)
            {
                ConChim.Image = Image.FromFile(@"F:\Project\LapTrinh\LapTrinhC#\DoAnGiuaKiWD\chim doi mau\mau-3.gif");
            }
            if (kq == 4)
            {
                ConChim.Image = Image.FromFile(@"F:\Project\LapTrinh\LapTrinhC#\DoAnGiuaKiWD\chim doi mau\mau-4.gif");
            }
            //
            Diem.Hide();
            panel1.Show();
            ButtonPlay.Show();
            label2.Show();
            label1.Show();
            label2.Text =  Diem1.ToString();
            label1.Text =  DiemMaxHT.ToString();
            checkplayagain = true;
            if (XConChim + ConChim.Height <= this.Width + 20)
            {
                checkkey = false;
                XConChim += 30;
                YConChim += 10;
                ConChim.Location = new Point(XConChim, YConChim);
            }
            else
            {
                timer3.Stop();
                ConChim.Location = new Point(XConChim, YConChim);
            }

        }
        #endregion
    }
}
