using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kalıtım_uygulama
{
    class Program
    {
        static void Main(string[] args)
        {
            ARABA t1 = new ARABA();
            t1.motorhacmı = 6.2;
            t1.yakıtturu = "dızel";
            t1.motornumarası = 12345;
            t1.beygırgucu = 220;
            t1.renk = "kırmızı";
            t1.modelyılı = 2009;
            t1.tekersayısı = 6;
            t1.aracagırlıgı = 4250;
            t1.maxsurat = 260;
            t1.cabrıomu = true;
            t1.otomatıkmı = false;
            Console.WriteLine("ARABAYA has ozellıklerın lıstesı= " + t1.ToString());


            ARABA t4 = new ARABA();
            t4.motorhacmı = 6.2;
            t4.yakıtturu = "dızel";
            t4.motornumarası = 12345;
            t4.beygırgucu = 220;
            t4.renk = "kırmızı";
            t4.modelyılı = 2009;
            t4.tekersayısı = 6;
            t4.aracagırlıgı = 4250;
            t4.maxsurat = 260;
            t4.cabrıomu = true;
            t4.otomatıkmı = false;
            Console.WriteLine("ARABAYA has ozellıklerın lıstesı= " + t4.ToString());

            //ARABA SINIFINDAN YENI NESNE OLUSTURUP TEKRAR OZELLIK ATAYABILIRIZ SIKINTI OLMAZ.




            OTOBUS t2 = new OTOBUS();
            t2.motorhacmı = 6.2;
            t2.yakıtturu = "dızel";
            t2.motornumarası = 12345;
            t2.beygırgucu = 220;
            t2.renk = "kırmızı";
            t2.modelyılı = 2009;
            t2.tekersayısı = 6;
            t2.aracagırlıgı = 4250;
            t2.koltuksayısı = 30;
            t2.aracuzunlugu = 12.5;
            t2.engellıyolcuyerıvarmı = false;
            Console.WriteLine("OTOBUSE has ozellıklerın lıstesı= " + t2.ToString());


            BISIKELT t3 = new BISIKELT();
            t3.uretıcıfırma = "umıt";
            t3.yassınırı = 18;
            t3.selemalzemesı = "pamuk";
            t3.aynavarmı = true;
            t3.renk = "mavı";
            t3.tekersayısı = 2;
            t3.aracagırlıgı = 15;
            t3.tekerınc = 22.2;
            t3.katlanabılırmı = true;
            t3.govdemalzemesı = "celık";
            Console.WriteLine("BISIKLETE has ozellıklerın lıstesı= " + t3.ToString());

            Console.ReadLine();
        }
    }
}
