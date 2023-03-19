using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace method_overloading
{
    class Program
    {
        static void Main(string[] args)
        {
            mat m = new mat();
            Console.WriteLine(m.multyplay(2,3));
            Console.WriteLine(m.multyplay(2,3,4));
            Console.ReadLine();
        }
        class mat
        {
            public int multyplay(int num1, int num2) // burasi kodun imzasi gibidir multyplay olarak
                                                     //2 tane metot tanimlanmis olsada ondan sona gelen int num1 ve int num2 onun imzasidir
                                                     //Yani farkli sayida degere sahip ayni isimli metodlar sikinti olusturmaz.
                                                     //eger ikisinde de iki parametre varsa bu sefer veri tipleri farkli olmalidir
                                                     //iki parametre ve iki vfarkli veri tipi varsa ve bunlar ayniysa bu sefer siralari farkli olmalidir.
                                                     //yani kisacasi birbirlerine benzememeleri gerekiyor.
            {
                return num1 * num2;
            }
            public int multyplay(int num1, int num2, int num3)
            {
                return num1 * num2 * num3;

            }
        }

    }
}
