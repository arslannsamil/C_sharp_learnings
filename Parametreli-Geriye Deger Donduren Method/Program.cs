using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parametreli_Donen_Metot
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Parametre alan - geriye deger donduren metot tanimlama
              return anahtar kelimesi 
              metot sonu */

            /* int donendeger= toplamayap(6, 7); //return ile toplamayap metodunun icini doldurduk sonra onu alip donen degere atadik. 

              if (donendeger>10)
              {
                  Console.WriteLine("deger 10`dan buyuktur");
              }
              else
              {
                  Console.WriteLine("deger 10`dan kucuktur");
              }
              Console.ReadLine(); */

            string gelenisimsoyisimdegeri = isimsoyisimdondur("Samil", "ARSLAN");

            Console.WriteLine(gelenisimsoyisimdegeri);

            Console.ReadLine();
        }

        static int toplamayap(int sayi1, int sayi2)
        {
            int sonuc = sayi1 + sayi2;
            

            return sonuc; // Return  islem sonucunu aliyo ve metodun cagirildigi yere geri goturur (17.satir)

            // return anahtar kelimesi nir metotun bitisidir ondan sonra yazdigin degerler calismaz 
            
        }
        static string isimsoyisimdondur(string isim, string soyisim)
        {
            // static string yazan yerde 'string' kismi bize return ile geri dondurcegimiz turu belirtir
            
            
            return isim + " " + soyisim;    /* burada isim soyisim degiskenleri string oldugu icin eger static string yerine
                                               int yazsaydik hata alirdik  */
            
        }




    }
}
