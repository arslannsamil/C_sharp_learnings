using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Statik_Yapici_Metot
{
    class Program
    {
        static void Main(string[] args)
        {
            kullanici k1 = new kullanici(1,"samil","arslan");

            

            k1.bilgilerigoster();
            k1.zamyap(100);

            Console.ReadLine();
        }
    }
}
