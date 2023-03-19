using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vucut_Kitle_Endeksi
{
    class Program
    {
        static void Main(string[] args)
        {

            //Beden Kitle Indeksi = Kilo / boy*boy
            //beden kitle indeksi 18 e esit veya dusukse ZAYIF
            //18 ile 25 arasindaysa NORMAL
            //25 den buyukse OBEZ yazdiran program parcasini kodlayiniz

            Console.WriteLine("lutfen kilonuzu giriniz");
            int kilo = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("lutfen boyunuzu giriniz");
            double boy = Convert.ToDouble(Console.ReadLine());

            double bke = kilo / (boy * boy);

            if (bke<=18)
            {
                Console.WriteLine("ZAYIF....");
                Console.ReadLine();
            }
            else if (bke>18 && bke<25)
            {
                Console.WriteLine("NORMAL....");
                Console.ReadLine();
            }
            else if (bke>=25)
            {
                Console.WriteLine("OBEZ....");
                Console.ReadLine();
            }
            Console.ReadLine();

            /*En sonda eger bir sart vereceksek else kullanamayiz , else-if kullaniriz. Else kullanacaksak sadece kalan sartlar icin kullaniriz.
            Yeni bir sart tutamayiz*/

        }
    }
}
