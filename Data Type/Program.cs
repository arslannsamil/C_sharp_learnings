using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VERI_TIPLERI
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Byte = tam sayi tanimlamak icin kullanilir. 1 byte yer kaplar.(0-255)
            *short = tam sayi tanimlamak icin kullnilir. 2 byte yer kplar.(-32k-32k)
            *int = tam sayi tanimlamak icin kullnilir. 4 byte yer kaplar.(-2B-2B) TC KIMLIK NUMARASI ALAMASSINIZ INTEGER 10 HANEYE KADAR DESTEKLER
            *long = tam sayi tanimlamak icin kullanilir . 8 byte yer kaplar. 19 HANEYE KADAR DESTEKLER TC ICIN KULLANILABILIR
            *float = ondalik sayi tanimlamak icin kullanilir. 2 byte yer kaplar. 7 basamaga kadar ondalili sayi tanimlar
            *double = ondalik sayi tanimlamak icin kullanilir. 4 byte yer kaplar. 15 basamakli ondalilli sayilari tanimlar
            *boolean = 2 alternatifin oldugu veri tipidir.2 byte yer kaplar.
            *char = sadece tek karakter degerleri atamak istersek kullanilan veri tipidir.
            *string = metin degerlerini tutabilmek icin kullanilan veri tipidir.
            */


            /* 8 bit = 1 byte
             * 1024 byte = 1 kilobyte
             * 1024 kilobyte = 1 megabyte
             * 1024 megabyte = 1 gigabyte
             * 1024 gigabyte = 1 terabyte
             * 1024 terabyte = 1 perobyte             
             */



            //integer tanimlanirken yapilan hatalar
            //rakamla baslayamaz int 1sayi=5;
            //bosluk olmaz
            //int sayi degeri=5;
            //ve turkce karakter kullanilmamamlidir.


            //veri tipinin hangi degerler araliginda calistigini bulmak icin asagidaki kod kullanilir.hepsi icin kullanilabilir.
            int maxdeger = int.MaxValue;
            int mindeger = int.MinValue;
            Console.WriteLine(maxdeger);
            Console.WriteLine(mindeger);
            Console.ReadLine();




            float ondalikli_sayi = 35.64f;
            //eger 35.64 un yanina f koymassak double turunde algiliyip hata veriyor bunu engellemek ve float turunde oldugunu belli etmek icin yanina f koyuyoruz.
            Console.WriteLine(ondalikli_sayi);
            Console.ReadLine();

            float maxdeger1 = float.MaxValue;
            float mindeger2 = float.MinValue;
            Console.WriteLine(maxdeger1);
            Console.WriteLine(mindeger2);
            Console.ReadLine();




            //double veri tipinde deger tanimlarken ayri bir sekilde belirtmemize gerek yok
            double ondalikli_sayi1 = 34.92;
            Console.WriteLine(ondalikli_sayi1);
            Console.ReadLine();



            // char veri tipi TEK BIR KARAKTERI  tutmak icin kullandigimiz veri tipidir. ornek: ? ! * seklinde yada tek bir harf icin kullanilir.
            // tek tirnak icinde kullanilir
            char karakter = 'e';
            char karakter2 = '?';
            Console.WriteLine(karakter);
            Console.WriteLine(karakter2);
            Console.ReadLine();



            //string veri tipi cift tirnak icinde metin tutabilir.
            string a = "samil";
            string b = "arslan";
            string c = "hos geldiniz";
            Console.WriteLine(a);
            Console.WriteLine(b);
            Console.WriteLine(c);
            Console.Read();
            //writline yerine write kullansaydik verileri yan yana yazdirirdi.





            //boolean veri tipi iki alternatifin oldugu veri tipidir ya true yada false ile sonuclanir

            //bool kontrol1 = true;
            //bool kontrol2 = false;

            //bool sonuc = 10 > 5;
            //Console.WriteLine(sonuc);
            //Console.ReadLine();






            //object veri tipi veri tiplerinin atasidir. butun veri tiplerinin tanir

            object  r = 5;
            object n = "samil";
            object k = 23.34;
            object kontroll = true;
            object sonuc1 = 8 > 4;

            Console.WriteLine(sonuc1);
            Console.WriteLine(r);
            Console.WriteLine(n);
            Console.WriteLine(k);
            Console.ReadLine();



        }
    }
}
