using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BREAKPOINT_ve_TOOLTIP
{
    class Program
    {
        static void Main(string[] args)
        {
            //BREAKPOINT = Yazilan kodlarin derleyici tarafindan nasil derlendigini ve adimlarin nasil gerceklestigini gosterir.
            //adimlari gormek icin baslayacagin satirin basina gelip sol tik yap ve F10`a basarak satirlarin ilerleyisini izle.
            
            int a = 1;
            int b = 2;
            int c = 3;

            int sonuc = a + b + c;
            Console.WriteLine(sonuc);
            Console.ReadLine();
            
            //TOOLETIP = Yazilan kodun yaninda cikan bilgi kutusuna verilen isim tooletip olarak adlandirilir.
            
        }
    }
}
