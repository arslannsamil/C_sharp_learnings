using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metot_Ornek_Soru3
{
    class Program
    {
        static void Main(string[] args)
        {
            // Kullanicidan iki sayi alalim hangi sayi buyukse onu ekrana yazdirsin.

            Console.WriteLine("lutfen karsilastirmak istediginiz iki sayiyi giriniz:" + " ");

            int sayi1 = Convert.ToInt32(Console.ReadLine());

            int sayi2 = Convert.ToInt32(Console.ReadLine());

            kiyaslama(sayi1, sayi2);

            Console.ReadLine();

        }
        static void kiyaslama(int sayi1, int sayi2)
        {
            if (sayi1 > sayi2)
            {
                Console.WriteLine("Buyuk olan sayi:" + " " + sayi1); 
            }
            else if (sayi1 == sayi2)
            {
                Console.WriteLine("Iki sayi birbirine esittir");
            }
            else
            {
                Console.WriteLine("Buyuk olan sayi:" + " " + sayi2);
            }

        }

    }
}
