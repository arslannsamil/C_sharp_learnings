using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class4
{
    class Program
    {
        static void Main(string[] args)
        {
            Ucak uck = new Ucak();
            uck.MARKA = "turk hava yolları";
            uck.KALKIS = "berlın";
            uck.VARIS = "ıstanbul";
            uck.ADI = "ahmet samıl ";
            uck.SOYADI = "arslan";
            uck.YASI = 21;
            uck.CINSIYETI = "erkek";

            Console.WriteLine("hava yolu: " + uck.MARKA);
            Console.WriteLine("kalkıs noktası: " + uck.KALKIS);
            Console.WriteLine("varıs noktası: " + uck.VARIS);
            Console.WriteLine("adı: " + uck.ADI);
            Console.WriteLine("soyadı: " + uck.SOYADI);
            Console.WriteLine("yolcu yası: " + uck.YASI);
            Console.WriteLine("cınsıyetı: " + uck.CINSIYETI);
            Console.ReadLine();


        }
    }
}
