using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace box_operator_overloadıng
{
    class kutu
    {
        double yukseklık;
        double uzunluk;
        double genıslık;

        public void yukseklıkayarla(double _yukseklık) 
        {
            yukseklık = _yukseklık;
        }
        public void genıslıklıkayarla(double _genıslık)
        {
            genıslık = _genıslık;
        }
        public void uzunlukayarla(double _uzunluk)
        {
            uzunluk = _uzunluk;
        }
        public double hacımhesapla()
        {
            return yukseklık * uzunluk * genıslık;
        } 

        public static kutu operator+(kutu a,kutu b)
        {
            kutu gecıcıkutu = new kutu();
            gecıcıkutu.yukseklık = a.yukseklık + b.yukseklık;
            gecıcıkutu.genıslık = a.genıslık+ b.genıslık;
            gecıcıkutu.uzunluk = a.uzunluk + b.uzunluk;
            return gecıcıkutu;
        }

        public override string ToString()
        {
            return string.Format("{0} {1} {2} ",uzunluk,yukseklık,genıslık);
        }

        public static bool operator==(kutu a,kutu b)
        {
            bool karar = false;
            if (a.yukseklık == b.yukseklık && a.genıslık == b.genıslık && a.uzunluk == b.uzunluk)
            {
                 karar = true;
            }
            return karar;
        }
        public static bool operator !=(kutu a, kutu b)
        {
            bool karar = false;
            if (a.yukseklık != b.yukseklık && a.genıslık != b.genıslık && a.uzunluk != b.uzunluk)
            {
                karar = true;
            }
            return karar;
        }

    }
}
