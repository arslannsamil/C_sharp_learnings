using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Do_While_Dongusu
{
    class Program
    {
        static void Main(string[] args)
        {

            /*Do-While dongusunun While dongusunden farki ilk basta yazdigimiz kodun sarti saglamasa bile gecerli olmasi 
            nedeni ise ilk once do yazilip altina while sarti getirilmesi*/



            //do-while ile 1`den 10`a kadar olan sayilari ekrana yazdir

           /* int sayi = 1;
            do
            {
                Console.WriteLine(sayi);
                sayi++;
            } while (sayi<=10);
            Console.ReadLine(); */




            //do-while ile 1`den 100`e kadar olan sayilarin toplamini ekrana yazdiriniz

            int a = 1;
            int sayac = 0;
            do
            {
                sayac = sayac + a;
                              
                a++;
            } while (a<=100);

            Console.WriteLine("1`den 100` e kadar olan sayilarin toplami:"+ sayac);

            Console.ReadLine();






             
        }
    }
}
