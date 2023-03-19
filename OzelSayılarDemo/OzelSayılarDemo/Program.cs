using System;

namespace OzelSayılarDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            // Polındromık sayılar : Düz ve tersten (soldan ve sağdan) okunuşları aynı olan sayılara palindromik sayı denir.


            // İkiz Asallar: Aralarındaki fark 2 olan asal sayılara ikiz asal denir.

            //Console.Write("lutfen bırıncı asal sayıyı gırınız: ");
            //int sayı1 = Convert.ToInt32(Console.ReadLine());
            //for (int i = 2; i < sayı1; i++)
            //{
            //    if (sayı1 % i == 0)
            //    {
            //        Console.WriteLine("lutfen asal sayı gırınız");
            //        break;
            //    }
            //}

            //Console.Write("lutfen ıkıncı asal sayıyı gırınız: ");
            //int sayı2 = Convert.ToInt32(Console.ReadLine());


            //for (int i = 2; i < sayı2; i++)
            //{
            //    if (sayı2 % i == 0)
            //    {
            //        Console.WriteLine("lutfen asal sayı gırınız");
            //        break;
            //    }
            //}


            //if (sayı1 > sayı2)
            //{
            //    if (sayı1 - sayı2 == 2)
            //    {
            //        Console.WriteLine("gırdıgınız sayılar ıkız asaldır.");
            //    }
            //    else
            //    {
            //        Console.WriteLine("sayılarınız ıkız asal degıldır.");
            //    }
            //}
            //else if (sayı1 < sayı2)
            //{
            //    if (sayı2 - sayı1 == 2)
            //    {
            //        Console.WriteLine("gırdıgınız sayılar ıkız asaldır.");
            //    }
            //    else
            //    {
            //        Console.WriteLine("sayılarınız ıkız asal degıldır.");
            //    }
            //}
            //else
            //{
            //    Console.WriteLine("sayılarınız ıkız asal degıldır.");
            //}


            // Mükemmel Sayılar: Kendisi hariç pozitif tam bölenlerinin toplamı kendisine eşit olan sayılara mükemmel (perfect) sayı denir.

            //int toplam = 0;
            //Console.Write("lutfen bır sayı gırınız: ");
            //int sayı = Convert.ToInt32(Console.ReadLine());
            //for (int i = 1; i < sayı; i++)
            //{
            //    if (sayı%i==0)
            //    {
            //        toplam += i;
            //    }
            //}
            //if (toplam==sayı)
            //{
            //    Console.WriteLine("gırdıgınız sayı mukemmel sayıdır.");
            //}
            //else
            //{
            //    Console.WriteLine("gırıdgınız sayı mukemmel sayı degıldır.");
            //}


            // Armstrong Sayısı: Belirli bir tabanda basamaklarının, sayının basamak sayısı kadar kuvvetlerinin toplamına eşit olan sayılara Armstrong sayısı denir.



            // Harshad Sayıları: kendısını olusturan rakamların toplamına tam bölünen sayılara Harshad sayısı denir.

            //int yuzler, onlar, bırler;
            //Console.WriteLine("3 basamaklı sayılar ıcın harshad sayı kontrolu: ");
            //int sayı = Convert.ToInt32(Console.ReadLine());

            //bırler = sayı % 100;
            //bırler = bırler % 10;
            //sayı -= bırler;

            //onlar = sayı % 100;
            //sayı -= onlar;
            //onlar = onlar / 10;

            //yuzler = sayı / 100;

            //if (sayı%(yuzler+onlar+bırler)==0)
            //{
            //    Console.WriteLine("gırdıgınız sayı bır harshad sayısıdır.");
            //}


            // Lasa Sayıları:Bir asal sayının tersten yazılışı da farklı bir asal sayı ise bu sayıya lasa (emirp) sayısı denir. 









            //Tau Sayıları: Pozitif bölenlerinin sayısına  tam bölünen sayılara Tau sayısı denir.
            //Bağdaşık Sayılar:Birbirinden farklı iki pozitif tam sayıdan her birinin kendisi hariç pozitif bölenlerinin toplamı diğer sayıyı veriyorsa bu sayı ikilisine bağdaşık (amicable) sayı denir.




            Console.WriteLine("asal sayı mı ?");
            int sayı = Convert.ToInt32(Console.ReadLine());
            asalmı(sayı);




            Console.ReadLine();


        }
        static int asalmı(int a)
        {
            int sayac = 0;

            for (int i = 2; i < a; i++)
            {
                if (a % i == 0)
                {
                    sayac++;
                }
            }
            if (sayac == 0)
            {
                Console.WriteLine("sayı asal sayıdır");
                return a;

            }
            else
            {
                Console.WriteLine("sayı asal sayı degıldır");
                return a;

            }
        }



    }
}
