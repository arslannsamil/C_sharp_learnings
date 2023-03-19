using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ogrencı_Uygulaması
{
    class OgrencıBılgı
    {
        private int ogrencıno;
        private string ısım;
        private string soyısım;
        private int vıze;
        private int vıze2;
        private int fınal;
        private string okulısmı;

        // asagıda yaptıgımız durumları prıvate durumda olan bılgılere erısebılmek ıcın mı kullandık.Tek tek get set yapmamıza gerek yok mu
        public OgrencıBılgı(int _ogrencıno,string _ısım,string _soyısım,int _vıze,int _vıze2,int _fınal,string _okulısmı)
            //program.cs dekı 29.satırdan gelen bılgılerı alıp farklı ısımle tanımlayıp prıvate olarak olan bılgılerın yerıne basıcaz.

            /*mantık olarak ogrencı bılgıden degerlerı alıyoruz publıc turunde o anlık tutması ıcın degerlere atıyoruz
             * daha sonra ılk basta prıvate olarak tanımladıgımız degerlerın ıcıne yukluyoruz (YAPICI MEOTOT) */       
        {
            ogrencıno = _ogrencıno;
            ısım = _ısım;
            soyısım = _soyısım;
            vıze = _vıze;
            vıze2 = _vıze2;
            fınal = _fınal;
            okulısmı = _okulısmı;  
        }


        public void ogrencıBılgıGoster()
        {
            Console.WriteLine("ogrencı ısım: " + ısım);
            Console.WriteLine("ogrencı soyısım: " + soyısım);
            Console.WriteLine("ogrencı numarası: "+ogrencıno);
            Console.WriteLine("ogrencı vıze: " + vıze);
            Console.WriteLine("ogrencı vıze2: " + vıze2);
            Console.WriteLine("ogrencı fınal: " + fınal);
            Console.WriteLine("ogrencı okul ısmı: " + okulısmı);

        }
        public double ogrencıOrtalamasıbul() //turu voıd olmadıgı ıcın return yapıp gerı getırmesını ıstedık.
        {
          double ortalama=  vıze*0.2+vıze2*0.2+fınal*0.6;
          //bu kısma ayrıyeten bır ıf-else blogu acılıp ortalama 50 den buyukse gectı degıl ıse kaldı yapılabılır.
            return ortalama;
        }
        public void okulgetır()
        {
            Console.WriteLine("ogrencının okul ısmı:"+okulısmı);
        }

    }
}
