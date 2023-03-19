using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OPERATORLER
{
    class Program
    {
        static void Main(string[] args)
        {
            /*TOPLAMA = +
             * CIKARMA = -
             * CARPMA = *
             * BOLME = /
             * MOD BOLME = % bolme islemi yapildiginda kalan sayiyi bize verir.
             * BIR AZALTMA = -- \ BIR ARTTIRMA = ++
             * ATAMA =  =
             * BUYUK ESIT =   >=
             * KUCUK ESI T=  <=
             * ESIT =  ==
             * FARKLI =  !=
             * VE =  &&
             * VEYA =  ||
             * DEGIL =  !
             */



          //ESITTIR OPERATORU ILE ILGILI
            int sayi = 5;
            int sayi1 = 4;

            bool kontrol = sayi == sayi1;
            Console.WriteLine(kontrol);
            Console.ReadLine();
            //CEVAO OLARAK FALSE ALDIK.ESIT DEGILDIR '!=' OPERATORUNU KULLANSAYDIK TRUE ALIRDIK.



            //DEGIL OPERATORU ILE ILGILI 
            //KISACA VAR OLAN BIR SEYIN TAM TERSINI ALLIR

            bool a = true;

            Console.WriteLine(!a);
            Console.ReadLine();
            //a yi true olarak aldik ama aunlem isareti ile degili yani false cevirmis olduk.


            // a=a+4 demek a+=a demek ile ayni seyi ifade eder a`nin ustune 4 koyar
            // yukarida verilen islem 4 islem turunde de gecerlidir.

        }
    }
}
