using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Statik_Yapici_Metot
{
    class kullanici
    {
        private int kullaniciID { get; set; }
        private string isim { get; set; }
        private string soyisim { get; set; }
        private static int maas { get; set; } //static yapici etotunda degerini alir.

        // Class dan bir obje turettigimiz zaman ilk yapici metoda gider.
        // Burada hem static yapici metot`u hemde normal metot var.Ilk once static yapici metodu calisir.
        
        static kullanici() // static yapici metot , static olarak tanimlanmis degerleri atar
        {
            maas = 2500; // statik yapici metodu kullndigimiz icin deger atamasini direk olarak yaptik.
        }
        public kullanici(int _kullaniciid,string _isim,string _soyisim) // siradan bir yapici metot
        {
            kullaniciID = _kullaniciid; /* boyle alt tire ile tanimladigimiz icin oluyor.
                                           ama ayni ismi kullanip this. yaparalta kullanabilirdik */
            isim = _isim;
            soyisim = _soyisim;             
        }
        public void bilgilerigoster()
        {
            Console.WriteLine("kullanici bilgi");
            Console.WriteLine("id: "+kullaniciID);
            Console.WriteLine("isim: "+isim);
            Console.WriteLine("soyisim: " + soyisim);
            Console.WriteLine("maas: " + maas);
        }
        public void zamyap(int zammiktari) // int zammiktar=100 desek de oluyor
        {
            Console.WriteLine("kullaniciya zam yapiliyor..");
            Console.WriteLine("su anki maasi: "+(maas+zammiktari)+" tl");
        }
    }
}
