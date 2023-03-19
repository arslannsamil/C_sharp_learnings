using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metot_Ornek_Soru1
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Kullanicidan aldigimiz sayinin karesini alalim eger karesi 25`ten buyukse 
               karesi 25`den buyuktur
               degilse 25`den kucuktru desin */

            Console.Write("Bir sayi giriniz:");

            int sayi = int.Parse(Console.ReadLine());

           int a= kareal(sayi); /* ilk basta kareal`in icine kullanicidan aldigimiz degeri koyduk daha sonra 
                                           kareal`a ait static metotun icine girdi ve islemleri yapip return sayesinde
                                           geri gelerek int karedeger`e atandi */

            if (a>25)
            {
                Console.WriteLine("Karesi 25`den buyuktur");
            }
            else if (a==25)
            {
                Console.WriteLine("karesi 25`e esittir");
            }
            else
            {
                Console.WriteLine("karesi 25`den kucuktur");
            }
            Console.ReadLine();
        }

        static int kareal(int sayi)  // kareal degerinin icerisini kullanicidan aldigimiz deger ile doldurduk yani a ya atadik
        {
            return sayi * sayi;
        }


    }
}
