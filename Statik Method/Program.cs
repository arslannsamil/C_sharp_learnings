using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            personel.isimsoyisimyazdir();
            personel.sayilaritopla(7, 8);
            Console.ReadLine();
        
           // Classlar yesil renkle gosterilir. Console da yesil renkli ve bir sinifi ifade eder.

           /* Yani biz aslinda console.writeline yaptigimizda console sinifini icerisine  static olarak tanimlanmis writeline
              metodu calisir . readline`da ayni sekilde. */

           /* STATIC YAPICI METOTLA ILGILI BILINMESI GEREKENLER:
            * Static yapici metod erisim belirleyicisi (access modifiers) kullanmaz. (public-private) olmaz
            * Static yapici metod parametre alamaz.
            * Static yapici metod kac nesne ornegi olusturulursa olusturulsun bir kee calisir.
            * Bir sinifta sadece bir tane static yapici metot tanimlanabilir.
            * Static classlardan obje olusturulmaz
            * Static classlarin static olmayan bir sey tanimlanamaz
            * Static classlarda kalitim yapilmaz. */

        }
    }
}
