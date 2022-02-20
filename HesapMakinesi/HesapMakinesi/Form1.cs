using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HesapMakinesi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        double sonuc = 0;
        double sayi1 = 0;
        string islemTipi = "";
        private void button10_Click(object sender, EventArgs e)
        {
            SayiBasmaMetodu(button10.Text);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            SayiBasmaMetodu(button7.Text);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            SayiBasmaMetodu(button8.Text);
        }

        private void button9_Click(object sender, EventArgs e)
        {
            SayiBasmaMetodu(button9.Text);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            SayiBasmaMetodu(button4.Text);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            SayiBasmaMetodu(button5.Text);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            SayiBasmaMetodu(button6.Text);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SayiBasmaMetodu(button1.Text);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SayiBasmaMetodu(button2.Text);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            SayiBasmaMetodu(button3.Text);
        }

        private void SayiBasmaMetodu(string sayi)
        {
            tbEkran.Text += sayi;
        }

        private void islemYap(string islemTipi)
        {
            try
            {
                sayi1 = int.Parse(tbEkran.Text);

                switch (islemTipi)
                {
                    case "+":
                        sonuc += sayi1;
                        tbEkran.Clear();
                        EkranAyarlari(islemTipi);
                        break;
                    case "-":
                        sonuc -= sayi1;
                        tbEkran.Clear();
                        EkranAyarlari(islemTipi);
                        break;
                    case "*":
                        sonuc *= sayi1;
                        tbEkran.Clear();
                        EkranAyarlari(islemTipi);
                        break;
                    case "/":
                        try
                        {
                            sonuc /= sayi1;
                            tbEkran.Clear();
                            EkranAyarlari(islemTipi);
                        }
                        catch
                        {
                            lblToplam.Text = "Sıfıra Bölünemez";
                        }
                        break;
                    default:
                        break;
                }
            }
            catch
            {

            }
        }

        private void button13_Click(object sender, EventArgs e)
        {
            islemTipi = button13.Text;
            sayi1 = int.Parse(tbEkran.Text);
            if (string.IsNullOrEmpty(lblIslem.Text)) sonuc += sayi1;
            else sonuc -= sayi1;
            EkranAyarlari(islemTipi);
        }

        private void EkranAyarlari(string islemTipi)
        {
            if (string.IsNullOrEmpty(lblIslem.Text))
            {
                lblIslem.Text += sayi1.ToString();
                tbEkran.Clear();
                lblToplam.Text = sonuc.ToString();
            }
            else
            {
                lblIslem.Text += " " + islemTipi + " " + sayi1.ToString();
                tbEkran.Clear();
                lblToplam.Text = sonuc.ToString();
            }
        }

        private void button18_Click(object sender, EventArgs e)
        {
            tbEkran.Clear();
            lblIslem.Text = "";
            lblToplam.Text = "";
            sonuc = 0;
        }

        private void button12_Click(object sender, EventArgs e)
        {
            islemTipi = button12.Text;
            sayi1 = int.Parse(tbEkran.Text);
            if (string.IsNullOrEmpty(lblIslem.Text)) sonuc += sayi1;
            else sonuc *= sayi1;
            EkranAyarlari(islemTipi);
        }

        private void button17_Click(object sender, EventArgs e)
        {
            try
            {
                tbEkran.Text = tbEkran.Text.Substring(0, tbEkran.Text.Length - 1);
            }
            catch 
            {

            }
            
        }

        private void button14_Click(object sender, EventArgs e)
        {
            islemTipi = button14.Text;
            sayi1 = int.Parse(tbEkran.Text);
            sonuc += sayi1;
            EkranAyarlari(islemTipi);
        }

        private void button11_Click(object sender, EventArgs e)
        {
            islemTipi = button11.Text;
            sayi1 = int.Parse(tbEkran.Text);
            if (string.IsNullOrEmpty(lblIslem.Text)) sonuc += sayi1;
            else sonuc /= sayi1;
            EkranAyarlari(islemTipi);
        }

        private void button15_Click(object sender, EventArgs e)
        {
            SayiBasmaMetodu(button15.Text);
        }

        private void buttonEsit_Click(object sender, EventArgs e)
        {
            islemYap(islemTipi);
        }
    }
}
