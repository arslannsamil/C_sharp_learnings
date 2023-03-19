using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metot_Ornek_Soru2
{
    class Program
    {
        static void Main(string[] args)
        {
            // Kullanilanicidan alinan sayinin tek mi cift mi oldugunu bulan metot`u yazalim.

            Console.Write("Lutfen Bir Sayi Giriniz:");

            int GirilenSayi = Convert.ToInt32(Console.ReadLine());

            tekmiciftmi(GirilenSayi); // bunu gordukten sonra metota gider metottaki islemleri yaptiktan sonra tekrar buraya gelir.

            Console.ReadLine();
        }
        static void tekmiciftmi(int girilensayi)
        {
            if (girilensayi % 2 == 0)
            {
                Console.WriteLine("Girilen sayi Cifttir");
            }
            else
            {
                Console.WriteLine("Girilen Sayi Tektir");
            }

        }

    }
}
