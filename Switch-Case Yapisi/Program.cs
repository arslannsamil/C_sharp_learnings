using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Switch_Case_Yapisi
{
    class Program
    {
        static void Main(string[] args)
        
        {


            //Switch-Case kosul yapilari If-Else ile ayni mantikta ve ayni islevde calisir.

            //switch = if
            //default = else
            //break = kirar,islemin devam etmesini engeller 
            //switch bloguna yazilan deger teker teker case degerlerini kontrol eder hangisi sagliyior ise o case blogunda yazan kodu islevsel hale getirir.




            //Mini atm uygulamasi yap - kullanicidan alinan degerlere gore islemler yaptir (switch-case) kullanarak.
            // 1- Bakiye goruntuleme
            // 2- Para Cekme
            // 3- Para Yatir
            // 4- Cikis Yap
            // 1-2-3-4 disinda bir deger girilmis ise hata verir. 

            Console.WriteLine("atm ye hosgeldiniz");

            Console.WriteLine("lutfen bir islem seciniz");
            Console.WriteLine("1- bakiye goruntuleme");
            Console.WriteLine("2- para cek");
            Console.WriteLine("3- para yatir");
            Console.WriteLine("4 cikis yap");

            string secim = Console.ReadLine();

            int bakiye = 2000;

            switch (secim)
            {
                case "1":
                    Console.WriteLine("hesabinizda bulunan tutar:" + bakiye);
                    Console.ReadLine();
                    break;
                case "123,9":
                    Console.WriteLine("cekmek istediginiz tutari giriniz.");
                    int para_cekme = Convert.ToInt32(Console.ReadLine());              
                    if (bakiye >= para_cekme)
                    {
                        Console.WriteLine("hesabinizda kalan tutar:" + (bakiye - para_cekme));
                        Console.ReadLine();
                    }
                    else
                    {
                        Console.WriteLine("hesabinizda olan paradan daha fazla para cekemezsiniz");
                        Console.ReadLine();
                    }
                    break;
                case "3":
                    Console.WriteLine("yatirmak istediginiz tutari giriniz");
                    int para_yatirma = Convert.ToInt32(Console.ReadLine());                   
                    Console.WriteLine("hesabinizda kalan tutar:" + (bakiye + para_yatirma));
                    Console.ReadLine();
                    break;
                case "4":
                    Console.WriteLine("hesabinizdan cikis yapildi iyi gunler...");
                    Console.ReadLine();
                    break;

                default:
                    Console.WriteLine("gecersiz islem yaptiniz");
                    Console.ReadLine();
                    break;

            }
            Console.ReadLine();





        }
    }
}
