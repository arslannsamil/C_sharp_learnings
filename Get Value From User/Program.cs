using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KULLANICIDAN_DEGER_ALMA
{
    class Program
    {
        static void Main(string[] args)
        
        {
            //Readline fonksiyonu kullanicidan degerler almamizi saglar.

            Console.WriteLine("lutfen adinizi giriniz");

            string isim = Console.ReadLine();

            Console.WriteLine("soyadinizi giriniz");

            string soyad = Console.ReadLine();
            //Kullanicinin girmis oldugu soyad Console.Readline kisimina gelecek ve orayi dolduracak

            Console.WriteLine("Kullanicinin Ismi:" + isim);
            Console.WriteLine("Kullanicinin soyadi:" + soyad);

            Console.ReadLine();
        }
    }
}
