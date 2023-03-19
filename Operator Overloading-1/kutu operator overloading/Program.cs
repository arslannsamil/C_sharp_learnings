using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kutu_operator_overloading
{
    class Program
    {
        static void Main(string[] args)
        {
            kutu k1 = new kutu();
            k1.uzunluk_hesapla(5);
            k1.yukseklık_ayarla(6);
            k1.genıslık_ayarla(8);
            Console.WriteLine("k1 kutusunun hacmı: {0}",k1.hacım_hesapla());

            kutu k2 = new kutu();
            k1.uzunluk_hesapla(10);
            k1.yukseklık_ayarla(11);
            k1.genıslık_ayarla(12);
            Console.WriteLine("k2 kutusunun hacmı: {1}", k2.hacım_hesapla());

            kutu k3 = new kutu();
            k3 = k1 + k2;
            Console.WriteLine("k3 kutusunun hacmı: {2}", k3.hacım_hesapla());


            Console.ReadLine();
        }
    }
}
