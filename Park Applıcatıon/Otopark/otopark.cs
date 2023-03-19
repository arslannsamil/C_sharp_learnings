using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Otopark
{
    class otopark
    {
        int toplamarackapasitesi;
        int bosaracsayisi;
        double bakiye;
        string otoparkadi;

        const double standartarac = 20;
        const double buyukarac = 30;

        public otopark(string p_otoparkadi,int p_kapasite)
        {
            toplamarackapasitesi = p_kapasite;
            bosaracsayisi = p_kapasite;
            bakiye = 0;
            otoparkadi = p_otoparkadi;
        }
        public void biletsat(bool aracstandartmi)
        {
            bosaracsayisi--;
            if (aracstandartmi)
            {
                bakiye += standartarac;
            }
            else
            {
                bakiye += buyukarac;
            }
        }
        public void biletiade(bool aracstandartaracmi)
        {
            bosaracsayisi++;
            if (aracstandartaracmi)
            {
                bakiye -= standartarac;
            }
            else
            {
                bakiye -= buyukarac;
            }
        }
        public int bosyersayisiogren()
        {
            return bosaracsayisi;
        }
        public double bakiyeogren()
        {
            return bakiye; 
        }

    }
}
