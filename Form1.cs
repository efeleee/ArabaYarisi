using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
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
        public Form1()
        {
            InitializeComponent();
        }



        private void button6_Click(object sender, EventArgs e)
        {
            timer1.Start();
            timer2.Start();
            timer3.Start();
            timer4.Start();
            timerTuruncu.Start();
            timerMavi.Start();
            timerYesil.Start();
            button6.Enabled = false;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {

            Bahis bahis = new Bahis();

            if (pictureBox1.Location.X > pictureBox2.Location.X && pictureBox1.Location.X > pictureBox3.Location.X)
            {
                label1.Text = "Turuncu Araba Önde";
                if (pictureBox1.Location.X > 1209)
                {
                    timer1.Stop();
                    timer2.Stop();
                    timer3.Stop();
                    timer4.Stop();
                    timerTuruncu.Stop();
                    timerMavi.Stop();
                    timerYesil.Stop();
                    label1.ForeColor = Color.Orange;
                    label1.Text = "TURUNCU ARABA KAZANDI!";
                    butonTuruncuNitro.Enabled = false;
                    butonYesilNitro.Enabled = false;
                    butonMaviTurbo.Enabled = false;
                    button7.Enabled = true;
                    Class1.turuncuwin = 1;
                    if (Class1.mavisec == 1)
                    {
                        label2.ForeColor = Color.Red;
                        label2.Text = "Bahisi kaybettin.\nSeçtiğin Araba: Mavi\nKaybettiğin Bütçe:" + Class1.butce + "₺";
                        Class1.kaybedilenpara = Class1.butce;
                    }
                    if (Class1.yesilsec == 1)
                    {
                        label2.ForeColor = Color.Red;
                        label2.Text = "Bahisi kaybettin.\nSeçtiğin Araba: Yeşil\nKaybettiğin Bütçe:" + Class1.butce + "₺";
                        Class1.kaybedilenpara = Class1.butce;
                    }
                    if (Class1.turuncusec == 1)
                    {
                        label2.ForeColor = Color.Green;
                        label2.Text = "Bahisi Kazandın!\nSeçtiğin Araba: Turuncu\nKazandığın Bütçe:" + Class1.butce * 2 + "₺";
                        Class1.kazanilanpara = Class1.butce * 2;
                    }
                }
            }
            else if (pictureBox2.Location.X > pictureBox1.Location.X && pictureBox2.Location.X > pictureBox3.Location.X)
            {
                label1.Text = "Yeşil Araba Önde";
                if (pictureBox2.Location.X > 1209)
                {
                    timer1.Stop();
                    timer2.Stop();
                    timer3.Stop();
                    timer4.Stop();
                    timerTuruncu.Stop();
                    timerMavi.Stop();
                    timerYesil.Stop();
                    label1.ForeColor = Color.Green;
                    label1.Text = "YEŞİL ARABA KAZANDI!";
                    butonTuruncuNitro.Enabled = false;
                    butonYesilNitro.Enabled = false;
                    butonMaviTurbo.Enabled = false;
                    button7.Enabled = true;
                    Class1.yesilwin = 1;
                    if (Class1.mavisec == 1)
                    {
                        label2.ForeColor = Color.Red;
                        label2.Text = "Bahisi kaybettin.\nSeçtiğin Araba: Mavi\nKaybettiğin Bütçe:" + Class1.butce + "₺";
                        Class1.kaybedilenpara = Class1.butce;
                    }
                    if (Class1.turuncusec == 1)
                    {
                        label2.ForeColor = Color.Red;
                        label2.Text = "Bahisi kaybettin.\nSeçtiğin Araba: Turuncu\nKaybettiğin Bütçe:" + Class1.butce + "₺";
                        Class1.kaybedilenpara = Class1.butce;
                    }
                    if (Class1.yesilsec == 1)
                    {
                        label2.ForeColor = Color.Green;
                        label2.Text = "Bahisi Kazandın!\nSeçtiğin Araba: Yeşil\nKazandığın Bütçe:" + Class1.butce * 2 + "₺";
                        Class1.kazanilanpara = Class1.butce * 2;
                    }
                }
            }
            else if (pictureBox3.Location.X > pictureBox1.Location.X && pictureBox3.Location.X > pictureBox2.Location.X)
            {
                label1.Text = "Mavi Araba Önde";
                if (pictureBox3.Location.X > 1209)
                {
                    timer1.Stop();
                    timer2.Stop();
                    timer3.Stop();
                    timer4.Stop();
                    timerTuruncu.Stop();
                    timerMavi.Stop();
                    timerYesil.Stop();
                    label1.ForeColor = Color.Blue;
                    label1.Text = "MAVİ ARABA KAZANDI!";
                    butonTuruncuNitro.Enabled = false;
                    butonYesilNitro.Enabled = false;
                    butonMaviTurbo.Enabled = false;
                    button7.Enabled = true;
                    Class1.maviwin= 1;
                    if (Class1.turuncusec == 1)
                    {
                        label2.ForeColor= Color.Red;
                        label2.Text = "Bahisi kaybettin.\nSeçtiğin Araba: Turuncu\nKaybettiğin Bütçe:" + Class1.butce + "₺";
                        Class1.kaybedilenpara = Class1.butce;
                    }
                    if (Class1.yesilsec == 1)
                    {
                        label2.ForeColor = Color.Red;
                        label2.Text = "Bahisi kaybettin.\nSeçtiğin Araba: Yeşil\nKaybettiğin Bütçe:" + Class1.butce + "₺";
                        Class1.kaybedilenpara = Class1.butce;
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

        

        private void button3_Click(object sender, EventArgs e)
        {

        }
        private void button10_Click(object sender, EventArgs e)
        {
            Form bahis = new Bahis();
            bahis.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if(turuncuNitroBar.Value != 0)
            {
                turuncuNitroBar.Value -= 5;
            }
            Random rend = new Random();
            int trbo = rend.Next(10, 15);
            pictureBox1.Left += trbo;

        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (yesilNitroBar.Value != 0)
            {
                yesilNitroBar.Value -= 5;
            }
            Random rend = new Random();
            int trbo = rend.Next(10, 15);
            pictureBox2.Left += trbo;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (maviNitroBar.Value != 0)
            {
                maviNitroBar.Value -= 5;
            }
            Random rend = new Random();
            int trbo = rend.Next(10, 15);
            pictureBox3.Left += trbo;
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
                timer2.Stop();
                butonTuruncuNitro.PerformClick();
            }
            if (e.KeyCode == Keys.C)
            {
                timer3.Stop();
                butonMaviTurbo.PerformClick();
            }
            if (e.KeyCode == Keys.X)
            {
                timer4.Stop();
                butonYesilNitro.PerformClick();
            }
            if (e.KeyCode == Keys.B)
            {
                timerTuruncu.Stop();
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

        private void timer2_Tick(object sender, EventArgs e)
        {
            if (turuncuNitroBar.Value != 100)
            {
                turuncuNitroBar.Value = turuncuNitroBar.Value + 1;
            }
            else if (turuncuNitroBar.Value == 100)
            {
                butonTuruncuNitro.Enabled = true;
            }
        }

        private void timer3_Tick(object sender, EventArgs e)
        {
            if (maviNitroBar.Value != 100)
            {
                maviNitroBar.Value = maviNitroBar.Value + 1;
            }
            else if (maviNitroBar.Value == 100)
            {
                butonMaviTurbo.Enabled = true;
            }
        }

        private void timer4_Tick(object sender, EventArgs e)
        {
            if (yesilNitroBar.Value != 100)
            {
                yesilNitroBar.Value = yesilNitroBar.Value + 1;
            }
            else if (yesilNitroBar.Value == 100)
            {
                butonYesilNitro.Enabled = true;
            }
        }

        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Z)
            {
                timer2.Start();
                butonTuruncuNitro.Enabled = false;
            }
            if (e.KeyCode == Keys.C)
            {
                timer3.Start();
                butonMaviTurbo.Enabled = false;
            }
            if (e.KeyCode == Keys.X)
            {
                timer4.Start();
                butonYesilNitro.Enabled = false;
            }
            if (e.KeyCode == Keys.B)
            {
                timerTuruncu.Start();
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
            a = x.Next(3, 10);
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
            butonTuruncuNitro.Enabled = false;
            butonYesilNitro.Enabled = false;
            butonMaviTurbo.Enabled = false;
            button6.Enabled = true;
            button7.Enabled = false;
            turuncuNitroBar.Value = 0;
            yesilNitroBar.Value = 0;
            maviNitroBar.Value = 0;
            timer1.Stop();
            timer2.Stop();
            timer3.Stop();
            timer4.Stop();
            timerTuruncu.Stop();
            timerYesil.Stop();
            timerMavi.Stop();
            pictureBox1.Location = new Point(109, 105);
            pictureBox2.Location = new Point(109, 250);
            pictureBox3.Location = new Point(109, 403);
            label2.ForeColor = Color.White;
            label2.Text = "Yarışı Başlat!";
        }

        private void button8_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            Form2 f2 = new Form2();
            f2.Show();
        }

        private void button9_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
