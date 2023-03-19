using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kutu_operator_overloading
{
    class kutu
    {
        private double yukseklık;
        private double genıslık;
        private double uzunluk;
        
        public void yukseklık_ayarla(double _yukseklık)
        {
            yukseklık = _yukseklık;
        }
        public void genıslık_ayarla(double _genıslık)
        {

            genıslık = _genıslık;
        }
        public void uzunluk_hesapla(double _uzunluk)
        {
            uzunluk = _uzunluk;
        }
        public double hacım_hesapla()
        {
            return yukseklık * genıslık * uzunluk;
        }
        public static kutu operator+(kutu a, kutu b)
        {
            kutu k = new kutu();
            k.uzunluk = a.uzunluk + b.uzunluk;
            k.genıslık = a.genıslık + b.genıslık;
            k.yukseklık = a.yukseklık + b.yukseklık;
            return k;

        }
    }
}
