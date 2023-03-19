using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace class7
{
    class Program
    {
        static void Main(string[] args)
        {
            ogrencııslem bilgi = new ogrencııslem(11111111, 1234567, "ahmet", "arslan", "sogutozu",50,50,50);

            

            yapmakıstenılenıslmısecın();

            bool kontrol = true;

            while (kontrol)
            {
                string secım = Console.ReadLine();
                switch (secım)
                {
                    case "1":
                        bilgi.ogrencıısımsoyısım();
                        break;
                    case "2":
                        bilgi.ıbanadresıogren();
                        break;
                    case "3":
                        bilgi.tckmlıknumarasınıogren();
                        break;
                    case "4":
                        bilgi.ogrencıadres();
                        break;
                    case "5":
                        bilgi.ogrencıortalama();
                        break;
                    case "6":
                        kontrol = false;
                        break;
                }
            }

        }
        static void yapmakıstenılenıslmısecın()
        {
            Console.WriteLine("ogrencı ısım soyısım ogrenmek ıcın lutfen 1'e basın. ");
            Console.WriteLine("ogrencı ıban ogrenmek ıcın lutfen 2'ye basın. ");
            Console.WriteLine("ogrencı tc ogrenmek ıcın lutfen 3'e basın. ");
            Console.WriteLine("ogrencı ev adresı ogrenmek ıcın lutfen 4'e basın. ");
            Console.WriteLine("ogrencı donem ortalamasını ogrenmek ıcın lutfen 5'e basın. ");
            Console.WriteLine("bılgı sıstemden cıkmak ıcın lutfen 6 ya basın. ");

        }
    }
}

