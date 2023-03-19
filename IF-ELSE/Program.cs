using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KARAR_YAPILARI_IF_ELSE
{
    class Program
    {
        static void Main(string[] args)
        {


            //ogrencinin notu 50 den buyuk ise basarili degil ise basarisiz yazdiran kod.

            //Console.WriteLine("LUTFEN NOTUNUZU GIRINIZ");
            //string not = Console.ReadLine();
            //int a = Convert.ToInt32(not);
            //if (a > 50)
            //{
            //    Console.WriteLine("BASARILI");
            //}
            //else
            //{
            //    Console.WriteLine("BASARISIZ");
            //}

            //Console.ReadLine();


            //else if birden fazla alternatifin oldugu yerlerde kullanillir.




            //ctrl+K  ctrl+d  yazilan satir kodlari duzenler.



            /*kullnicisdan 3 tane not alip bunlarin ortalamasini hesaplayan ;
              eger 80-100 arasinda ise A+
              60-80 arasi ise A yazdiran
              40-60 arasinda ise B+ yazdiran
              40 dan kucukse F yazdiran kod parcalarini yazdirin*/

            //IKI FARKLI COZUM 


            Console.WriteLine("lutfen 3 adet not giriniz");

            int a = Convert.ToInt32(Console.ReadLine());
            int b = Convert.ToInt32(Console.ReadLine());
            int c = Convert.ToInt32(Console.ReadLine());

            int ortalama = (a + b + c) / 3;

            if (80 <= ortalama && 100 >= ortalama)
            {
                Console.WriteLine("not degeriniz +A");
            }
            else if (60 <= ortalama && ortalama <= 80)
            {
                Console.WriteLine("not degeriniz A");
            }
            else if (40 <= ortalama && ortalama <= 60)
            {
                Console.WriteLine("not degeriniz B+");
            }
            else
            {
                Console.WriteLine("not degeriniz F");
            }
            Console.ReadLine();






            //Console.WriteLine("lutfen 3 adet not giriniz");

            
            //int a = int.Parse(Console.ReadLine());          
            //int b = int.Parse(Console.ReadLine());           
            //int c = int.Parse(Console.ReadLine());

            //int ortalama = (a + b + c) / 3;

            //if (80 <= ortalama && 100 >= ortalama)
            //{
            //    Console.WriteLine("not degeriniz +A");
            //}
            //else if (60 <= ortalama && ortalama <= 80)
            //{
            //    Console.WriteLine("not degeriniz A");
            //}
            //else if (40 <= ortalama && ortalama <= 60)
            //{
            //    Console.WriteLine("not degeriniz B+");
            //}
            //else
            //{
            //    Console.WriteLine("not degeriniz F");
            //}
            //Console.ReadLine();



        }
    }
}
