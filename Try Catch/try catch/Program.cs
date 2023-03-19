using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace try_catch
{
    class Program
    {
        static void Main(string[] args)
        {
            ////try catch finally : genel anlamda hatayi yakalamak icin kullanilir.

            //try
            //{
            //    int x = 5;
            //    int y = 0;
            //    x = x / y;

            //    // kodlari deneyen kisim
            //}
            //catch (Exception ex) //excaption handling (hata yakalama) yanina ex yazmamizin nedeni
            //                       //excaptionu cagirirken yardimci olmasi
            //{
            //    Console.WriteLine(ex.Message);  //ex.message diyerek excaptionu cagirdik ve bize hatanin ne oldugunu 
            //                                      //soylemesini istedik
            //    // try kisminda hata yakalanirsda calisir
            //    //Console.WriteLine("sifira bolme islemi yapilamaz");
            //    throw;
            //}
            //finally
            //{
            //    // catch de hata var yok fark etmeksizin calisir.
            //}


            try
            {
                Console.Write("lutfen bir sayi giriniz:");
                int x = Convert.ToInt32(Console.ReadLine());

                Console.Write("lutfen bir sayi daha giriniz:");
                int y = Convert.ToInt32(Console.ReadLine());

                Console.Write("sonuc:" + (x / y));

                Console.ReadLine();

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);

                //burada her turlu hatayi ayri ayri bize soyleyebilir (excaption) sayesinde.
                //int deger araligindan olmayabilir,tanimsiz bolme olabilir,sayi girilmeyebilir.
                //butun hatali islemlerde hatanin ne oldugunu bize soyler. 

                throw; //atama anlaminda kullanilir

                //catch icinde yakalanan hatayi tekrardan catch icinde kullanmak istersek 
                 //innerexception  kullaniriz. Hatayi tekrar ele almamiza yarar.
            }

        }

    }
}
