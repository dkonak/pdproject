using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathProf
{
    public class Kume
    {
        private int[] intKume; // integer kümesi

        public Kume()
        {
            // COnstructor, intKume = null;
        }

        public int this[int pozisyon]
        {
            get
            {
                return intKume[pozisyon];
            }
        }
        public Kume(int[] parDizi)
        {
            // Constructor, dizi parametre veriliyor, küme oluşturuluyor.
            for (int i = 0; i < parDizi.Length; i++)
                Ekle(parDizi[i]);
        }

        public bool Ekle(int eleman)
        {
            // Kümeye eleman ekliyor. önceden varsa eklemez.
            int adet = 0;
            if (intKume != null)
                adet = intKume.Length;

            if (!VarMi(eleman))
            {
                int[] yeniKume = new int[adet + 1];
                for (int i = 0; i < adet; i++)
                    yeniKume[i] = intKume[i];
                yeniKume[adet] = eleman;
                adet++;
                intKume = yeniKume;
                return true;
            }
            return false;
        }

        bool VarMi(int eleman)
        {
            // verilen eleman kümede var mı?
            int adet = 0;
            if (intKume != null)
                adet = intKume.Length;

            for (int i = 0; i < adet; i++)
                if (intKume[i] == eleman)
                    return true;
            return false;
        }

        public bool BosKumeMi()
        {
            return ElemanSayisi == 0;
        }

        public int ElemanSayisi
        {
            get
            {
                // Kümenin eleman sayısı
                int adet = 0;
                if (intKume != null)
                    adet = intKume.Length;

                return adet;
            }
        }

        public override string ToString()
        {
            // Küme ekrana yazdırılıyor.
            string s = "";
            int adet = 0;
            if (intKume != null)
                adet = intKume.Length;
            s += "{";
            for (int i = 0; i < adet; i++)
            {
                s += intKume[i];
                if (i < adet - 1)
                    s += ", ";
            }
            s += "}";
            return s;
        }

        public void Sirala()
        {
            // Küme küçükten büyüğe sıralanıyor.
            // Düzgün ekran çıktıları için kullanıldı.
            int adet = ElemanSayisi;

            for (int i = 0; i < adet - 1; i++)
                for (int j = i + 1; j < adet; j++)
                    if (intKume[i] > intKume[j])
                    {
                        int temp = intKume[i];
                        intKume[i] = intKume[j];
                        intKume[j] = temp;
                    }
        }
        static bool DenkMi(Kume kume1, Kume kume2)
        {
            return kume1.ElemanSayisi == kume2.ElemanSayisi;
        }
        static bool EsitMi(Kume kume1, Kume kume2)
        {
            if (kume1.ElemanSayisi == 0 && kume2.ElemanSayisi == 0) return true;
            if (kume1.ElemanSayisi == 0 || kume2.ElemanSayisi == 0) return false;
            // verilen küme ile kendisini karşılaştırıyor.
            int adet1 = kume1.ElemanSayisi;
            int adet2 = kume2.ElemanSayisi;

            if (adet1 != adet2) return false;

            for (int i = 0; i < adet2; i++)
                if (!kume1.VarMi(kume2[i]))
                    return false;
            return true;
        }

        public static Kume operator +(Kume kume1, Kume kume2)
        {
            return kume1 | kume2;
        }

        public static Kume operator |(Kume kume1, Kume kume2)
        {
            return kume1.Birlestir(kume2);
        }

        public static Kume operator &(Kume kume1, Kume kume2)
        {
            return kume1.Kesisim(kume2);
        }

        public static Kume operator /(Kume kume1, Kume kume2)
        {
            Kume yeniKume = new Kume();
            for (int i = 0; i < kume1.ElemanSayisi; i++)
            {
                if (!kume2.VarMi(kume1[i]))
                    yeniKume.Ekle(kume1[i]);
            }
            return yeniKume;
        }
        public static bool operator >=(Kume kume1, Kume kume2)
        {
            return Kume.DenkMi(kume1, kume2);
        }
        public static bool operator <=(Kume kume1, Kume kume2)
        {
            return Kume.DenkMi(kume1, kume2);
        }
        public static bool operator ==(Kume kume1, Kume kume2)
        {
            return Kume.EsitMi(kume1, kume2);
        }
        public static bool operator !=(Kume kume1, Kume kume2)
        {
            return !Kume.EsitMi(kume1, kume2);
        }
        public static bool operator >>(Kume kume1, int eleman)
        {
            return kume1.VarMi(eleman);
        }
        public override bool Equals(object obj)
        {
            return base.Equals(obj);
        }
        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
        Kume Birlestir(Kume kume2)
        {
            // verilen küme ile kendisini birleştirip
            // yeni bir küme elde ediliyor.
            Kume yeniKume = new Kume();

            int adet1 = ElemanSayisi;

            int adet2 = kume2.ElemanSayisi;

            for (int i = 0; i < adet1; i++)
                yeniKume.Ekle(this[i]);

            for (int i = 0; i < adet2; i++)
                if (!VarMi(kume2[i]))
                    yeniKume.Ekle(kume2[i]);

            return yeniKume;
        }

        Kume Kesisim(Kume kume2)
        {
            // Verilen küme ile kendisinden
            // Kesişim kümesi elde ediliyor.
            Kume yeniKume = new Kume();

            int adet1 = ElemanSayisi;

            int adet2 = kume2.ElemanSayisi;

            for (int i = 0; i < adet2; i++)
                if (VarMi(kume2[i]))
                    yeniKume.Ekle(kume2[i]);
            return yeniKume;
        }

        public Kume[] AltKumeler()
        {
            // Alt kümelerden bir küme dizisi üretiyor.
            int n = this.ElemanSayisi;
            int altKumeSayisi = (int)Math.Pow(2, n);
            Kume[] temp = new Kume[altKumeSayisi];

            for (int i = 0; i < altKumeSayisi; i++)
            {
                temp[i] = new Kume();
                for (int j = 0; j < n; j++)
                {
                    if ((i & (int)Math.Pow(2, j)) > 0)
                    {
                        temp[i].Ekle(this[j]);
                    }
                }
            }
            return temp;
        }

        public static void AltKumeleriYaz(Kume[] altkume)
        {
            // Static method
            // verilen küme dizisini ekrana yazar.
            for (int i = 0; i < altkume.Length; i++)
            {
                bool ilkdefa = true;
                Console.Write("{");
                for (int j = 0; j < altkume[i].ElemanSayisi; j++)
                {
                    if (!ilkdefa)
                        Console.Write(", ");
                    Console.Write(altkume[i][j]);
                    ilkdefa = false;
                }
                Console.WriteLine("}");
            }

        }
    }
}
