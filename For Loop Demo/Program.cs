using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace For_Dongusu_Ornek
{
    class Program
    {
        static void Main(string[] args)
        {

            /*Kullanicidan bir sayi alacagiz 0`dan baslayip aldigimiz sayiya kadar toplayacagiz ve girdigi sayiyi bolecegiz 
             * eger ortalama 50`den buykse ortalamak 50`den buyuktur degilse ortalama 50`den kucuktur yazdirsin.*/

            //Console.WriteLine("lutfen bir sayi giriniz");
            //int sayi = Convert.ToInt32(Console.ReadLine());
            //int toplam = 0;


            //for (int i = 0; i <= sayi; i++)
            //{
            //    toplam += i; //toplam=toplam+i
            //}
            //double ortalama = toplam / sayi;

            //if (ortalama>50)
            //{
            //    Console.WriteLine("ortalama 50`den buyuktur");
            //}
            //else if (ortalama==50)
            //{
            //    Console.WriteLine("ortalama 50`dir");
            //    Console.ReadLine();
            //}
            //else
            //{
            //    Console.WriteLine("ortalama 50`den kucuktur");
            //    Console.ReadLine();
            //}







            //klavyeden girilen sayinin faktoriyelini bulan programi yap


            //Console.WriteLine("lutfen bi sayi giriniz");

            //int a = Convert.ToInt32(Console.ReadLine());
            //int sonuc = 1;

            //for (int i = a; i > 1; i--)
            //{
            //    sonuc = sonuc * i;
            //}
            //Console.WriteLine("faktoriyel:" + sonuc);
            //Console.ReadLine();

            /* 0!=1 oldugu icin biz sayimizi 0 girdigimiz zaman for dongusune hic girmez ve sonuc degerini alir 
            sonuc degerini de 1 tanimladigimiz icin hicbir sikinti olmaz*/





            // Girilen sayinin asal olup olmadigini bulan program kodunu yaziniz.


            //Console.WriteLine("lutfen bir pozitif sayi giriniz.");

            //int asal = Convert.ToInt32(Console.ReadLine());

            //for (int i = 2; i < asal; i++)
            //i=2 dememizin nedeni 0`dan baslatsak tanimsiz 1`den baslatsak butun sayilar zaten bolunuyor o yuzden 2`den baslattik , < asal yapmamizin nedeni ise
            //butun sayilar kendine zaten bolunur ondan girilen sayiyi da bolme islmine dahil etmiyoruz
            //{
            //    if (asal % i == 0)
            //    {
            //        Console.WriteLine("girdiginiz sayi asal degildir");
            //        break;
            //    }
            //    else 
            //    {
            //        Console.WriteLine("girdiginiz sayi asaldir");
            //        break;

            //    }
            //}
            //Console.ReadLine();







            //girilen sayinin asal olup olmadigini soyleyen ve renkli bir sekilde ifade eden program kodu

            //Console.WriteLine("lutfen bir pozitif sayi giriniz.");

            //int asal = Convert.ToInt32(Console.ReadLine());

            //bool durum = true;

            //for (int i = 2; i < asal; i++)
            //{
            //    if (asal % i == 0)
            //    {
            //        durum = false;
            //    }
            //}

            //if (durum)
            //{
            //    Console.ForegroundColor = ConsoleColor.Green;
            //    Console.WriteLine("Girmis oldugunuz sayi bir asal sayidir");
            //    Console.ResetColor();
            //}
            //else
            //{
            //    Console.ForegroundColor = ConsoleColor.Red;
            //    Console.WriteLine("Girmis oldugunuz sayi bir asal sayi degildir");
            //    Console.ResetColor();
            //}

            //Console.ReadLine();






            // boyut buyuklugu kullanicidan alinan Yildizlarla baklava dilimi yapan kodu yaziniz.


            Console.WriteLine("baklava dilimi");

            Console.WriteLine("boyut degeri giriniz");

            int boyut = Convert.ToInt32(Console.ReadLine());

            for (int i = 1; i <= boyut; i++)
            {
                for (int k = boyut; k >= i; k--)
                {
                    Console.Write(" ");
                }
                for (int j = 0; j < i; j++)
                {
                    Console.Write("* ");
                }
                Console.WriteLine();
            }

            for (int i = boyut; i >=1; i--)
            {
                for (int k = (boyut-1); k >= i; k--)
                {
                    Console.Write(" ");
                }
                for (int j = 0; j < i; j++)
                {
                    Console.Write(" *");
                }
                Console.WriteLine();
            }
            Console.ReadLine();






        }
    }
}
