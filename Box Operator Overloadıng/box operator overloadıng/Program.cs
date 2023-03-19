using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace box_operator_overloadıng
{
    class Program
    {
        static void Main(string[] args)
        {
            kutu b1 = new kutu();
            kutu b2 = new kutu();
            kutu b3 = new kutu();


            b1.yukseklıkayarla(3);
            b1.genıslıklıkayarla(4);
            b1.uzunlukayarla(5);

            Console.WriteLine("kutu 1 : "+b1.ToString());
            Console.WriteLine(b1.hacımhesapla());

            b2.yukseklıkayarla(3);
            b2.genıslıklıkayarla(4);
            b2.uzunlukayarla(5);
            Console.WriteLine("kutu 2 : "+b2.ToString());
            Console.WriteLine(b2.hacımhesapla());


            b3 = b1 + b2;
            Console.WriteLine("kutu 3 : "+b3.ToString());
            Console.WriteLine(b3.hacımhesapla());


            if (b1==b2)
            {
                Console.WriteLine("b1 esıttır b2 ye");
            }
            else
            {
                Console.WriteLine("b1 esıt degıldır b2 ye");
            }
           
            Console.ReadLine();


        }
    }
}
