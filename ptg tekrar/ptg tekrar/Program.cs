using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ptg_tekrar
{
    internal class Program
    {
        static void Main(string[] args)
        {

            #region girilen sayının tersi
            //Console.WriteLine("bir sayı girin");
            //int a = Convert.ToInt32(Console.ReadLine());

            //int toplam = 0, mod = 0;

            //while (a!=0)
            //{
            //    mod = a % 10;
            //    toplam = toplam * 10 + mod;
            //    a=a/10;


            //}
            //Console.WriteLine(toplam);
            #endregion

            #region asal sayımı kontrol etme
            //int sayac = 0;
            //Console.WriteLine("Sayıyı Girin");
            //int sayi = Convert.ToInt32(Console.ReadLine());
            //for (int i = 1; i < sayi; i++)
            //{
            //    if (sayi % i == 0)
            //    {
            //        sayac++;
            //    }
            //}
            //if (sayac == 1)
            //{
            //    Console.WriteLine("Asal Sayıdır.");
            //}
            //else
            //{
            //    Console.WriteLine("Asal Sayı Değildir.");
            //}
            #endregion

            #region mükemmel sayılar (tam bölenlerinin toplamı kendisine eşit sayılar)

            //int toplam = 0;
            //Console.WriteLine("Sayıyı Girin");
            //int sayi = Convert.ToInt32(Console.ReadLine());

            //for (int i = 1; i < sayi; i++)
            //{
            //    if (sayi%i==0)
            //    {
            //        toplam = toplam + i;
            //    }

            //}
            //if (toplam==sayi)
            //{
            //    Console.WriteLine("mükemmel sayı");
            //}
            //else
            //{
            //    Console.WriteLine("mükemmel sayı değil");
            //}
            #endregion

            #region armstrong sayısı

            //Console.WriteLine("Sayıyı Girin");
            //int sayi = Convert.ToInt32(Console.ReadLine());
            //int basamak = 0,toplam =0,mod=0, geçici=1,a=sayi;
            //while (sayi!=0)   // basamak sayısını bulmak için 
            //{
            //    basamak ++;
            //    sayi = sayi / 10;
            //}
            //for (int i = 0; i < basamak; i++)
            //{
            //    mod = a % 10; 
            //    for (int j = 0; j < basamak; j++)
            //    {
            //        geçici *= mod; // üs almak için 

            //    }
            //    toplam = toplam + geçici;
            //    a = a / 10;   
            //    geçici = 1;
            //}
            //if (a==toplam)
            //{
            //    Console.WriteLine("armstrong sayısı");
            //}
            //else
            //{
            //    Console.WriteLine("armstrong sayısı değil");
            //}
            #endregion

            #region harshad sayısı
            //Console.WriteLine("Sayıyı Girin");
            //int sayi = Convert.ToInt32(Console.ReadLine());
            //int toplam = 0, mod = 0,
            //    geçici=sayi;
            //while (sayi!=0)
            //{
            //    mod = sayi % 10;
            //    toplam = mod + toplam;
            //    sayi =sayi / 10;
            //}
            //if (geçici%toplam==0)
            //{
            //    Console.WriteLine("harshad sayısı");
            //}
            //else
            //{
            //    Console.WriteLine("harshad sayısı değil");
            //}
            #endregion

            #region tau sayısı
            //Console.WriteLine("Sayıyı Girin");
            //int sayi = Convert.ToInt32(Console.ReadLine());
            //int sayaç = 0;

            //for (int i = 1; i <= sayi; i++)
            //{
            //    if (sayi%i==0)
            //    {
            //        sayaç++;
            //    }
            //}
            //if (sayi%sayaç==0)
            //{
            //    Console.WriteLine("tau sayısı");
            //}
            //else
            //{
            //    Console.WriteLine("tau sayısı değil");
            //}
            #endregion
            Console.ReadKey();

        }
    }
}
