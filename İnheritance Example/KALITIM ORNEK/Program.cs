using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KALITIM_ORNEK
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("hangı tıp ev gırısı");
            string tıp = Console.ReadLine();
            if (tıp.Equals("satılık"))
            {
                satılıkdaıre satılık = new satılıkdaıre();
                satılık.ıl = "ankara";
                satılık.ılce = "cankaya";
                satılık.odasayısı = 4;
                satılık.metrekare = 250;
                satılık.ısınmasıstemı = "merkezı";
                satılık.satısfıyatı = 1000000;
                satılık.ozellıkgoster();
                satılık.satılıkozellık();
            }
            else if (tıp.Equals("kıralık"))
            {
                kıralık_daıre kıra = new kıralık_daıre();
                kıra.ıl = "kırıkkale";
                kıra.ılce = "merkez";
                kıra.ısınmasıstemı = "merkezı";
                kıra.odasayısı = 5;
                kıra.esyalımı = false;
                kıra.kırabedelı = 1500;
                kıra.ozellıkgoster();
                kıra.kıralıkozellıkler();
            }
            else
            {
                Console.WriteLine("hatalı tuslama yaptınız");    
            }
            Console.ReadLine();
        }
    }
}
