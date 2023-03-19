using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ogrencı_Uygulaması
{
    class Program
    {
        static void Main(string[] args)
        {

            /* Bır ogrencının ogrencı no, ısım, soyısım,vıze,vıze2,fınal ve okul ısımı adında degıoskenlerı olacak 
             * erısım belırleyıcılerını prıvate yapacagız yapıcı metot kullanarak degıskenlere degerlerı atayacagız
             * ogrencıBılgıGoster() metodu olacak ogrencının bılgılerını gorebılecegız
             * ogrencıOrtalamasıBul() metodu olacak
             * 
             * okulGetır() metodu olacak
             * 
             * ogrencının secımıne gore ıslemler yapacagız 
             * 1- Ogrencı bılgılerını goster.
             * 2- Ogrencı ortalamasını goster.
             * 3- Orencını okulunu ogren.
             * 4- Cıkıs yap.
             */

            OgrencıBılgı bılgı = new OgrencıBılgı(1,"samıl","arslan",50,40,73,"kırıkkale unıversıtesı");

            Console.WriteLine("uygulamamıza hos gfeldınız yapmak ıstedıgınız ıslemı secınız...");

            ıslemlerıgoster(); /* ılk olarak bu ıslme metotu calıstıracak ,yer kaplamasın ve ornek olması acısından yaptık zarurı degıl
                                * statıc voıd olarak gıttıgı ıcın gerı donmelı degıl metotu calıstırp tekrar gelıp kaldıgı yerden devam edecek. 
                                * bunu alıp whıle dongusunu ıcıne atarsak her seferınde soruyu tekrar sorar 4'e basana kadar. */            
              
            bool kontrol = true; // kontrolu true olarak belırledık her turlu dongunun ıcıne gırecek 
                                 //en sonda da 4'e basıp cıkması ıcın case "4" de kontrol=false yaptık donguyu kırdı.

            while (kontrol) // dongu 4'e basılmadıgı surece donmeye ve basılan degerı gostermeye devam eder.
            {
                string secım = Console.ReadLine();
                switch (secım)
                {
                    case "1": //tırnak ıcınde yazmamın nedenı swıtch'e strıng tanımlamıs olmamız.
                        bılgı.ogrencıBılgıGoster();
                        break;
                    case "2":
                        double ogrencıortalama = bılgı.ogrencıOrtalamasıbul();
                        Console.WriteLine("ogrencının ortalaması: "+ogrencıortalama);
                        break;
                    case "3":
                        bılgı.okulgetır();
                        break;
                    case "4":                      
                        kontrol = false; //kontrol , 4'e bsaıldıgında false donecek ve dongu kırılacak 
                        break;
                }
            }
                     
        }
        static void ıslemlerıgoster()
        {
            Console.WriteLine("1- ogrencı bılgılerını goster");
            Console.WriteLine("2- orencı ortalamasını goster");
            Console.WriteLine("3- ogrencı okulunu goster");
            Console.WriteLine("4- cıkıs yap");
        }
        
    }
}
