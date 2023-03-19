using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Property__Ozellik_
{
    class Program
    {
        static void Main(string[] args)
        {
            musteri m1 = new musteri();

            m1.kilo = 85; //degisken olan kilo
            m1.kilo2 = 85; //property olan kilo


            Console.WriteLine( "degisken olan kilo: "+ m1.kilo ); 

            Console.WriteLine("property olan kilo: " + m1.kilo2);

            Console.ReadLine();
        }
    }
}
