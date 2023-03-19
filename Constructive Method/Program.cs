using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Yapici_Metot_Mantigi_ve_Calisma_Yapisi
{
    class Program
    {
        static void Main(string[] args)
        {
            // Classlardan obje olusturdugum sirada olusan, geriye donus tipi olmayan metottur.

            // Metot adı sınıf adı ıle aynı olmalıdır.

            // Araba araba1 = new Araba(); dedigimizde olusan metota denir. Metot oldugunu Araba(); dan anlariz.

            /* ilk basta new araba kismi calisir classda bulunan asagidaki kisimin icine girer ordaki islmeleri yaptiktan sonra tekrar
              doner ve Araba araba1 kismina ugrar ve ondan sonra araba1 referansi olusur. */

            // public class Araba{

            // public Araba() yapici metot oldugunu buradan anlariz 'Araba()'
            // {
            //
            // Araba classinin yapici metotunun icindeyiz.
            //
            // }
            //
            //
            //}


            // yapici metot= constructor

            //yapici metot ctor  tab tab yapilarak da olusturulabilir.


            /* program.cs`de Araba araba1 = new Araba(.....); olusturup buraya int , string turunden parametre verip
             * daha sonra bu parametreleri class`da bulunan public Araba() ya tutturup onun susulu parantezinin icindeki _li degerlere esitleriz
             * bu durumda ayri sekilde tanimlamadan direk degerleri atamis oluruz. 
             * Yani kisaca atamak istedigimiz degerleri yapici metoda Araba araba1 = new Araba(); ile gonderdik
             * yapici metot(public Araba() ) o degerleri aldi public olarak daha once tanimladigimiz degerlere esitledi. */



            Araba araba1 = new Araba(4,"kirmizi","renault");

            Console.WriteLine("araba rengi :" + araba1.arabarengi);
            Console.WriteLine("araba kapisi :" + araba1.arabakapisi);
            Console.WriteLine("araba model :" + araba1.arabamodel);

            Console.ReadLine();






        }
    }
}
