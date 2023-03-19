using System;

namespace CokBoyutluDiziler
{
    class Program
    {
        static void Main(string[] args)
        {
            string[,] bolgeler = new string[5, 3]// 5 bolge , 3 sehir // 5 satir 3 sutun // satirlar 0. dimonsion (boyut) sutunlar 1.dimonsion.
           {
                {"Istanbul","Izmit","Balikesir" },
                {"Ankara","Konya","Kirikkale" },
                {"Antalya","Adana","Mersin" },
                {"Rize","Trabzon","Samsun" },
                {"Izmir","Mugla","Manisa" },

           };


            for (int i = 0; i <= bolgeler.GetUpperBound(0); i++)  // GetUpperBound(0) olmasinin nedeni 201. satırda 5`in oldugu kisim "0" . 3`un
                                                                  // oldugu kisim "1" olarak tanimlanir
            {
                for (int j = 0; j <= bolgeler.GetUpperBound(1); j++)
                {
                    Console.WriteLine(bolgeler[i, j]);
                }
                Console.WriteLine("***************");
            }
            Console.ReadLine();


        }



    }
}

