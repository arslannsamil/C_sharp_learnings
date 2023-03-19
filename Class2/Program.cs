using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class2
{
    class Program
    {
        static void Main(string[] args)
        {
            // Get (elde atmek) verıyı alır-ceker , set (ayarlamak) verı uzrınde degısıklık yapar. 
            // Normlade program.cs'den erısılemeyen prıvate bılgılerıne (get; set;) kavramı sayesınde erısebılecegız.
            // prop yazıp tab tab yaparsak get set blogu kendılıgınden acılır.

            Ogrencı ogr = new Ogrencı();
            ogr.ADI = "furkan";
            ogr.SOYADI = "sadık";
            ogr.ALANI = "turkce-matematık";
            ogr.YASI = 13; //yası 18'den kucuk gırdııgımız zaman 18 ,daha buyuk gırersek de gırdıgımız degerı gırer.

            Console.WriteLine("adı:"+ ogr.ADI);
            Console.WriteLine("soyadı:"+ogr.SOYADI);
            Console.WriteLine("alanı:"+ogr.ALANI);
            Console.WriteLine("yası:"+ ogr.YASI);
            Console.ReadLine();

        }
    }
}
