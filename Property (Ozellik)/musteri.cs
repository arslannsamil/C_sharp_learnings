using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Property__Ozellik_
{
    public class musteri
    {
        public int kilo; // degisken

        //prop dedigimizde ayni yukaridaki baginti cikar.tek farki get set bloklarinin olmasi

        public int kilo2 { get; set; } /* property`nin get set blolari kullanilmadigi surece degisken ile ayni seyi ifade eder.
                                          get set kullanilacagi zaman zaten kapsulleme yapacagiz demek */
    }
}
