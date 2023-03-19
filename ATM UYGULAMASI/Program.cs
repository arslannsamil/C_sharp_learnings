using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATM_UYGULAMASI
{
    class Program
    {
        static void Main(string[] args)
        {
            // Kullaniciya nasil bir islem yapmak istedigini soracagiz
            // 1-Bakiye goruntuleme
            // 2-Para cekme
            // 3-Para yatirma
            // 4-E`ye basarsa cikis yaptiracagiz

            Console.WriteLine("HOSGELDINIZ");
            Console.WriteLine("Lutfen yapmak istediginiz islemi seciniz");

            

            int bakiye = 1000;

            string secim = Console.ReadLine();
            
            
                if (secim == "1")
                {

                    Console.WriteLine("Bakiyenizin tutari:" + bakiye);
                    Console.ReadLine();
                }

                else if (secim == "2")
                {
                Console.WriteLine("Lutfen cekmek istediginiz tutari giriniz");
                int cekilecek_tutar = Convert.ToInt32(Console.ReadLine());
                    if (bakiye > cekilecek_tutar)
                    {                       
                        Console.WriteLine("Kalan bakiyeniz:" + (bakiye - cekilecek_tutar));
                        Console.ReadLine();
                    }
                    else
                    {
                        Console.WriteLine("Bakiyenizde olan tutardan daha fazla para cekemessiniz");
                        Console.ReadLine();
                    }

                }

                else if (secim == "3")
                {
                    Console.WriteLine("Lutfen yatirmak istediginiz tutari giriniz");
                    int yatirilacak_tutar = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Total bakiyeniz:" + (bakiye + yatirilacak_tutar));
                    Console.ReadLine();
                }
                else if (secim == "e")
                {
                    Console.WriteLine("ATM`den cikis yapiliyor");
                    Console.WriteLine(" IYI GUNLER DILERIZ...");
                    Console.ReadLine();
                }
                else
                {
                    Console.WriteLine("LUTFEN GECERLI BIR ISLEM SECINIZ");
                    Console.ReadLine();
                }
          

        }
    }
}
