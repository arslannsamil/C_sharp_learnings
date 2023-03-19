using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace operatoroverloading2
{
    class Program
    {
        static void Main(string[] args)
        {

           // +x, -x, !x, ~x, ',' , true, false  Bu birli işleçler aşırı yüklenebilir.

           /*== ve != işleçleri
             < ve > işleçleri
             <= ve >= işleçleri karsilikli yuklnemelidir*/




         //decimalnumber number1 = new decimalnumber(10);
         //decimalnumber number2 = new decimalnumber(8);

            ///*normal sartlarda iki integer sayiyi toplayabiliyorken farkli bir siniftan olusturulmus  
            //  sayilari toplayamiyorum cunku sistem o sinif icin 4 islmein ne ise yaradigini bilmiyor
            //   bu sikinti icin operator overloading yontemini kullaniyoruz. */

            //var newnumbar = number1 + number2; /* decimalnumber sinifinfan olusturulmus number1 ve 
            //                                       number2 ile islme yapamiyorum.+ isaretinin o classta bir karsiligi yok
            //                                        bu butun islmeler icin gecerli => , =< de dahil bu islemleri yapanilmek icin operatoroverloading kullaniliyor. 
            //                                         bu islemin gecerli olmasi icin sinfin icerisinde + isleminin tanimlanmasi gerekiyor. */
            //Console.WriteLine(newnumbar.value);
            //Console.ReadLine();





            // BU ORNEK DAHA ANLASILIR OLDU. 

            user userdb = new user() { id = 1, fullname = "samil arslan" };
            user userapi = new user() { id = 2, fullname = "samil arslan" };

            Console.WriteLine(userapi == userdb); // id farkli oldugu icin false verdi.
            Console.ReadLine();

            

        }
        public class decimalnumber
        {
            public decimal value { get; set; }
            public int precision { get; set; }

            public decimalnumber(decimal value)
            {
                this.value = value;
            }

            public static decimalnumber operator +(decimalnumber number1, decimalnumber number2)
            {
                return new decimalnumber(number1.value + number2.value);

                //eger overloading ettigimiz operatorun cifti varsa onu da overloading etmek zorundayiz (== =! , < >  vs.)

            }


        }

        public class user
        {
            public int id { get; set; }
            public string fullname { get; set; }

            public static bool operator ==(user u1, user u2) => u1.id == u2.id;
            public static bool operator !=(user u1, user u2) => u1.id != u2.id;

        }

    }
}
