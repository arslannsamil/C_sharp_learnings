using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Method
{
    class Program
    {
        static void Main(string[] args)
        {
            // Aslinda statik void main`de bir metottur

            // Parametresiz - Geriye deger dondurmeyen metot tanimlama 

            selamver(); // Selamver metotunu cagir dedik.
           
            Console.ReadLine();
            
        }

        static void selamver()
        {
         /* void geriye deger dondurmeyen , sadece cikti islemlerinde kullanilir. void yazan yere veri tipimizi yazariz. int yazinca int turun
            de donnus yapar string yazarsan string turunde donus yapar ama void`de donus yapmaz. voidin yanina da metot ismi gelir  */

            // Burada yazmis oldugumuz metotlari yukaridaki statik void kismina yazip cagirmamiz lazim.

            Console.WriteLine("selamlar");
            
        }




    }
}
