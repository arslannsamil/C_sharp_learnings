using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Static_Degisken
{
    class Program
    {
        static void Main(string[] args)
        {

            Calisan c1 = new Calisan();
            c1.calisanID=1111111;
            c1.isim = "samil";
            c1.soyisim = "arslan";
            

            Calisan.maas = 100;



            Console.WriteLine("calisan kisinin id`si: "+c1.calisanID);
            Console.WriteLine("calisan kisinin ismi: "+c1.isim);
            Console.WriteLine("calisan kisinin soyismi: " + c1.soyisim);

            Console.WriteLine("calisan kisinin maasi: "+Calisan.maas); 



            Console.ReadLine();
        }
    }
}
