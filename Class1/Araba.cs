using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class1
{
    class Araba
    {
        public string renk { get; set; }
        public int fıyat { get; set; }
        public string model { get; set; }
        public string vıtes { get; set; }
        public string plaka { get; set; }
        private string teker_kalıte; /*teker _kalıte bıraz daha soluk renklı , ustune geldıgıımız zaman ıse
                                  kılıt sımgesını gorecegız bunun nedenı prıvate olarak tanımlanmıs olması.
                                  prıvate olarak tanımladıgımızda sadece araba calssının ıcındekı ıkı suslu
                                  parantez ıcerısınden ulasabılırız . program.cs'den ulasamayız. Gormez.*/
        public string  TEKER_KALITESI //prıvate durumda olan teker kalıtesını publıc get set yaptıktan sonra erısebılırız.
        {
            get { return teker_kalıte; }
            set { teker_kalıte = value.ToUpper(); }
        }
    }
}
