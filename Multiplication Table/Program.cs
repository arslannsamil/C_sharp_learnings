using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Carpim_Tablosu
{
    class Program
    {
        static void Main(string[] args)
        {
            //For dongusu ile carpim tablosu yapma



            for (int i = 1; i <= 10; i++)
            {
                for (int j = 1; j <= 10; j++)
                {
                    Console.WriteLine("{0}x{1}={2}", i, j, i * j);
                }
                Console.WriteLine("-------------");//bu eki kullanmamin nedeni carpim tablosu gibi bosluklu olmasini istedigim icin.
            }

            Console.ReadLine();

            //break point yaptigin zaman anlayacaksin ki her bir i degeri icin on adet j degeri donguyu tekrarlar ve sonra i den 1 deger daha alir. 




















        }
    }
}
