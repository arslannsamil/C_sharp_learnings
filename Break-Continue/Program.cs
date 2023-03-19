using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Break_Continue
{
    class Program
    {
        static void Main(string[] args)
        {

            //Break anahtar kelimesini kullandigimizda icinde bulundugu dongunun tamamini parcalar , donguden sonraki kod satirlarina gecer.
           
            //continue anahtar kelimesini kullandigimizda ise donguyu 1 defaya mahsus kirar , continue dan sonra bulunan kodlar 1 defa kesilir





            //1`den 10`a kadar yazsin ama 7 ye geldiginde donguyu kirip dursun

            //for (int i = 1; i <= 10; i++)
            //{
            //    if (i==7)
            //    {
            //        break;
            //    }
            //    Console.WriteLine(i);
            //}
            //Console.ReadLine();

            // 7 degerinin ekrana yazilmamasinin nedeni 7 sagladigi durumda Console.Writeline yapmadan donguyu kirmasini istememiz.




            for (int i = 1; i <= 10; i++)
            {
                if (i == 7)
                {
                    continue;
                }
                Console.WriteLine(i);
            }
            Console.ReadLine();

            //continue dan sonra olan kisim 1 sefer kesilir ve dongu tekrar calismaya baslar




        }
    }
}
