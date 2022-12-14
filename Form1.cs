using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ArabaYarisi
{
    public partial class Form1 : Form
    {
        Random x = new Random();
        int a;
        int b;
        int c;
        int bes = 4;
        public Form1()
        {
            InitializeComponent();
        }



        private void button6_Click(object sender, EventArgs e)
        {
            // Yarışı Başlat
            if(Class1.bahisbasma == 0)
            {
                MessageBox.Show("Lütfen bahisinizi seçin."); //Zorunlu Bahis
            }
            else
            {
                button10.Enabled = false; 
                timer5.Start(); //Yarışı başlat
                button6.Enabled = false;
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {

            Bahis bahis = new Bahis();
            
            if (pictureBox1.Location.X > pictureBox2.Location.X && pictureBox1.Location.X > pictureBox3.Location.X)//Arabaların Arasındaki farka göre label deki yazıyı değiştirir.
            {
                label1.Text = "Turuncu Araba Önde";
                if (pictureBox1.Location.X > 1209)
                {
                    timer1.Stop();
                    timerTuruncu.Stop();
                    timerMavi.Stop();
                    timerYesil.Stop();
                    label1.ForeColor = Color.Orange;
                    label1.Text = "TURUNCU ARABA KAZANDI!";
                    butonTuruncuNitro.Enabled = false;
                    butonYesilNitro.Enabled = false;
                    butonMaviTurbo.Enabled = false;
                    button10.Enabled = true;
                    button7.Enabled = true;
                    SoundPlayer player = new SoundPlayer(@"driving.wav");
                    player.Stop();
                    Class1.turuncuwin = 1;
                    if (Class1.mavisec == 1)//Class dan seçilen arabayı yükler ve kontrol eder
                    {
                        label2.ForeColor = Color.Red;
                        label2.Text = "Bahisi kaybettin.\nSeçtiğin Araba: Mavi\nKaybettiğin Bütçe:" + Class1.butce + "₺";
                        Class1.kaybedilenpara = Class1.butce;
                        Class1.kalanpara = Class1.kalanpara - Class1.kaybedilenpara;
                    }
                    if (Class1.yesilsec == 1)
                    {
                        label2.ForeColor = Color.Red;
                        label2.Text = "Bahisi kaybettin.\nSeçtiğin Araba: Yeşil\nKaybettiğin Bütçe:" + Class1.butce + "₺";
                        Class1.kaybedilenpara = Class1.butce;
                        Class1.kalanpara = Class1.kalanpara - Class1.kaybedilenpara;
                    }
                    if (Class1.turuncusec == 1)
                    {
                        label2.ForeColor = Color.Green;
                        label2.Text = "Bahisi Kazandın!\nSeçtiğin Araba: Turuncu\nKazandığın Bütçe:" + Class1.butce * 2 + "₺";
                        Class1.kazanilanpara = Class1.butce * 2;
                    }
                }
            }
            else if (pictureBox2.Location.X > pictureBox1.Location.X && pictureBox2.Location.X > pictureBox3.Location.X)//Arabaların Arasındaki farka göre label deki yazıyı değiştirir.
            {
                label1.Text = "Yeşil Araba Önde";
                if (pictureBox2.Location.X > 1209)
                {
                    timer1.Stop();
                    timerTuruncu.Stop();
                    timerMavi.Stop();
                    timerYesil.Stop();
                    label1.ForeColor = Color.Green;
                    label1.Text = "YEŞİL ARABA KAZANDI!";
                    butonTuruncuNitro.Enabled = false;
                    butonYesilNitro.Enabled = false;
                    butonMaviTurbo.Enabled = false;
                    button10.Enabled = true;
                    button7.Enabled = true;
                    SoundPlayer player = new SoundPlayer(@"driving.wav");
                    player.Stop();
                    Class1.yesilwin = 1;
                    if (Class1.mavisec == 1)//Class dan seçilen arabayı yükler ve kontrol eder
                    {
                        label2.ForeColor = Color.Red;
                        label2.Text = "Bahisi kaybettin.\nSeçtiğin Araba: Mavi\nKaybettiğin Bütçe:" + Class1.butce + "₺";
                        Class1.kaybedilenpara = Class1.butce;
                        Class1.kalanpara = Class1.kalanpara - Class1.kaybedilenpara;
                    }
                    if (Class1.turuncusec == 1)
                    {
                        label2.ForeColor = Color.Red;
                        label2.Text = "Bahisi kaybettin.\nSeçtiğin Araba: Turuncu\nKaybettiğin Bütçe:" + Class1.butce + "₺";
                        Class1.kaybedilenpara = Class1.butce;
                        Class1.kalanpara = Class1.kalanpara - Class1.kaybedilenpara;
                    }
                    if (Class1.yesilsec == 1)
                    {
                        label2.ForeColor = Color.Green;
                        label2.Text = "Bahisi Kazandın!\nSeçtiğin Araba: Yeşil\nKazandığın Bütçe:" + Class1.butce * 2 + "₺";
                        Class1.kazanilanpara = Class1.butce * 2;
                    }
                }
            }
            else if (pictureBox3.Location.X > pictureBox1.Location.X && pictureBox3.Location.X > pictureBox2.Location.X)//Arabaların Arasındaki farka göre label deki yazıyı değiştirir.
            {
                label1.Text = "Mavi Araba Önde";
                if (pictureBox3.Location.X > 1209)
                {
                    timer1.Stop();
                    timerTuruncu.Stop();
                    timerMavi.Stop();
                    timerYesil.Stop();
                    label1.ForeColor = Color.Blue;
                    label1.Text = "MAVİ ARABA KAZANDI!";
                    butonTuruncuNitro.Enabled = false;
                    butonYesilNitro.Enabled = false;
                    butonMaviTurbo.Enabled = false;
                    button10.Enabled = true;
                    button7.Enabled = true;
                    SoundPlayer player = new SoundPlayer(@"driving.wav");
                    player.Stop();
                    Class1.maviwin= 1;
                    if (Class1.turuncusec == 1)//Class dan seçilen arabayı yükler ve kontrol eder
                    {
                        label2.ForeColor= Color.Red;
                        label2.Text = "Bahisi kaybettin.\nSeçtiğin Araba: Turuncu\nKaybettiğin Bütçe:" + Class1.butce + "₺";
                        Class1.kaybedilenpara = Class1.butce;
                        Class1.kalanpara = Class1.kalanpara - Class1.kaybedilenpara;
                    }
                    if (Class1.yesilsec == 1)
                    {
                        label2.ForeColor = Color.Red;
                        label2.Text = "Bahisi kaybettin.\nSeçtiğin Araba: Yeşil\nKaybettiğin Bütçe:" + Class1.butce + "₺";
                        Class1.kaybedilenpara = Class1.butce;
                        Class1.kalanpara = Class1.kalanpara - Class1.kaybedilenpara;
                    }
                    if (Class1.mavisec == 1)
                    {
                        label2.ForeColor = Color.Green;
                        label2.Text = "Bahisi Kazandın!\nSeçtiğin Araba: Mavi\nKazandığın Bütçe:" + Class1.butce * 2 + "₺";
                        Class1.kazanilanpara = Class1.butce * 2;
                    }
                }
            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            //Bahis Ekranı
            Form bahis = new Bahis();
            bahis.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            butonTuruncuNitro.Enabled = false;
            butonYesilNitro.Enabled = false;
            butonMaviTurbo.Enabled = false;
            button7.Enabled = false;
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Z)
            {
                if(turuncuNitroBar.Value != 0)
                {
                    butonTuruncuNitro.PerformClick();//Belirlenen tuşa basılı tutulup nitro barı sıfırlanana kadar nitro tuşuna basar.
                }
                if(turuncuNitroBar.Value == 0)
                {
                    butonTuruncuNitro.Enabled = false;//Nitro barı sıfırlanırsa butonu pasif yapar.
                }
            }
            if (e.KeyCode == Keys.C)
            {
                if(maviNitroBar.Value != 0)
                {
                    butonMaviTurbo.PerformClick();
                }
                if (maviNitroBar.Value == 0)
                {
                    butonMaviTurbo.Enabled = false;
                }
            }
            if (e.KeyCode == Keys.X)
            {
                if(yesilNitroBar.Value != 0)
                {
                    butonYesilNitro.PerformClick();
                }
                if (yesilNitroBar.Value == 0)
                {
                    butonYesilNitro.Enabled = false;
                }
            }
            if (e.KeyCode == Keys.B)
            {
                timerTuruncu.Stop(); //Belirlenen Tuşa basılı tutulduğu sürece belirlenen arabanın timerını durdurur.
            }
            if (e.KeyCode == Keys.M)
            {
                timerMavi.Stop();
            }
            if (e.KeyCode == Keys.N)
            {
                timerYesil.Stop();
            }
        }

        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            
            if (e.KeyCode == Keys.B)
            {
                timerTuruncu.Start();//Belirlenen tuş serbest bırakıldığında belirlenen arabanın timerını başlatır.
            }
            if (e.KeyCode == Keys.M)
            {
                timerMavi.Start();
            }
            if (e.KeyCode == Keys.N)
            {
                timerYesil.Start();
            }
        }

        private void timerTuruncu_Tick(object sender, EventArgs e)
        {
            a = x.Next(3, 10);//Arabanın Lokasyonunu random bir şekilde değiştirir.
            pictureBox1.Left += a;
        }

        private void timerYesil_Tick(object sender, EventArgs e)
        {
            b = x.Next(3, 10);
            pictureBox2.Left += b;
        }

        private void timerMavi_Tick(object sender, EventArgs e)
        {
            c = x.Next(3, 10);
            pictureBox3.Left += c;
        }

        private void button7_Click_1(object sender, EventArgs e)
        {
            //Bütün değerleri eski haline getirip yarışı başa alır.
            bes = 4;
            butonTuruncuNitro.Enabled = false;
            butonYesilNitro.Enabled = false;
            butonMaviTurbo.Enabled = false;
            turuncuNitroBar.Value = 0;
            yesilNitroBar.Value = 0;
            maviNitroBar.Value = 0;
            button6.Enabled = true;
            button7.Enabled = false;
            timer1.Stop();
            timerTuruncu.Stop();
            timerYesil.Stop();
            timerMavi.Stop();
            pictureBox1.Location = new Point(109, 105);
            pictureBox2.Location = new Point(109, 250);
            pictureBox3.Location = new Point(109, 403);
            label1.ForeColor = Color.White;
            label1.Text = "Yarışı Başlat!";
            Class1.bahisbasma = 0;
            label2.ForeColor = Color.White;
            label2.Text = "Yatırdığınız araba: Yok\r\nYatırdığınız miktar: Yok\r\nAraba kazanırsa alacağınız miktar: Yok\r\n";
        }

        private void button8_Click_1(object sender, EventArgs e)
        {
            //Ana menüye dönme
            this.Hide();
            Form2 f2 = new Form2();
            f2.Show();
        }

        private void button9_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void timer5_Tick(object sender, EventArgs e)
        {
            // Geri Sayım Ve Başlatma
            if(bes == 4)
            {
                SoundPlayer player = new SoundPlayer(@"enginestart.wav");
                player.Play();
                label3.Visible = true;
                label3.Text = "3";
                bes--;
            }
            else if(bes == 3)
            {
                label3.Text = "2";
                bes--; 
            }
            else if(bes == 2)
            {
                label3.Text = "1";
                bes--;
                SoundPlayer player = new SoundPlayer(@"enginestart.wav");
                player.Stop();
            }
            else if(bes == 1)
            {
                label3.Text = "Go!";
                timer1.Start();
                turuncuNitroBar.Value = 100;
                maviNitroBar.Value = 100;
                yesilNitroBar.Value = 100;
                butonTuruncuNitro.Enabled = true;
                butonMaviTurbo.Enabled = true;
                butonYesilNitro.Enabled = true;
                timerTuruncu.Start();
                timerMavi.Start();
                timerYesil.Start();
                bes--;
                SoundPlayer player = new SoundPlayer(@"driving.wav");
                player.Play();
            }
            else if(bes == 0)
            {
                label3.Visible = false;
                timer5.Stop();
            }
        }

        private void butonTuruncuNitro_Click(object sender, EventArgs e)
        {
            if (turuncuNitroBar.Value != 0) //Turuncu Nitro
            {
                turuncuNitroBar.Value -= 5;
                Random rend = new Random();
                int trbo = rend.Next(10, 15);
                pictureBox1.Left += trbo;
            }
            else if (turuncuNitroBar.Value == 0)
            {
                button7.Enabled = false;
            } 
        }

        private void butonMaviTurbo_Click(object sender, EventArgs e)
        {
            if (maviNitroBar.Value != 0) //Mavi Nitro
            {
                maviNitroBar.Value -= 5;
                Random rend = new Random();
                int trbo = rend.Next(10, 15);
                pictureBox3.Left += trbo;
            }
            else if (maviNitroBar.Value == 0)
            {
                butonMaviTurbo.Enabled = false;
            }
        }

        private void butonYesilNitro_Click(object sender, EventArgs e)
        {
            if (yesilNitroBar.Value != 0) //Yeşil Nitro
            {
                yesilNitroBar.Value -= 5;
                Random rend = new Random();
                int trbo = rend.Next(10, 15);
                pictureBox2.Left += trbo;
            }
            else if (yesilNitroBar.Value == 0)
            {
                butonYesilNitro.Enabled = false;
            }
        }

        private void button11_Click(object sender, EventArgs e)
        {
            Form4 f4 = new Form4();
            f4.Show();
        }

        private void butonMaviTurbo_MouseDown(object sender, MouseEventArgs e)
        {
                if (maviNitroBar.Value != 0)
                {
                    butonMaviTurbo.PerformClick();
                }
                else if (maviNitroBar.Value == 0)
                {
                    butonMaviTurbo.Enabled = false;
                }
            }

        private void butonYesilNitro_MouseDown(object sender, MouseEventArgs e)
        {
            if (yesilNitroBar.Value != 0)
            {
                butonYesilNitro.PerformClick();
            }
            if (yesilNitroBar.Value == 0)
            {
                butonYesilNitro.Enabled = false;
            }
        }

        private void butonTuruncuNitro_MouseDown(object sender, MouseEventArgs e)
        {
            if (turuncuNitroBar.Value != 0)
            {
                butonTuruncuNitro.PerformClick();//Mouse ile basılı tutulduğunda nitro butonuna basar
            }
            if (turuncuNitroBar.Value == 0)
            {
                butonTuruncuNitro.Enabled = false;//Nitro barı sıfırlanırsa butonu pasif yapar.
            }
        }
    }
    }
