using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace ArabaYarisi
{
    public partial class Bahis : Form
    {
        public int a;
        public int b, c, d;
        public int yatirilanpara;
        public Bahis()
        {
            InitializeComponent();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked == true)//Classdaki seçilen araba değişkenini değiştirir.
            {
                Class1.turuncusec = 1;
            }
            else
            {
                Class1.turuncusec = 0;
            }
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton2.Checked == true)
            {
                Class1.yesilsec = 1;
            }
            else
            {
                Class1.yesilsec = 0;
            }
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton3.Checked == true)
            {
                Class1.mavisec = 1;
            }
            else
            {
                Class1.mavisec = 0;
            }
        }

        private void Bahis_FormClosed(object sender, FormClosedEventArgs e)
        {
            Form1 f1 = new Form1();
            if(Class1.turuncusec == 1)//Yarış ekranındaki yazıyı değiştirir.
            {
                f1.label2.Text = "Yatırdığınız Araba:" + "Turuncu\nYatırdığınız Miktar:" + Class1.butce +"\nAraba kazanırsa alacağınız miktar:" + Class1.butce * 2 + "₺";
                f1.Controls.Clear();
                f1.InitializeComponent();
            }
            if (Class1.mavisec == 1)
            {
                f1.label2.Text = "Yatırdığınız Araba:" + "Mavi\nYatırdığınız Miktar:" + Class1.butce + "\nAraba kazanırsa alacağınız miktar:" + Class1.butce * 2 + "₺";
                f1.Controls.Clear();
                f1.InitializeComponent();
            }
            if (Class1.yesilsec == 1)
            {
                f1.label2.Text = "Yatırdığınız Araba:" + "Yeşil\nYatırdığınız Miktar:" + Class1.butce + "\nAraba kazanırsa alacağınız miktar:" + Class1.butce * 2 + "₺";
                f1.Controls.Clear();
                f1.InitializeComponent();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)//Sadece sayı girişi.
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void Bahis_Deactivate(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                MessageBox.Show("Boş Alan Bırakılamaz");
            }
            else if (radioButton1.Checked == false && radioButton2.Checked == false && radioButton3.Checked == false)
            {
                MessageBox.Show("Lütfen Araba Seçin");  
            }
            else if (a > b)
            {
                MessageBox.Show("Paranız Yeterli Değil");
            }
            else
            {
                int a = Convert.ToInt32(textBox1.Text);
                yatirilanpara = a;
                label2.Text = "Miktar :" + b + "₺";
                b = b - yatirilanpara;
                label2.Text = "Miktar :" + b + "₺";
                Class1.butce = yatirilanpara;
                Class1.kalanpara = b;
                Class1.bahisbasma = 1;
                button1.Enabled = false;
            }
        }

        private void Bahis_Load(object sender, EventArgs e)
        {
            b = Class1.kalanpara + Class1.kazanilanpara;
            label2.Text = "Miktar :" + b.ToString() + "₺";
        }
    }
}
