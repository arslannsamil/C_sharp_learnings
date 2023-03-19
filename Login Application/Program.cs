using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Login_Uygulamasi
{
    class Program
    {
        static void Main(string[] args)
        {

            /*kullanici giris sayfasi uygulamasi yapacagiz 
              kullanici adi ve sifresini dogru girerse tebrikler basarili bir sekilde giris yaptiniz 
              yanlis girerse hata verelim 3 hak teniyalim kullanici yanlis girdigi surece dongu donmeye devam etsin.*/

            int hak_sayisi = 3;

            while (true)//while dongusunu true yapmamizin nedeni dongunun surekli olarak kendisini tekrar etmesini istememiz.
            {
                Console.WriteLine("kullanici adinizi giriniz");
                string kullanici_adi = Console.ReadLine();

                Console.WriteLine("sifrenizi giriniz");
                string sifre =Console.ReadLine();


                if (kullanici_adi == "samil" && sifre == "1234")
                {
                    Console.WriteLine("Tebrikler Basarili Bir Sekilde Giris Yaptiniz");
                    break;
                }
                else
                {
                    Console.WriteLine("Girdiginiz Kullanici adi veya Sifre Yanlis ");


                    if (hak_sayisi>0)
                    {
                        hak_sayisi = hak_sayisi - 1;                      
                        
                        Console.WriteLine("Kalan deneme sayiniz:"+hak_sayisi);
                    }
                    if (hak_sayisi==0)
                    {
                        Console.WriteLine("Deneme hakkiniz kalmadi lutfen daha sonra tekrar deneyin");
                        break;
                    }                   
                   
                }

            }
            Console.ReadLine();








        }
    }
}
