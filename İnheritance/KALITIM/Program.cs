using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KALITIM
{
    class Program
    {
        static void Main(string[] args)
        {
            ınsan insan1 = new ınsan();
            insan1.ad = "ahmet";
            insan1.soyad = "test";

            personal per1 = new personal();

            per1.ad = "ahmet";
            per1.soyad = "test";
            per1.maas = 11000;
            per1.sıcılno = "B-1111";
            per1.unvan = "muhendıs";

        }
    }
}
