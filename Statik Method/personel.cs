using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class personel
    {
        /* Bir metot statik olarak tanimlanmissa siniftan obje olusturmamiza gerek yoktur.
             public static void komut() */
        //static demek class ismi uzerinden erisicegim demek static olmassa nesne olusturman ve o nesne ustunden cagirman gerekir.
        public static void isimsoyisimyazdir() // Burada static olmasaydi program.cs kisminda nesne olusturmam gerekirdi. 
        {
            Console.WriteLine("samil arslan");
        }
        public static void sayilaritopla(int sayi1,int sayi2)
        {
            Console.WriteLine("iki sayinin toplami: "+(sayi1+sayi2));
        }
    }
}
