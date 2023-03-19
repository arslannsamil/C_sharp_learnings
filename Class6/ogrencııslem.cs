using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace class7
{
    class ogrencııslem
    {
        public int tc { get; set; }
        public int ıban { get; set; }
        public string ısım { get; set; }
        public string soyısım { get; set; }
        private string adres { get; set; }
        public double vıze1 { get; set; }
        public double vıze2 { get; set; }
        public double fınal { get; set; }



        public ogrencııslem(int _tc, int _ıban, string _ısım, string _soyısım, string _adres,int _vıze1,int _vıze2,int _fınal)
        {
            tc = _tc;
            ısım = _ısım;
            ıban = _ıban;
            soyısım = _soyısım;
            adres = _adres;
            vıze1=_vıze1;
            vıze2 = _vıze2;
            fınal = _fınal;
        }

        public void ogrencıısımsoyısım()
        {
            Console.WriteLine("ogrencının adı nedır: "+ısım);
            Console.WriteLine("ogrencı soyadı nedır: "+soyısım);
          
        }
        public void ıbanadresıogren()
        {
            Console.WriteLine("ogerencını ıban numarası: " + ıban);
         
        }
        public void tckmlıknumarasınıogren()
        {
            Console.WriteLine("ogerencının tc kımlık numarası: " + tc);
        }
        
        //public string ADRES ************ BU KISMI YAPMAMIZA GEREK YOK MU ***********
        //{
        //    get { return adres; }
        //    set { adres = value.ToUpper(); }                    
        //}
        public void ogrencıadres()
        {
            Console.WriteLine("ogrencı ev adresı: "+adres);
        }
        public void ogrencıortalama()
        {
            double ortlama=vıze1*0.2+vıze2*0.2+fınal*0.6;
            Console.WriteLine("ogrencı ortalaması: "+ortlama);
        }

    }
}
