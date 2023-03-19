using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TUR_DONUSUMLERI
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 5;
            //integer veri tipinde bir a sayisi tanimladim ve icine 5 sayisini koydum

            byte b = (byte)a;
            /*integer veri tipinde olan a sayisinin yanina (byte) yazarak byte veri tipine donusturdum ve esitligin diger tarafinda olan yeni bir byte b 
             *degerine atadim.*/

            Console.WriteLine(b.GetType());
            //b.GetType b`nin hangi veri tipinde oldugunu ekrana yazdirmami istiyor
            Console.WriteLine(b);
            //b`nin icine atadigimiz sayi degeri olan 5`i ekrana yazdirmami istiyor
            Console.ReadLine();







            string sayi1 = "1";
            string sayi2 = "2";
            Console.WriteLine(sayi1 + sayi2);
            Console.ReadLine();
            //Boyle yaptigimiz zaman string degerler + isareti ile toplanamaz yan yana yazdirilir.






            //Int.Parse kullanarak string veri tipinden integer  veri tipi donusturme
            string sayi3 = "1";
            int c = int.Parse(sayi3);

            string sayi4 = "2";
            int d = int.Parse(sayi4);

            Console.WriteLine(c + d);
            Console.ReadLine();







            //Convert.ToInt32 kullanarak veri string veri tipinden integer veri tipi donusturme
            string sayi5 = "4";
            int e = Convert.ToInt32(sayi5);

            string sayi6 = "10";
            int f = Convert.ToInt32(sayi6);


            Console.WriteLine(e + f);
            Console.ReadLine();








            /*Kullanicidan alinan iki sayini toplami :
             *Read.Line burada kullanicinin girmis oldugu degeri temsil eder. Kullanicini girmis oldugu deger 
             *Read.Line kismina atanir*/

            int g = 0;
            Console.WriteLine("lutfen 1. sayiyi giriniz");
            g = Convert.ToInt32(Console.ReadLine());
            int j = 0;
            Console.WriteLine("lutfen 2. sayiyi giriniz");
            j = Convert.ToInt32(Console.ReadLine());
            int sonuc = g + j;
            Console.WriteLine("sonuc:" + sonuc);

            Console.ReadLine();







            //kullanicidan alinan degerler string veri tipinde olur ve onlari integera ceviririz.
            Console.WriteLine("lutfen yasinizi giriniz");
            string kullanici_yas = Console.ReadLine();
            int kullanici_yasint = Convert.ToInt32(kullanici_yas);
            Console.WriteLine("kullanicinin yasi:" + kullanici_yasint);
            Console.ReadLine();








            ////Kullanicidan alinan iki sayini toplamini yazdiran kodu giriniz.
            //Console.WriteLine("birinci sayiyi giriniz");

            //string sayi = Console.ReadLine();

            //int a = Convert.ToInt32(sayi);

            //Console.WriteLine("ikinci sayiyi giriniz");

            //string sayi1 = Console.ReadLine();

            //int b = Convert.ToInt32(sayi1);

            //Console.WriteLine("cevap:"+ (a+b));

            //Console.ReadLine();








            ////Integer veri tipinden String veri tipine donusturme

            //int sayi1 = 5;
            //string a = sayi1.ToString();
            //int sayi2 = 4;
            //string b = sayi2.ToString();

            //Console.WriteLine(a + b);
            ////string`de toplama islemi demek yan yana yazmak demektir.Cevap ekraninda 54 yazar
            //Console.ReadLine();










        }
    }
}
