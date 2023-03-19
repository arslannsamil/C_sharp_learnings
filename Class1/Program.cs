using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class1
{
    class Program
    {
        static void Main(string[] args)
        {
            Araba arbsnf = new Araba(); // Araba sınıfındakı bılgılerı arbsnf adlı bır nesne ıle cagırdık.
           // Yukarida classlardan obje olusturdugumuz sirada olusan geriye donus tipi olmayan metota yapici metot denir.
            arbsnf.renk = "sıyah";
            arbsnf.fıyat = 150000;
            arbsnf.model = "2016";
            arbsnf.vıtes = "otomatıl";
            arbsnf.plaka = "06 ars 06";
            arbsnf.TEKER_KALITESI = "teker ıyı yola devam gardass";

            Console.WriteLine("araba rengı:" + arbsnf.renk);
            Console.WriteLine("araba vıtes turu:" + arbsnf.vıtes);
            Console.WriteLine("araba plaka:" + arbsnf.plaka);
            Console.WriteLine("araba model yılı:" + arbsnf.model);
            Console.WriteLine("araba fıyatı:" + arbsnf.fıyat);
            Console.WriteLine("araba teker durumu: " + arbsnf.TEKER_KALITESI);


            Console.WriteLine();
            Console.WriteLine("*****************");
            Console.WriteLine();

            // Aynı class'ı kullanarak farklı bılgılerı tekrar olarak gırebılırım bır sıkıntı olmaz.

            arbsnf.renk = "beyaz";
            arbsnf.fıyat = 140000;
            arbsnf.model = "2018";
            arbsnf.vıtes = "otomatıl";
            arbsnf.plaka = "06 sml 06";
            arbsnf.TEKER_KALITESI = "tekerı cope at gardass";

            Console.WriteLine("araba rengı:" + arbsnf.renk);
            Console.WriteLine("araba vıtes turu:" + arbsnf.vıtes);
            Console.WriteLine("araba plaka:" + arbsnf.plaka);
            Console.WriteLine("araba model yılı:" + arbsnf.model);
            Console.WriteLine("araba fıyatı:" + arbsnf.fıyat);
            Console.WriteLine("araba teker durumu: "+arbsnf.TEKER_KALITESI);

            Console.ReadLine();

        }
    }
}
