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
            if (radioButton1.Checked == true)
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

        private void button1_Click(object sender, EventArgs e)
        {
            int a = Convert.ToInt32(textBox1.Text);
            yatirilanpara = a;
            label2.Text = "Miktar :" + b;
            b = b - yatirilanpara;
            label2.Text = "Miktar :" + b;
            Class1.butce = yatirilanpara;
            Class1.kalanpara = b;
        }

        private void Bahis_Load(object sender, EventArgs e)
        {
            b = Class1.kalanpara - Class1.kaybedilenpara + Class1.kazanilanpara;
            label2.Text = "Miktar :" + b.ToString();
        }
    }
}
