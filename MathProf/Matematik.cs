using System;
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
    public partial class Matematik : Form
    {
        public Matematik()
        {
            InitializeComponent();
            string[] seneler = { "2017", "2018", "2019", "2020", "2021" };
            yearsCombo.Items.AddRange(seneler);
            label3.Visible = false;
            btnsoru.Visible = false;           
            soruresim.Visible = false;
            cözümGroup.Visible = false;
            cözümtxt.Visible = false;
            devamlabel.Visible = false;
            cözümresim.Visible = false;
            
        }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(yearsCombo.Text == "2017")
            {
                topicList.Items.Clear();
                topicList.Items.Add("Kümeler");
                topicList.Items.Add("Polinom");
                topicList.Items.Add("Hız Problemi");
                topicList.Items.Add("Sayı Problemi");
                topicList.Items.Add("Yüzde Problemi");
                topicList.Items.Add("Karışım Problemi");
                topicList.Items.Add("Eşitsizlikler");
                topicList.Items.Add("Permütasyon-Kombinasyon"); 
                
            }
            else if(yearsCombo.Text == "2018")
            {
                topicList.Items.Clear();
                topicList.Items.Add("Kümeler");
                topicList.Items.Add("Üslü Sayılar");
                topicList.Items.Add("Köklü Sayılar");
                topicList.Items.Add("Yaş Problemi");
                topicList.Items.Add("Yüzde Problemi");
                topicList.Items.Add("Permütasyon-Kombinasyon");
            }
            else if (yearsCombo.Text == "2019")
            {
                topicList.Items.Clear();
                topicList.Items.Add("Kümeler");
                topicList.Items.Add("Üslü Sayılar");                
                topicList.Items.Add("Kesirli Sayılar");
                topicList.Items.Add("Karışım Problemi");
                topicList.Items.Add("Yüzde Problemi");
                topicList.Items.Add("Hız Problemi");
                topicList.Items.Add("Permütasyon-Kombinasyon");
            }
            else if (yearsCombo.Text == "2020")
            {
                topicList.Items.Clear();
                topicList.Items.Add("Kümeler");
                topicList.Items.Add("Üslü Sayılar");
                topicList.Items.Add("Eşitsizlikler");
                topicList.Items.Add("Oran Orantı");
                topicList.Items.Add("Sayı Problemi");
                topicList.Items.Add("Yaş Problemi");                
                topicList.Items.Add("Permütasyon-Kombinasyon");
            }
            else if (yearsCombo.Text == "2021")
            {
                topicList.Items.Clear();
                topicList.Items.Add("Kümeler");
                topicList.Items.Add("Üslü Sayılar");
                topicList.Items.Add("Köklü Sayılar");
                topicList.Items.Add("Sayı Problemi");
                topicList.Items.Add("Yaş Problemi");
                topicList.Items.Add("Oran Orantı");
            }
        }

        private void topicList_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (topicList.Text == "Yaş Problemi")
            {
                devamlabel.Visible = false;
                cözümGroup.Visible = false;
                cözümtxt.Visible = false;
                soruresim.Visible = false;
                btnsoru.Visible = true;
                label3.Visible = true;
                label3.Text = "1. n kişinin bugünki yaşları toplamı a ise \n" +
                    "1.1 x yıl sonraki yaşları toplamı = a+x*n \n" +
                    "1.2 x yıl önceki yaşları toplamı = a-x*n \n" +
                    "2. İki kişinin bugün ki yaş farkı a-b ise yıllar geçsede yaş \n farkı yine a-b olur. \n" +
                    "3. n kişinin bugünki yaşları toplamı a ise \n" +
                    "3.1 x yıl sonraki yaş ortalaması = (a+n*x)/n \n" +
                    "3.2 x yıl önce yaş ortalaması = (a-n*x)/n \n";
            }
            else if (topicList.Text == "Kümeler")
            {
                devamlabel.Visible = false;
                cözümGroup.Visible = false;
                cözümtxt.Visible = false;
                soruresim.Visible = false;
                btnsoru.Visible = true;
                label3.Visible = true;
                label3.Text = "- Boş küme her kümenin alt kümesidir. (Ø⊂A) \n" +
                    "- Her küme kendisinin alt kümesidir. (A⊂A) \n" +
                    "- Her küme evrensel kümenin alt kümesidir. (A⊂E) \n" +
                    "- A, B ve C kümeleri verilsin. (A⊂B) ve (B⊂C) ise A⊂C dir. \n" +
                    "- A ve B kümeleri verilsin. (A⊂B) ve (B⊂A) ⇔ A = B dir. \n" +
                    "- s(A) = n olmak üzere, A kümesinin alt küme sayısı; 2n dir. \n" +
                    "- A kümesinin özalt kümelerinin sayısı 2n – 1 dir. \n" +
                    "-A ile B kümelerinin tüm elemanlarından oluşan küme: A∪B\n" +
                    "- A ve B gibi iki kümenin ortak elemanlarından oluşan\nkümeye: A∩B";
            }
            else if (topicList.Text == "Sayı Problemi")
            {
                devamlabel.Visible = false;
                cözümGroup.Visible = false;
                cözümtxt.Visible = false;
                soruresim.Visible = false;
                btnsoru.Visible = true;
                label3.Visible = true;
                label3.Text = "Verilen problemi anladıktan sonra bilinmeyenleri \n" +
                    "'x',''y','a','b' gibi sembollerle ifade etmektir.";
            }
            else if (topicList.Text == "Kesirli Sayılar")
            {
                devamlabel.Visible = false;
                cözümGroup.Visible = false;
                cözümtxt.Visible = false;
                soruresim.Visible = false;
                btnsoru.Visible = true;
                label3.Visible = true;
                label3.Text = "";
            }
            else if (topicList.Text == "Yüzde Problemi")
            {
                devamlabel.Visible = false;
                cözümGroup.Visible = false;
                cözümtxt.Visible = false;
                soruresim.Visible = false;
                btnsoru.Visible = true;
                label3.Visible = true;
                label3.Text = "x>0 olmak üzere \n" +
                    "- x sayısının %a'sı: (x)*(a/100)\n" +
                    "- x sayısının %a fazlası: (x)*((100+a)/100) \n" +
                    "- x sayısının %a eksiği: (x)*((100-a)/100) \n" +
                    "- x sayısının %a fazlasının %b si: b/100*x*((100+a)/100)";
            }
            else if (topicList.Text == "Üslü Sayılar")
            {
                devamlabel.Visible = false;
                cözümGroup.Visible = false;
                cözümtxt.Visible = false;
                soruresim.Visible = false;
                btnsoru.Visible = true;
                label3.Visible = true;
                label3.Text = "- 1'in bütün kuvvetleri 1'dir. \n" +
                    "- 0 dışındaki tüm sayıların 0. kuvveti: 1'dir.\n" +
                    "- 0'ın 0 hariç bütün kuvvetleri 0'dır.\n" +
                    "- Taban ve üs 0 ise o işlem belirsizdir.\n" +
                    "- Negatif sayılar parantez içinde ve kuvvetleri çift sayı ise " +
                    "\n sonuç pozitif olur, " +
                    "kuvvetleri tek sayı ise sonuç negatif olur.\n" +
                    "- Tabanları aynı iki üslü sayının çarpımı, taban üzeri\nkuvvetlerin toplamıdır.\n" +
                    "- Tabanları aynı iki üslü sayının bölümü taban üzeri\nkuvvetlerin farkıdır.";
            }
            else if (topicList.Text == "Oran Orantı")
            {
                devamlabel.Visible = false;
                cözümGroup.Visible = false;
                cözümtxt.Visible = false;
                soruresim.Visible = false;
                btnsoru.Visible = true;
                label3.Visible = true;
                label3.Text = "- Oran\n" +
                    "Parça(Parça1, Parça2)\n" +
                    "Bütün\n" +
                    "Sonuç\n" +
                    "Parça = Parça1*Oran\n" +
                    "Sonuç = Bütün-Parça\n" +
                    "Sonuç = Bütün*Parça\n" +
                    "- Oran orantı sorularında mantık, bütünün parçayla olan \nilişkisiyle istenileni" +
                    "bulmaktır. Değişkenler her soruda \nfarklı isim alıp, farklı " +
                    "işlemler görebilir ancak mantık aynıdır.";

            }
            else if (topicList.Text == "Polinom")
            {
                cözümGroup.Visible = false;
                cözümtxt.Visible = false;
                soruresim.Visible = false;
                devamlabel.Visible = true;
                btnsoru.Visible = true;
                label3.Visible = true;
                devamlabel.Text = "Devamı -->";
                label3.Text = "İki polinom toplanırken; dereceleri aynı olan\n" +
                    "terimlerin katsayıları kendi aralarında toplanır, o\n" +
                    "terimin kat sayısı olarak yazılır.\n" +
                    "- x^n + b.x^n = (a+b).x^n\n" +
                    "- x^n + b.x^n = (1+b).x^n\n" +
                    "İki polinom çıkarılırken; dereceleri aynı olan terimlerin\n" +
                    "katsayıları kendi aralarında çıkarılır, o terimin katsayısı\n" +
                    "olarak yazılır.\n" +
                    "İki polinomun çarpımı; birisinin her teriminin diğerinin her\n" +
                    "bir terimi ile ayrı ayrı çarpımlarından elde edilen terimlerin\n" +
                    "toplamına eşittir.\n" +
                    "- ax^n.bx^m = a.b.x^m+n\n" +
                    "- x^n.b^n = b.x^n+m";

            }
            else if (topicList.Text == "Hız Problemi")
            {
                devamlabel.Visible = false;
                cözümGroup.Visible = false;
                cözümtxt.Visible = false;
                soruresim.Visible = false;
                btnsoru.Visible = true;
                label3.Visible = true;
                label3.Text = "- Yol = Hız * Zaman\n" +
                    "- Dairesel pistte 2 araç zıt yönde hareket ederse\n" +
                    "Pistin Çevresi = (V1 + V2).t = Ç\n" +
                    "- Aynı yönde hareket ederse\n" +
                    "Pistin Çevresi = (V1 - V2).t = Ç\n" +
                    "- Ortalama Hız = Toplam Yol / Toplam Zaman";
            }
            else if (topicList.Text == "Permütasyon-Kombinasyon")
            {
                cözümGroup.Visible = false;
                cözümtxt.Visible = false;
                soruresim.Visible = false;
                btnsoru.Visible = true;
                label3.Visible = true;
                devamlabel.Visible = true;
                devamlabel.Text = "Kombinasyon";
                label3.Text = "- n elemanlı bir kümeden seçilen r elemanlı\n" +
                    "'tekrarsız' permütasyonların toplamı (n ≥ r olmak şartıyla)\n" +
                    "aşağıdaki formülle ifade edilir:\n" +
                    "P(n,r) = n! / (n-r)!\n" +
                    "- Tekrarlı ise n^r formülü ile ifade edilir.";
            }
            else if (topicList.Text == "Eşitsizlikler")
            {
                devamlabel.Visible = false;
                cözümGroup.Visible = false;
                cözümtxt.Visible = false;
                soruresim.Visible = false;
                btnsoru.Visible = true;
            }
            else if (topicList.Text == "Köklü Sayılar")
            {
                devamlabel.Visible = false;
                cözümGroup.Visible = false;
                cözümtxt.Visible = false;
                soruresim.Visible = false;
                btnsoru.Visible = true;
                label3.Visible = true;
                label3.Text = "- Çarpma işleminde katsayı kısımları kendi arasında\n" +
                    "kök kısımları kendi arasında çarpılır.\n" +
                    "- Bölmede  Sayının katsayı kısımları kendi arasında kök\n" +
                    "kısımları kendi arasında bölünür.\n" +
                    "- Toplama ve çıkarma işlemlerinin yapılabilmesi için kök\n" +
                    "içindeki sayıların ve kuvvetlerin aynı olması gerekmektedir.\n" +
                    "Kökler aynı değilse sadeleştirilme yapılarak kökün dışına\nsayı çıkarılır." +
                    "Dışarı çıkan katsayılar çıkarılır ya da toplanır.";
            }
            else if (topicList.Text == "Karışım Problemi")
            {
                devamlabel.Visible = false;
                cözümGroup.Visible = false;
                cözümtxt.Visible = false;
                soruresim.Visible = false;
                btnsoru.Visible = true;
                label3.Visible = true;
                label3.Text = "- Karışımın Oranı = Saf Madde / Toplam Madde\n" +
                    "- Tuz oranı %A olan tuzlu sunun su oranı: %(100-A)";
             }           
            
        }

        private void btnsoru_Click(object sender, EventArgs e)
        {
            if (yearsCombo.Text == "2018" && topicList.Text == "Yaş Problemi")
            {
                soruresim.Visible = true;
                soruresim.SizeMode = PictureBoxSizeMode.StretchImage;
                soruresim.BorderStyle = BorderStyle.Fixed3D;
                soruresim.Image = Image.FromFile(Application.StartupPath + "\\Sorular\\2018tytyas.png");
                cözümGroup.Visible = true;
                cözümtxt.Visible = true;
                cözümresim.Visible = false;
                cözümtxt.Text = "Üç arkadaşın yaşları toplamı=3*20=60 \n" +
                    "x yıl sonra çocuklarıyla yaşları toplamı=3*(20+x )=60+3x \n" +
                    "çoçukların yaşları toplamı=60+3x–(28+30+32)=3x-30 olur.\n" +
                    "(60+3x+3x-30)/6=20\n" +
                    "6x+30=120 , 6x=90, x=15 yıl sonra bir araya gelmişlerdir.";
            }
            else if (yearsCombo.Text == "2017" && topicList.Text == "Kümeler")
            {
                soruresim.Visible = true;
                soruresim.SizeMode = PictureBoxSizeMode.StretchImage;
                soruresim.BorderStyle = BorderStyle.Fixed3D;
                soruresim.Image = Image.FromFile(Application.StartupPath + "\\Sorular\\2017tytküme.png");
                cözümGroup.Visible = true;
                cözümtxt.Visible = true;
                cözümresim.Visible = false;
                cözümtxt.Text = "- s(AUB) = 24 ise verilen ilk ifadeden \n" +
                    "3x = 24 çıkar. s(A)=2x olduğuna göre 2x=16. s(A)=16";

            }
            else if (yearsCombo.Text == "2018" && topicList.Text == "Kümeler")
            {
                soruresim.Visible = true;
                soruresim.SizeMode = PictureBoxSizeMode.StretchImage;
                soruresim.BorderStyle = BorderStyle.Fixed3D;
                soruresim.Image = Image.FromFile(Application.StartupPath + "\\Sorular\\2018tytküme.png");
                cözümGroup.Visible = true;
                cözümtxt.Visible = true;
                cözümresim.Visible = false;
                cözümtxt.Text = "A ve B nin taralı olduğu sarı alanın şartı A ile başlayan\n 5 harfli" +
                    "isimler olduğundan Aysun ve Ahmet olur.\n 2 tanedir." +
                    "B ve N nin taralı olduğu sarı alanın\nşartı ise N ile biten 5 harfli isimler" +
                    "olduğundan Beren ve\nKenan olur. Bunlarda 2 tane olduğundan\ncevap 4 olur.";
            }
            else if (yearsCombo.Text == "2019" && topicList.Text == "Kümeler")
            {
                soruresim.Visible = true;
                soruresim.SizeMode = PictureBoxSizeMode.StretchImage;
                soruresim.BorderStyle = BorderStyle.Fixed3D;
                soruresim.Image = Image.FromFile(Application.StartupPath + "\\Sorular\\2019tytküme.png");
                cözümGroup.Visible = true;
                cözümtxt.Visible = true;
                cözümresim.Visible = false;
                cözümtxt.Text = "A kümesi: 2k\nB kümesi: 3k\nC kümesi: 12k\nBuna göre;" +
                    "- 18, 2’nin ve 3’ün katı olduğundan  boyalı bölgededir.\n" +
                    "- 24, 2’nin 3’ün ve 12’nin katı olduğundan C nin içindedir\nyani boyalı bölgede değildir\n" +
                    "- 42, 2’nin ve 3’ ün katı olduğundan  boyalı bölgededir.";
            }
            else if (yearsCombo.Text == "2020" && topicList.Text == "Kümeler")
            {
                soruresim.Visible = true;
                soruresim.SizeMode = PictureBoxSizeMode.StretchImage;
                soruresim.BorderStyle = BorderStyle.Fixed3D;
                soruresim.Image = Image.FromFile(Application.StartupPath + "\\Sorular\\2020tytküme.png");
                cözümGroup.Visible = true;
                cözümtxt.Visible = true;
                cözümresim.Visible = false;
                cözümtxt.Text = "A nın elemanları = 0,5,2,7,3,1,4,6,8\n" +
                    "A'nın toplam elemanı 9 tanedir.\n" +
                    "9 rakamı B'nin elemanı olduğundan A 8 yazılır.\n" +
                    "A/B = 2+7+3+8 = 20";
            }
            else if (yearsCombo.Text == "2021" && topicList.Text == "Kümeler")
            {
                soruresim.Visible = true;
                soruresim.SizeMode = PictureBoxSizeMode.StretchImage;
                soruresim.BorderStyle = BorderStyle.Fixed3D;
                soruresim.Image = Image.FromFile(Application.StartupPath + "\\Sorular\\2021tytküme.png");
                cözümresim.Visible = true;
                cözümresim.SizeMode = PictureBoxSizeMode.StretchImage;
                cözümresim.BorderStyle = BorderStyle.Fixed3D;
                cözümresim.Image = Image.FromFile(Application.StartupPath + "\\Sorular\\2021tytkümecözüm.png");
                cözümGroup.Visible = true;
                cözümtxt.Visible = true;
                cözümtxt.Text = "- Sanatçı olamaz, olması için 4 harf alması gerekir.";
            }
            else if (yearsCombo.Text == "2017" && topicList.Text == "Polinom")
            {
                soruresim.Visible = true;
                soruresim.SizeMode = PictureBoxSizeMode.StretchImage;
                soruresim.BorderStyle = BorderStyle.Fixed3D;
                soruresim.Image = Image.FromFile(Application.StartupPath + "\\Sorular\\2017polinom.png");
                cözümGroup.Visible = true;
                cözümtxt.Visible = true;
                cözümresim.Visible = false;
                cözümtxt.Text = "P(x)=x+1+x+2+...+x+9\n" +
                    "=9x+1+2+...+9\n" +
                    "=9x+(9*10)/2\n" +
                    "P(x)=9x+45\n" +
                    "Q(x)=x+1+x+2+...+x+5\n" +
                    "=5x+1+2+...+5" +
                    "=5x+(5*6)/2" +
                    "Q(x)=5x+15" +
                    "Q(x)=0 için 5x=-15 x=-3\n" +
                    "P(-3)=9*(-3)+45=18";
            }
            else if (yearsCombo.Text == "2017" && topicList.Text == "Karışım Problemi")
            {
                soruresim.Visible = true;
                soruresim.SizeMode = PictureBoxSizeMode.StretchImage;
                soruresim.BorderStyle = BorderStyle.Fixed3D;
                soruresim.Image = Image.FromFile(Application.StartupPath + "\\Sorular\\2017karisim.png");
                cözümGroup.Visible = true;
                cözümtxt.Visible = true;
                cözümresim.Visible = false;
                cözümtxt.Text = "1 Kek = 3 Un + 1 Süt + 2 Yumurta\n" +
                    "Eldeki un bitince kalan süt=2, yumurta=6\n" +
                    "Sütün tamamını keke harcadığında ise 4 yumurta\n" +
                    "daha harcanır. Kalan yumurta 2 olur.";
            }
            else if (yearsCombo.Text == "2017" && topicList.Text == "Eşitsizlikler")
            {
                soruresim.Visible = true;
                soruresim.SizeMode = PictureBoxSizeMode.StretchImage;
                soruresim.BorderStyle = BorderStyle.Fixed3D;
                soruresim.Image = Image.FromFile(Application.StartupPath + "\\Sorular\\2017esitsizlik.png");
                cözümGroup.Visible = true;
                cözümtxt.Visible = true;
                cözümresim.Visible = false;
                cözümtxt.Text = "-3/2<x<7/2\n" +
                    "-7/2<-x<3/2\n" +
                    "5-7/2<5-x<5+3/2" +
                    "1,5<5-x<6,5" +
                    "x'in alabileceği değerler: 2,3,4,5,6\n" +
                    "Toplamı: 20";
            }
            else if (yearsCombo.Text == "2017" && topicList.Text == "Hız Problemi")
            {
                soruresim.Visible = true;
                soruresim.SizeMode = PictureBoxSizeMode.StretchImage;
                soruresim.BorderStyle = BorderStyle.Fixed3D;
                soruresim.Image = Image.FromFile(Application.StartupPath + "\\Sorular\\2017ygshiz.png");
                cözümGroup.Visible = true;
                cözümtxt.Visible = true;
                cözümresim.Visible = false;
                cözümtxt.Text = "X = V*T\n" +
                    "X1 = 120*8/60=16 km\n" +
                    "X = 95*12/60=19 km\n" +
                    "X2 = 19-16=3 km\n" +
                    "X2 = V*2/60=3 ise V=90 olmalıdır.";
            }
            else if (yearsCombo.Text == "2017" && topicList.Text == "Permütasyon-Kombinasyon")
            {
                soruresim.Visible = true;
                soruresim.SizeMode = PictureBoxSizeMode.StretchImage;
                soruresim.BorderStyle = BorderStyle.Fixed3D;
                soruresim.Image = Image.FromFile(Application.StartupPath + "\\Sorular\\2017perm.png");
                cözümGroup.Visible = true;
                cözümtxt.Visible = true;
                cözümresim.Visible = false;
                cözümtxt.Text = "8 in 2li kombinasyonu: 8*7/2=28\n" +
                    "28*3=84 hakem görev almalı\n" +
                    "84 hakem 4 kişi arasında paylaştırılacak.\n" +
                    "84/4=21";
            }
            else if (yearsCombo.Text == "2017" && topicList.Text == "Sayı Problemi")
            {
                soruresim.Visible = true;
                soruresim.SizeMode = PictureBoxSizeMode.StretchImage;
                soruresim.BorderStyle = BorderStyle.Fixed3D;
                soruresim.Image = Image.FromFile(Application.StartupPath + "\\Sorular\\2017sayi.png");
                cözümGroup.Visible = true;
                cözümtxt.Visible = true;
                cözümresim.Visible = false;
                cözümtxt.Text = "k/2=e/3 ise 3k=2e, k=2x, e=3x\n" +
                    "2*12=24, 2x=24, x=12\n" +
                    "2x+3x=5x\n" +
                    "5*12=60\n" +
                    "60/2=30";
            }
            else if (yearsCombo.Text == "2017" && topicList.Text == "Yüzde Problemi")
            {
                soruresim.Visible = true;
                soruresim.SizeMode = PictureBoxSizeMode.StretchImage;
                soruresim.BorderStyle = BorderStyle.Fixed3D;
                soruresim.Image = Image.FromFile(Application.StartupPath + "\\Sorular\\2017yüzde.png");
                cözümGroup.Visible = true;
                cözümtxt.Visible = true;
                cözümresim.Visible = false;
                cözümtxt.Text = "- Ucuz --> 100x %25 indirim ise = 75x\n" +
                    "75*20/100=15 75-15=60x\n" +
                    "- Pahalı --> 100y %25 indirim ise = 75y\n" +
                    "100y-75y=25y\n" +
                    "40x=25y= 40*5*1/10 + 25*8*1/10 = 40";
            }
            else if (yearsCombo.Text == "2018" && topicList.Text == "Köklü Sayılar")
            {
                soruresim.Visible = true;
                soruresim.SizeMode = PictureBoxSizeMode.StretchImage;
                soruresim.BorderStyle = BorderStyle.Fixed3D;
                soruresim.Image = Image.FromFile(Application.StartupPath + "\\Sorular\\2018kok.png");
                cözümGroup.Visible = true;
                cözümtxt.Visible = true;
                cözümresim.Visible = false;
                cözümtxt.Text = "Kareleri alınarak kökten kurtul.\n" +
                    "a ifadesinin karesi: 1/2\n" +
                    "b ifadesinin karesi: 5/9\n" +
                    "c ifadesinin kares: 7/16\n" +
                    "Parça mantığına göre: C<A<B olur.";
            }
            else if (yearsCombo.Text == "2018" && topicList.Text == "Üslü Sayılar")
            {
                soruresim.Visible = true;
                soruresim.SizeMode = PictureBoxSizeMode.StretchImage;
                soruresim.BorderStyle = BorderStyle.Fixed3D;
                soruresim.Image = Image.FromFile(Application.StartupPath + "\\Sorular\\2018uslu.png");
                cözümGroup.Visible = true;
                cözümtxt.Visible = true;
                cözümresim.Visible = true;
                cözümresim.SizeMode = PictureBoxSizeMode.StretchImage;
                cözümresim.BorderStyle = BorderStyle.Fixed3D;
                cözümresim.Image = Image.FromFile(Application.StartupPath + "\\Sorular\\2018uslucöz.png");
                cözümtxt.Text = "3 parçaya ayırsaydı 4.adım sonunda : 3^4 = 81";
            }
            else if (yearsCombo.Text == "2018" && topicList.Text == "Yüzde Problemi")
            {
                soruresim.Visible = true;
                soruresim.SizeMode = PictureBoxSizeMode.StretchImage;
                soruresim.BorderStyle = BorderStyle.Fixed3D;
                soruresim.Image = Image.FromFile(Application.StartupPath + "\\Sorular\\2018yuzde.png");
                cözümGroup.Visible = true;
                cözümtxt.Visible = true;
                cözümresim.Visible = false;
                cözümtxt.Text = "";
            }
            else if (yearsCombo.Text == "2018" && topicList.Text == "Permütasyon-Kombinasyon")
            {
                soruresim.Visible = true;
                soruresim.SizeMode = PictureBoxSizeMode.StretchImage;
                soruresim.BorderStyle = BorderStyle.Fixed3D;
                soruresim.Image = Image.FromFile(Application.StartupPath + "\\Sorular\\2018perm.png");
                cözümGroup.Visible = true;
                cözümtxt.Visible = true;
                cözümresim.Visible = false;
                cözümtxt.Text = "18-x+17-x+16-x+x=25\n" +
                    "=51-2x=25\n" +
                    "x=13";
            }
            else if (yearsCombo.Text == "2019" && topicList.Text == "Karışım Problemi")
            {
                soruresim.Visible = true;
                soruresim.SizeMode = PictureBoxSizeMode.StretchImage;
                soruresim.BorderStyle = BorderStyle.Fixed3D;
                soruresim.Image = Image.FromFile(Application.StartupPath + "\\Sorular\\2019karisim.png");
                cözümGroup.Visible = true;
                cözümtxt.Visible = true;
                cözümresim.Visible = false;
                cözümtxt.Text = "";
            }
            else if (yearsCombo.Text == "2019" && topicList.Text == "Kesirli Sayılar")
            {
                soruresim.Visible = true;
                soruresim.SizeMode = PictureBoxSizeMode.StretchImage;
                soruresim.BorderStyle = BorderStyle.Fixed3D;
                soruresim.Image = Image.FromFile(Application.StartupPath + "\\Sorular\\2019kesir.png");
                cözümGroup.Visible = true;
                cözümtxt.Visible = true;
                cözümresim.Visible = false;
                cözümtxt.Text = "√9/√16 = ¾ 4 ile genişletirsek\ntüm parçanın sayısıyla" +
                    "payda sayısı eşitlenir yani 16 olur.\nGenişletilmiş hali 12/16 olur.\n" +
                    "12-9=3 eksik pembe parça sayısı olur. ";
            }
            else if (yearsCombo.Text == "2019" && topicList.Text == "Hız Problemi")
            {
                soruresim.Visible = true;
                soruresim.SizeMode = PictureBoxSizeMode.StretchImage;
                soruresim.BorderStyle = BorderStyle.Fixed3D;
                soruresim.Image = Image.FromFile(Application.StartupPath + "\\Sorular\\2019hiz.png");
                cözümGroup.Visible = true;
                cözümtxt.Visible = true;
                cözümresim.Visible = false;
                cözümtxt.Text = "x=v*t\n" +
                    "300=100*t t=3\n" +
                    "x/60-x/100=2\n" +
                    "5x-3x/300=2 x=300\n" +
                    "300/4=75";
            }
            else if (yearsCombo.Text == "2019" && topicList.Text == "Permütasyon-Kombinasyon")
            {
                soruresim.Visible = true;
                soruresim.SizeMode = PictureBoxSizeMode.StretchImage;
                soruresim.BorderStyle = BorderStyle.Fixed3D;
                soruresim.Image = Image.FromFile(Application.StartupPath + "\\Sorular\\2019perm.png");
                cözümGroup.Visible = true;
                cözümtxt.Visible = true;
                cözümresim.Visible = false;
                cözümtxt.Text = "3 T 5 N\n" +
                    "4erli S ve A\n" +
                    "(3,2)*(2,1)*(5,2)*(3,3) kombinasyonu\n" +
                    "3.2.10=60";
            }
            else if (yearsCombo.Text == "2019" && topicList.Text == "Yüzde Problemi")
            {
                soruresim.Visible = true;
                soruresim.SizeMode = PictureBoxSizeMode.StretchImage;
                soruresim.BorderStyle = BorderStyle.Fixed3D;
                soruresim.Image = Image.FromFile(Application.StartupPath + "\\Sorular\\2019yuzde.png");
                cözümGroup.Visible = true;
                cözümtxt.Visible = true;
                cözümresim.Visible = false;
                cözümtxt.Text = "Dolu kutu 30*8=240\n" +
                    "x*60/100=240 x=400\n" +
                    "400*65/100=20y\ny=13";
            }

            else if (yearsCombo.Text == "2019" && topicList.Text == "Üslü Sayılar")
            {
                soruresim.Visible = true;
                soruresim.SizeMode = PictureBoxSizeMode.StretchImage;
                soruresim.BorderStyle = BorderStyle.Fixed3D;
                soruresim.Image = Image.FromFile(Application.StartupPath + "\\Sorular\\2019us.png");
                cözümresim.SizeMode = PictureBoxSizeMode.StretchImage;
                cözümresim.BorderStyle = BorderStyle.Fixed3D;
                cözümresim.Image = Image.FromFile(Application.StartupPath + "\\Sorular\\2019uslucöz.png");
                cözümGroup.Visible = true;
                cözümtxt.Visible = true;
                cözümresim.Visible = true;
                cözümtxt.Text = "";
            }
            else if (yearsCombo.Text == "2020" && topicList.Text == "Eşitsizlikler")
            {
                soruresim.Visible = true;
                soruresim.SizeMode = PictureBoxSizeMode.StretchImage;
                soruresim.BorderStyle = BorderStyle.Fixed3D;
                soruresim.Image = Image.FromFile(Application.StartupPath + "\\Sorular\\2020esitsizlik.png");
                cözümGroup.Visible = true;
                cözümtxt.Visible = true;
                cözümresim.Visible = false;
                cözümtxt.Text = "";
            }
            else if (yearsCombo.Text == "2020" && topicList.Text == "Permütasyon-Kombinasyon")
            {
                soruresim.Visible = true;
                soruresim.SizeMode = PictureBoxSizeMode.StretchImage;
                soruresim.BorderStyle = BorderStyle.Fixed3D;
                soruresim.Image = Image.FromFile(Application.StartupPath + "\\Sorular\\2020perm.png");
                cözümGroup.Visible = true;
                cözümtxt.Visible = true;
                cözümresim.Visible = false;
                cözümtxt.Text = "A=1,2 B=3,4 C=5,6\n" +
                    "1/4*2/2=8";
            }
            else if (yearsCombo.Text == "2020" && topicList.Text == "Sayı Problemi")
            {
                soruresim.Visible = true;
                soruresim.SizeMode = PictureBoxSizeMode.StretchImage;
                soruresim.BorderStyle = BorderStyle.Fixed3D;
                soruresim.Image = Image.FromFile(Application.StartupPath + "\\Sorular\\2020sayiprob.png");
                cözümGroup.Visible = true;
                cözümtxt.Visible = true;
                cözümresim.Visible = false;
                cözümtxt.Text = "A=24x B=12x C=8x D=6x\n" +
                    "Toplam 50x ";
            }
            else if (yearsCombo.Text == "2020" && topicList.Text == "Yaş Problemi")
            {
                soruresim.Visible = true;
                soruresim.SizeMode = PictureBoxSizeMode.StretchImage;
                soruresim.BorderStyle = BorderStyle.Fixed3D;
                soruresim.Image = Image.FromFile(Application.StartupPath + "\\Sorular\\2020yas.png");
                cözümGroup.Visible = true;
                cözümtxt.Visible = true;
                cözümresim.Visible = false;
                cözümtxt.Text = "X=Yaşlar Toplamı\n" +
                    "Y=Kişi Sayısı\n" +
                    "(X-1)/(Y-1)=45\n" +
                    "(X-1)/(Y-1)=38\n" +
                    "45Y-44=38Y+54\n" +
                    "Y=14";
            }
            else if (yearsCombo.Text == "2020" && topicList.Text == "Oran Orantı")
            {
                soruresim.Visible = true;
                soruresim.SizeMode = PictureBoxSizeMode.StretchImage;
                soruresim.BorderStyle = BorderStyle.Fixed3D;
                soruresim.Image = Image.FromFile(Application.StartupPath + "\\Sorular\\2020oran.png");
                cözümGroup.Visible = true;
                cözümtxt.Visible = true;
                cözümresim.Visible = false;
                cözümtxt.Text = "78/13=6 k=6\n" +
                    "A=18 B=24 C=36\n" +
                    "3.madde hesaplandığında 36.";
            }
            else if (yearsCombo.Text == "2020" && topicList.Text == "Üslü Sayılar")
            {
                soruresim.Visible = true;
                soruresim.SizeMode = PictureBoxSizeMode.StretchImage;
                soruresim.BorderStyle = BorderStyle.Fixed3D;
                soruresim.Image = Image.FromFile(Application.StartupPath + "\\Sorular\\2020us.png");
                cözümGroup.Visible = true;
                cözümtxt.Visible = true;
                cözümresim.Visible = false;
                cözümtxt.Text = "81*16*35+81*16\n" +
                    "=81*16*36 = 6^6";
            }
            else if (yearsCombo.Text == "2021" && topicList.Text == "Sayı Problemi")
            {
                soruresim.Visible = true;
                soruresim.SizeMode = PictureBoxSizeMode.StretchImage;
                soruresim.BorderStyle = BorderStyle.Fixed3D;
                soruresim.Image = Image.FromFile(Application.StartupPath + "\\Sorular\\2021sayi.png");
                cözümGroup.Visible = true;
                cözümtxt.Visible = true;
                cözümresim.Visible = false;
                cözümtxt.Text = "Ürünün birim fiyatıyla alınan adet\n" +
                    "sayısı çarpımı yapıldıktan sonra\n" +
                    "üç ürünün toplamı verilen para\n" +
                    "miktarından çıkarılır.\n" +
                    "(5*0,99)+(1,10*1)+(1,25*3)=9,8\n" +
                    "10-9,8=0,2";
            }
            else if (yearsCombo.Text == "2021" && topicList.Text == "Yaş Problemi")
            {
                soruresim.Visible = true;
                soruresim.SizeMode = PictureBoxSizeMode.StretchImage;
                soruresim.BorderStyle = BorderStyle.Fixed3D;
                soruresim.Image = Image.FromFile(Application.StartupPath + "\\Sorular\\2021yas.png");
                cözümGroup.Visible = true;
                cözümtxt.Visible = true;
                cözümresim.Visible = false;
                cözümtxt.Text = "39x = 2020-(300+x)\n" +
                    "40x=1720\n" +
                    "x=43";
            }
            else if (yearsCombo.Text == "2021" && topicList.Text == "Köklü Sayılar")
            {
                soruresim.Visible = true;
                soruresim.SizeMode = PictureBoxSizeMode.StretchImage;
                soruresim.BorderStyle = BorderStyle.Fixed3D;
                soruresim.Image = Image.FromFile(Application.StartupPath + "\\Sorular\\2021kok.png");
                cözümGroup.Visible = true;
                cözümtxt.Visible = true;
                cözümresim.Visible = false;
                cözümtxt.Text = "(√10+√6 )(√10-√6) = 10-6 =4\n" +
                    "( (√10+√6 ) / (√10-√6 ) ) * (√10+√6 )\n" +
                    "Pay ve payda (√10+√6 ) ile çarpılır.\n" +
                    "√15 + 4 - 4 = √15 ";
            }
            else if (yearsCombo.Text == "2021" && topicList.Text == "Oran Orantı")
            {
                soruresim.Visible = true;
                soruresim.SizeMode = PictureBoxSizeMode.StretchImage;
                soruresim.BorderStyle = BorderStyle.Fixed3D;
                soruresim.Image = Image.FromFile(Application.StartupPath + "\\Sorular\\2021oran.png");
                cözümGroup.Visible = true;
                cözümtxt.Visible = true;
                cözümresim.Visible = false;
                cözümtxt.Text = "";
            }
            else if (yearsCombo.Text == "2021" && topicList.Text == "Üslü Sayılar")
            {
                soruresim.Visible = true;
                soruresim.SizeMode = PictureBoxSizeMode.StretchImage;
                soruresim.BorderStyle = BorderStyle.Fixed3D;
                soruresim.Image = Image.FromFile(Application.StartupPath + "\\Sorular\\2021us.png");
                cözümGroup.Visible = true;
                cözümtxt.Visible = true;
                cözümresim.Visible = false;
                cözümtxt.Text = "";
            }
        }

        private void devamlabel_Click(object sender, EventArgs e)
        {
            if (topicList.Text == "Polinom")
            {
                devamlabel.Visible = false;
                label3.Visible = true;
                label3.Text = "P(x):Bölünen, Q(x):Bölen, B(x):Bölüm, K(x):Kalan\n" +
                    "1.der [ P(x) ] ≥ der [ Q(x)]\n" +
                    "2.der [K(x) ] < der [ Q(x) ]\n" +
                    "3.P(x) = Q(x) . B(x) + K(x)\n" +
                    "4.der [ K(x) ] < der [B (x) ] ise Q (x ) ile B(x) in yer\n" +
                    "değiştirmesi kalanı değiştirmez.\n" +
                    "5.K (x) = 0 ise P(x) polinomu Q(x) polinomuna tam\n" +
                    "olarak bölünür." +
                    "Bu durumda P(x) in çarpanlarından biri\nQ(x) polinomudur.";
            }
            else if(topicList.Text == "Permütasyon-Kombinasyon")
            {
                devamlabel.Visible = false;
                label3.Visible = true;
                label3.Text = "- n elemanlı bir kümeden seçilen r elemanlı\n" +
                    "kombinasyonların toplamı (n ≥ r olmak şartıyla) aşağıdaki\n" +
                    "formülle ifade edilir:\n" +
                    "C(n,r) = P(n,r) / r! = n! / r!(n-r)!";
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Simülasyon sim = new Simülasyon();
            sim.Show();
            this.Hide();
        }
    }
}
