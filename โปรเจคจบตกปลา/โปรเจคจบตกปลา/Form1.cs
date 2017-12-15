using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media; 

namespace โปรเจคจบตกปลา
{
    public partial class Form1 : Form
    {
        SoundPlayer player = new SoundPlayer();
        public Form1()
        {
            InitializeComponent();
            player.SoundLocation = @"D:\อาจารย์โคช\ninja.wav";  //ดึงไฟล์ D:\อาจารย์โคช\ninja
            player.PlayLooping(); //เล่นเพลงซ้ำ
        }
        int click = 0;    //สร้างตัวแปร click ให้เป็น 0
        int score = 0;    //สร้างตัวแปร score ให้เป็น 0

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            label1.Visible = false;   //ใช้ .visible = false เพื่อเปิดการมองเห็น
            pictureBox1.Visible = false;  //ใช้ .visible = false เพื่อเปิดการมองเห็น
            pictureBox2.Visible = true;  //ใช้ .visible = false เพื่อปิดการมองเห็น
            pictureBox3.Visible = true;   //ใช้ .visible = false เพื่อปิดการมองเห็น
            label2.Visible = true;    //ใช้ .visible = false เพื่อปิดการมองเห็น
            label3.Visible = true;   //ใช้ .visible = false เพื่อปิดการมองเห็น
            label4.Visible = true;   //ใช้ .visible = false เพื่อปิดการมองเห็น

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            pictureBox4.Visible = false; //คลิ๊กpictureBox3แล้วจะโชว์pictureBox4
            click = click + 1;  //click + ทีละ1
            if (click == 10)  //จนครบ10แล้วเข้าเงื่อนไข
            {
                Random Fish = new Random();  //สร้างตัวแปรสุ่ม Fish
                int F = Fish.Next(1,21);    // สร้างตัวแปรสุ่ม 1ถึง20
                Form2 over = new Form2();   //เปิดFrom2เมื่อ Over    
                switch (F)  //เช็คเงื่อนไข
                {
                    case 1:  //Fตำแหน่งที่1
                        pictureBox4.Visible = true; //โชว์pictureBox4
                        pictureBox4.Image = Properties.Resources.F1;  //โชว์รูปในpictureBox4
                        score += 10;   //ให้รูปนี้มี score = 10
                        label3.Text = score.ToString(); //แล้วโชว์scoreในlabel3
                        click = 0;  //click = 0
                        break;
                    case 2:
                        pictureBox4.Visible = true;
                        pictureBox4.Image = Properties.Resources.F2;
                        score += 10;
                        label3.Text = score.ToString();
                        click = 0;
                        break;
                    case 3:
                        pictureBox4.Visible = true;
                        pictureBox4.Image = Properties.Resources.F3;
                        score += 10;
                        label3.Text = score.ToString();
                        click = 0;
                        break;
                    case 4:
                        pictureBox4.Visible = true;
                        pictureBox4.Image = Properties.Resources.F4;
                        score += 10;
                        label3.Text = score.ToString();
                        click = 0;
                        break;
                    case 5:
                        pictureBox4.Visible = true;
                        pictureBox4.Image = Properties.Resources.F5;
                        score += 10;
                        label3.Text = score.ToString();
                        click = 0;
                        break;
                    case 6:
                        pictureBox4.Visible = true;
                        pictureBox4.Image = Properties.Resources.F6;
                        score += 5;
                        label3.Text = score.ToString();
                        click = 0;
                        break;
                    case 7:
                        pictureBox4.Visible = true;
                        pictureBox4.Image = Properties.Resources.F7;
                        score += 25;
                        label3.Text = score.ToString();
                        click = 0;
                        break;
                    case 8:
                        pictureBox4.Visible = true;
                        pictureBox4.Image = Properties.Resources.F8;
                        score += 20;
                        label3.Text = score.ToString();
                        click = 0;
                        break;
                    case 9:
                        pictureBox4.Visible = true;
                        pictureBox4.Image = Properties.Resources.F9;
                        score += 15;
                        label3.Text = score.ToString();
                        click = 0;
                        break;
                    case 10:
                        pictureBox4.Visible = true;
                        pictureBox4.Image = Properties.Resources.F10;
                        score += 50;
                        label3.Text = score.ToString();
                        click = 0;
                        break;
                    case 11:
                        pictureBox4.Visible = true;
                        pictureBox4.Image = Properties.Resources.F11;
                        score += 300;
                        label3.Text = score.ToString();
                        click = 0;
                        break;
                    case 12:
                        pictureBox4.Visible = true;
                        pictureBox4.Image = Properties.Resources.F12;
                        score += 250;
                        label3.Text = score.ToString();
                        click = 0;
                        break;
                    case 13:
                        pictureBox4.Visible = true;
                        pictureBox4.Image = Properties.Resources.F13;
                        score += 0;
                        label3.Text = score.ToString();
                        click = 0;
                        break;
                    case 14:
                        pictureBox4.Visible = true;
                        pictureBox4.Image = Properties.Resources.F14;
                        score += 0;
                        label3.Text = score.ToString();
                        click = 0;
                        break;
                    case 15:
                        pictureBox4.Visible = true;
                        pictureBox4.Image = Properties.Resources.F15;
                        score += 0;
                        label3.Text = score.ToString();
                        click = 0;
                        break;
                    case 16:
                        pictureBox4.Visible = true;
                        pictureBox4.Image = Properties.Resources.F16;
                        score += 0;
                        label3.Text = score.ToString();
                        click = 0;
                        break;
                    case 17:
                        pictureBox4.Visible = true;
                        pictureBox4.Image = Properties.Resources.F17;
                        score += 0;
                        label3.Text = score.ToString();
                        click = 0;
                        break;
                    case 18:
                        over.lb_score.Text = score.ToString();
                        pictureBox4.Visible = true;
                        pictureBox4.Image = Properties.Resources.F18;
                        label3.Text = score.ToString();
                        over.ShowDialog();
                       
                        Close();
                        break;
                    case 19:
                        over.lb_score.Text = score.ToString();
                        pictureBox4.Visible = true;
                        pictureBox4.Image = Properties.Resources.F19;
                        label3.Text = score.ToString();
                        over.ShowDialog();
                       
                        Close();
                        break;
                    case 20: //Fตำแหน่งที่20
                        over.lb_score.Text = score.ToString();   //โชว์ score ใน lb_score
                        pictureBox4.Visible = true; //โชว์รูปในpictureBox4
                        pictureBox4.Image = Properties.Resources.F20;  //โชว์รูปในpictureBox4
                        label3.Text = score.ToString();  //แล้วโชว์scoreในlabel3
                        over.ShowDialog(); //โชว์From2แล้วล็อคไม่ให้กดFromอื่นได้
                        
                        Close();  //แล้วปิดโปรแกรม
                        break;

                }
            }
        
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }
    }
}
