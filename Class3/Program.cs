using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class3
{
    class Program
    {
        static void Main(string[] args)
        {
            Emlak eml = new Emlak();

            eml.SEMTI = "cankaya";
            eml.RENGI = "mavı";
            eml.ODA_SAYISI = 4;
            eml.KAT_NO = 8;
            eml.ALANI = 80;

            Console.WriteLine("evın bululndgu semt:"+eml.SEMTI);
            Console.WriteLine("evın oda renklerı:"+eml.RENGI);
            Console.WriteLine("evın toplma oda sayısı:"+eml.ODA_SAYISI);
            Console.WriteLine("evın buundugu kat:"+eml.KAT_NO);
            Console.WriteLine("evın toplma alanı:"+eml.ALANI+" metrekare");

            Console.ReadLine();
        }
    }
}
