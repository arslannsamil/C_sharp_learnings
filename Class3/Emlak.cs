using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class3
{
    class Emlak
    {
        private string semt;
        private string renk;
        private int oda_sayı;
        private int kat_no;
        private double alan;

        public string SEMTI
        {
            get { return semt; }
            set { semt = value.ToUpper(); } // Value.toupper yaparak ılgılı degerı buyuk harfe cevır.
        }
        public string RENGI
        {
            get { return renk; }
            set { renk = value.ToLower(); } // .tolower yaparak ılgılı degerı bu sefer kucuk harf ıle tanımladık.
        }
        public int ODA_SAYISI
        {
            get { return oda_sayı; }
            set { oda_sayı = Math.Abs(value); } // Bu sekılde math.abs(value) demek gırılen degerın mutlagını al demek.
        }
        public int KAT_NO
        {
            get { return kat_no; }
            set { kat_no = Math.Abs(value); }
        }
        public double ALANI
        {
            get { return alan; }
            set { alan = Math.Abs(value); }
        }
    }
}
