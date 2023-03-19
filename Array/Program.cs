using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Diziler
{
    class Program
    {
        static void Main(string[] args)
        {



            // String isim ="enes";    dedigimiz deger sadece enes icin gecerlidir ve sadece bir deger tutabilir daha fazla deger tutamaz.

            /*    veri tiplerine birden fazla deger tutturabilmek icin DIZI kullaniriz.
                  ORNEK: string[] isimler = { "ali", "enes", "yasin", "yakup", "eren" };    Buradaki verileri cagirmak icin ise index numarasi denilen sira 
                                                                                            numaralari kullnilir ve numaralandirma 0`dan baslayarak devam eder */




            //int[] sayilar = new int[4]; // sayilar adninda int veri tipinde bir dizi olusturuyorum ve int[4] diyerek 4 eleman tutmasini sagliyorum

            //// Dizimin icinde bulunacak elemanlara  deger atiyorum.
            //sayilar[0] = 10;
            //sayilar[1] = 20;
            //sayilar[2] = 30;
            //sayilar[3] = 40;

            //for (int i = 0; i < sayilar.Length; i++) // sayilar.length demek sayilar dizisinin uzunlugu kadar donsun denemk yani 4`e kadar
            //{
            //    Console.WriteLine(sayilar[i]);
            //}
            //Console.ReadLine();




            //string[] isimler = { "Mehmet", "Eren", "Ahmet", "Samil", "Erdal" }; /* Eger burada  string[] isimler= new string[4];  deseydim degerleri daha sonra 
            //                                                                       tanimlamam gerekecekti bu sekilde basta tanimladim */
            //Console.WriteLine(isimler[1]);

            //Console.ReadLine();





            // Dizinin elemanlarini kullanicidan alma ve ekrana yazdirma

            //int[] numbers = new int[4];

            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    Console.WriteLine("Numbers dizisinin " + (i) + ". index degerini giriniz :");
            //    numbers[i] = Convert.ToInt32(Console.ReadLine());
            //}
            //Console.WriteLine();
            //Console.WriteLine("**************************");

            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    Console.WriteLine(numbers[i]);
            //}
            //Console.ReadLine();





            // Kullanicinin girdigi sayi dizisinin icinde var mi kontrol eden varsa kac tane oldugunu soyleyen yoksa da yoktur diye uyaran programi kodlayiniz.


            //int[] sayilar = { 10, 10, 20, 30, 20, 30, 40, 50, 40, 50, 70, 55, 65, 70, 55, 65, 70, 55, 65, 5, 20, 35, 65, 5, 20, 35, 65, 80 };

            //int adet = 0;
            //int sayi = 0;

            //Console.WriteLine("Lutfen kontrol etmek istediginiz degeri girin");

            //sayi = Convert.ToInt32(Console.ReadLine());

            //for (int i = 0; i < sayilar.Length; i++)
            //{
            //    if (sayi == sayilar[i]) // Burada yaptıgımız olay gırdıgımız sayı degerını sırayla dızıde bulunan elemanlarla tek tek denemek
            //                            // sayılar[i] bunu sırayla denememızı . sayılar.length ıse bunu dızıdekı eleman sayısı kadar (28) kez 1 er 1
            //                            // arttırarak devam etmemızı saglıyor.denk geldıgı zaman ıse adet sayısını 1 arttırııp sıradekı eleman saglıyor mu dıye ona gecer.

            //    {
            //        adet++;
            //    }
            //}
            //if (adet == 0)
            //{
            //    Console.WriteLine("Girdiginiz deger bu dizide bulunmamaktadir");
            //}
            //else
            //{
            //    Console.WriteLine("Girdiginiz deger dizide bulundu");
            //    Console.WriteLine("Bu degerden " + adet + " adet vardir");
            //}

            //Console.ReadLine();







            /*  Kullanicidan 10 tane int deger alan:
             *  1- Kac adet tek  , cift eleman olduguna
             *  2- Cift degerlerin toplamini , tek degerlerin toplamini
             *  3- Cift degerlein toplami tek degerlerin toplamindan buyukse cift degerler buyuktur degilse tam tersini yazdirsin */

            //int[] sayilar = new int[10];

            //int tekadettoplam = 0;
            //int ciftadettoplam = 0;


            //int teksayilarintoplami = 0;
            //int ciftsayilarintoplami = 0;

            //int kullanicideger = 0;


            //for (int i = 0; i < sayilar.Length; i++)
            //{
            //    Console.Write(i + ". index degerini giriniz:");
            //    kullanicideger = int.Parse(Console.ReadLine());

            //    sayilar[i] = kullanicideger; // Dizimin icini kullanicidan aldigim degerlerle doldurdum.
            //}

            //for (int i = 0; i < sayilar.Length; i++)
            //{
            //    if (sayilar[i] % 2 == 0)
            //    {
            //        ciftadettoplam++;
            //        ciftsayilarintoplami = ciftsayilarintoplami + sayilar[i];
            //    }
            //    else
            //    {
            //        tekadettoplam++;
            //        teksayilarintoplami = teksayilarintoplami + sayilar[i];
            //    }
            //}

            //Console.WriteLine();
            //Console.WriteLine("**************************");
            //Console.WriteLine();


            //if (ciftsayilarintoplami>teksayilarintoplami)
            //{
            //    Console.WriteLine("Cift sayilarin toplami tek sayilarin toplamindan buyuktur");
            //}
            //else
            //{
            //    Console.WriteLine("Tek sayilarin toplami cift sayilarin toplamindan buyuktur");
            //}

            //Console.WriteLine();
            //Console.WriteLine("**************************");

            //Console.WriteLine("Cift sayilarin toplami: "+ ciftsayilarintoplami);

            //Console.WriteLine("cift sayilarin adedi: "+ ciftadettoplam);
            //Console.WriteLine();

            //Console.WriteLine("**************************");

            //Console.WriteLine("Tek sayilarin toplami: " + teksayilarintoplami);
            //Console.WriteLine("Tek sayilarin adedi: "+ tekadettoplam);

            //Console.ReadLine();








            //fibonacci sayi dizisini  for dongusu ve dizi kullanrak bul...... 









            ////Cok Boyutlu Diziler

            //string[,] bolgeler = new string[5, 3]// 5 bolge , 3 sehir // 5 satir 3 sutun // satirlar 0. dimonsion (boyut) sutunlar 1.dimonsion.
            //{
            //    {"Istanbul","Izmit","Balikesir" },
            //    {"Ankara","Konya","Kirikkale" },
            //    {"Antalya","Adana","Mersin" },
            //    {"Rize","Trabzon","Samsun" },
            //    {"Izmir","Mugla","Manisa" },

            //};


            //for (int i = 0; i <= bolgeler.GetUpperBound(0); i++)  // GetUpperBound(0) olmasinin nedeni 192. satirda 5`in oldugu kisim "0" . 3`un
            //                                                     // oldugu kisim "1" olarak tanimlanir
            //{
            //    for (int j = 0; j <= bolgeler.GetUpperBound(1); j++)
            //    {
            //        Console.WriteLine(bolgeler[i, j]);
            //    }
            //    Console.WriteLine("***************");
            //}
            //Console.ReadLine();





            //int[,] dizi = new int[2, 2];   // matris carpimi gibi dusun once satir sonra sutun ve baslarken 0. satir 0. sutun`dan baslar.

            //dizi[0, 0] = 25;
            //dizi[0, 1] = 35;
            //dizi[1, 0] = 17;
            //dizi[1, 1] = 16;

            //for (int i = 0; i < 2; i++)
            //{
            //    for (int j = 0; j < 2; j++) // Eger icerideki for dongusunun suslu parantezlerini kapatirsak matris seklinde gosteriyor neden ?
            //    {
            //        Console.Write(" {0} ", dizi[i, j]);

            //        Console.WriteLine();
            //    }

            //}
            //Console.ReadLine();





            //int[,] arrey = { { -2, 3 }, { 4, 6 }, { 5, 8 } }; /*  Ilk basta diardan sirayla say 0`dan baslayarak sonra istedigin sayiya geldiginde
            //                                                      icerden say 0-1 diye.  */


            //Console.WriteLine(dizi[2, 0]); //konsolda cikan sayi 5 olur.

            //Console.ReadLine();







            // Haftanin gunlerini bir dizi icerisine atayarak ekranda gosterin


            string[] haftaningunleri = { "pazartesi", "sali", "carsamba", "persembe", "cuma", "cumartesi", "pazar" };

            foreach (string a in haftaningunleri)
            {
                Console.WriteLine(a);
            }
            Console.ReadLine();




            // Klavyeden girilen 10 adet sayiyi bir diziye atayarak kucukten buyuge siralayin ve ekranda gosterin.






            //// Bir dizi icerisindeki tum sayilari toplayarak ortalamasini bulun 


            //int [] array = {25,25,25,25,25,25};
            //double toplam=0, ortalama = 0;
            //foreach (int a in array)
            //{
            //    Console.WriteLine(a);
            //    toplam = toplam + a;              
            //}
            //ortalama = toplam / array.Length;


            //Console.WriteLine("***********");
            //Console.WriteLine("Dizideki sayilarin ortalamasi:"+ortalama);


            //Console.ReadLine();







            //// Alfabedeki tum harfleri diziye atan ve sirayla yan yana yazdiran programi yapin. YAPIMINI ANLAMADIM.


            //char[] alfabe = new char[26];

            //int sira = 0;

            //for (char i = 'a'; i <= 'z'; i++)
            //{

            //    alfabe[sira] = i;
            //    Console.WriteLine(alfabe[sira]);

            //    sira++;
            //}
            //Console.ReadLine();








            // Rastgele uretilen 5 adet sayiyi buyukten kucuge dogru alt alta gosterin. NOT: Random rastgele= new random();v
            // nasil calistigini unuttu7m

            //int[] dizi = new int[5];

            //Random rastgele = new Random();

            //for (int i = 0; i < dizi.Length; i++)
            //{
            //    dizi[i] = rastgele.Next(0, 100);
            //}

            //Array.Sort(dizi);

            //Array.Reverse(dizi);

            //for (int i = 0; i < dizi.Length; i++)
            //{
            //    Console.WriteLine(dizi[i]);
            //}

            //Console.ReadLine();





            // Kucukten buyuge , buyukten kucuge siralama nasil yapilir.



        }
    }
}
