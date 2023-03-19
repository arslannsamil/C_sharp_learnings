using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class4
{
    class Yolcu
    {
        private string ad;
        private string soyad;
        private int yas;
        private string cınsıyet;

        public string ADI
        {
            get { return ad; }
            set { ad = value.ToUpper(); }
        }
        public string SOYADI
        {
            get { return soyad; }
            set { soyad = value.ToUpper(); }
        }
        public int YASI
        {
            get { return yas; }
            set { yas =Math.Abs(value); }
        }
        public string CINSIYETI
        {
            get { return cınsıyet; }
            set { cınsıyet = value.ToUpper(); }
        }
    }
}
