using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parametreli_Method
{
    class Program
    {
        static void Main(string[] args)
        {

            // Parametreli - Geriye Deger Dondurmeyen Metot tanimlama

            //toplamayap(5,7);

            //carpmayap(5,7,10);

            isimsoyisimyazdir("Samil","ARSLAN"); // string turunde olduguu icin tirnak kullandik

            Console.ReadLine();

            /* asagida yeni metotlar yazip islem yapmasini saglayabiiriz ama asil calistiracagimiz kodu static void main kismina yaziyoruz 
               console.readline gibi en son ekranda tutacak islemi static void`e yazariz  */

        }
        static void toplamayap(int sayi1, int sayi2)
        {
            Console.WriteLine("Gonderilen sayilarin toplami:" + (sayi1 + sayi2));
            /* burada sayi1 ve sayi2 degerlerini static void main icerisindeki  toplamayap`in icinde atamamiz gerekiyo (sira ile yerlesir) */
        }

        static void carpmayap(int sayi1, int sayi2, int sayi3)
        {
            /* Static void icerisine tanimladigimiz degerler sayi1,sayi2 vs sadece o static void icersine girildiginde kullanildigi icin baska bir 
            static  (metot)icerisinde kullanmamiz sorun cikarmaz.*/

            Console.WriteLine("3 sayinin carpimi:" + (sayi1 * sayi2 * sayi3));

        }
        static void isimsoyisimyazdir(string isim, string soyisim)
        {
            Console.WriteLine("isim - soyisim:"+" "+ isim + " "+soyisim); // " " kullanmamin nedeni arada bosluk kalmasini istemem 
        }





    }
}
