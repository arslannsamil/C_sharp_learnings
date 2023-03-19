using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class5
{
    class Program
    {
        static void Main(string[] args)
        {
            Kayıt yenıkayıt = new Kayıt();

            yenıkayıt.okul_adı = "kırkkkale unıversıtesı";
            yenıkayıt.ad = "ahmet samıl";
            yenıkayıt.soyad = "arslan";
            yenıkayıt.sıcıl_no = 123456789;
            yenıkayıt.tc_no = 111111111;

            Console.WriteLine("okul adı: " + yenıkayıt.okul_adı);
            Console.WriteLine("kısı adı: " + yenıkayıt.ad);
            Console.WriteLine("kısı soyad: " + yenıkayıt.soyad);
            Console.WriteLine("sıcıl numarası: " + yenıkayıt.sıcıl_no);
            Console.WriteLine("tc: " + yenıkayıt.tc_no);

            Console.ReadLine();

        }
    }
}
