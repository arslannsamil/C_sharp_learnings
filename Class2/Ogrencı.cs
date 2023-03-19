using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class2
{
    class Ogrencı
    {
        private string ad;
        private string soyad;
        private int yas; //yas'ın en kucuk 18 olmasını ıstedık.
        private string alan;

        // Asagıda yaptıgımız satır ıslemlerı sayesınde alamadıgımız prıvate degerlerı get set ederek kullandık.
        
        public string ADI
        {
            get { return ad; }
            set { ad = value; } // klavyeden gırılen (value) degerını yanı ad degerını set ıle ıslem yapıp (aktarıp) get ıle okuma ıslmeı yaptık
        }
        public string SOYADI
        {
            get { return soyad; }
            set { soyad = value; }
        }
        public string ALANI
        {
            get { return alan; }
            set { alan = value; }
        }
        public int YASI //gırılen yas 18'den kucuk olursa 18 degerını degıl ıse gırılen degerı ekranda gosterıcek.
        {
            get { return yas; }
            set
            {
                if (value<18)
                {
                    yas = 18;
                }
                else
                {
                    yas = value;
                }
            }
        }

    }
}
