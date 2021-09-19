using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace MathProf
{
    public partial class Simülasyon : Form
    {

        public Simülasyon()
        {
            InitializeComponent();
            label7.Text = "Formül: C(n,r) = n! / r!(n-r)!";
            label8.Text = "Formül: P(n,r) = n! / (n-r)!";           
            kume1txt.Text = "1,2,4,6";
            kume2txt.Text = "2,3,4,5";
            label12.Visible = false;
            label13.Visible = false;
            label14.Visible = false;
            label15.Visible = false;
            label16.Visible = false;
            label19.Visible = false;
            label20.Visible = false;

        }
        int[] dizi1 = { 1, 2, 4, 6 };
        int[] dizi2 = { 2, 3, 4, 5 };

        private void button1_Click(object sender, EventArgs e)
        {
            Permutasyon_Hesapla();
        }
        

        private void btn_komb_hesapla_Click(object sender, EventArgs e)
        {
            Kombinasyon_Hesapla();
        }
        private void kumehesapla_Click(object sender, EventArgs e)
        {
            label12.Visible = true;
            label13.Visible = true;
            label14.Visible = true;
            label15.Visible = true;
            label16.Visible = true;
            label19.Visible = true;
            label20.Visible = true;
            ElemanSayisi();
            Kesisim();
            Birlesim();
            Fark();
            AltKume1();
            AltKume2();
        }

        private void txt_r_TextChanged(object sender, EventArgs e)
        {

        }
        
        void Permutasyon_Hesapla()
        {
            int n, r, per, fakt, fakt1;
            n = Convert.ToInt32(txt_n.Text);
            r = Convert.ToInt32(txt_r.Text);

            fakt = n;
            for (int i = n - 1; i >= 1; i--)
            {
                fakt = fakt * i;
            }

            int number;
            number = n - r;
            fakt1 = number;
            for (int i = number - 1; i >= 1; i--)
            {
                fakt1 = fakt1 * i;
            }
            per = fakt / fakt1;
            txt_sonuc.Text = per.ToString();
        }
        void Kombinasyon_Hesapla()
        {
            int n, r, kombinasyon, fakt, fakt1, fakt2;
            n = Convert.ToInt32(txt_nk.Text);
            r = Convert.ToInt32(txt_rk.Text);

            fakt = n;
            for (int i = n - 1; i >= 1; i--)
            {
                fakt = fakt * i;
            }
            fakt2 = r;
            for (int i = r - 1; i >= 1; i--)
            {
                fakt2 = fakt2 * i;
            }

            int number;
            number = n - r;
            fakt1 = number;
            for (int i = number - 1; i >= 1; i--)
            {
                fakt1 = fakt1 * i;
            }
            fakt1 = fakt2 * fakt1;
            kombinasyon = fakt / fakt1;
            txt_sonuck.Text = kombinasyon.ToString();
        }               
        void ElemanSayisi()
        {
            Kume kume1 = new Kume(dizi1);
            Kume kume2 = new Kume(dizi2);
            label12.Text = "1.kümenin eleman sayısı: " + kume1.ElemanSayisi;
            label13.Text = "2.kümenin eleman sayısı: " + kume2.ElemanSayisi;
        }
        void Kesisim()
        {
            Kume kume1 = new Kume(dizi1);
            Kume kume2 = new Kume(dizi2);
            var kesisim = kume1 & kume2;
            label14.Text = "kümelerin kesişimi:" + kesisim;

        }
        void Birlesim()
        {
            Kume kume1 = new Kume(dizi1);
            Kume kume2 = new Kume(dizi2);
            var birlesim = kume1 + kume2;
            label15.Text = "Kümelerin birleşimi:" + birlesim;
        }
        void Fark()
        {
            Kume kume1 = new Kume(dizi1);
            Kume kume2 = new Kume(dizi2);
            var fark = kume1 / kume2;
            label16.Text = "Kümelerin farkı:" + fark;
        }
        void AltKume1()
        {
            Kume kume1 = new Kume(dizi1);            
            String s = "";            
            for (int i = 0; i < Math.Pow(2, dizi1.Length); i++)
            {
                int b = i;
                s += "(";
                for (int j = 0; j < 4; j++)
                {
                    if ((b & 1) == 1)
                        s += dizi1[j].ToString() + ",";
                    b = b >> 1;
                }
                s += ")";
                
            }

            label19.Text = "Küme1: " + (s);

        }
        void AltKume2()
        {
            Kume kume1 = new Kume(dizi1);
            String s = "";
            for (int i = 0; i < Math.Pow(2, dizi2.Length); i++)
            {
                int b = i;
                s += "(";
                for (int j = 0; j < 4; j++)
                {
                    if ((b & 1) == 1)
                        s += dizi2[j].ToString() + ",";
                    b = b >> 1;
                }
                s += ")";

            }

            label20.Text = "Küme2: " + (s);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Matematik mat = new Matematik();
            mat.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int t, u, sonuc = 1;
            t = Convert.ToInt32(textBox3.Text);
            u = Convert.ToInt32(textBox2.Text);
            for(int i = 1; i <= u; i++)
            {
                sonuc = sonuc * t;
            }
            textBox1.Text = sonuc.ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            double s = Convert.ToDouble(textBox6.Text);
            textBox4.Text = Math.Sqrt(s).ToString();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            int sayi, sonuc = 1;
            sayi = Convert.ToInt32(textBox5.Text);
            for(int i = 1; i <= sayi; i++)
            {
                sonuc *= i;
            }
            textBox7.Text = sonuc.ToString();
        }

        private void label24_Click(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
