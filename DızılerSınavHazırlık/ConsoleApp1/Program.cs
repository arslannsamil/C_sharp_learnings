using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            #region SORU 1
        //    kullanıcıya kaç haneli şifreye sahip olmak istediğini soran ve şifre oluşturan
        //    int sifre = 0;
        //    Console.WriteLine("Kaç haneli şifre oluşturacaksınız :");
        //    sifre = Convert.ToInt32(Console.ReadLine());

        //    int[] sifreDizi = new int[sifre];
        //    Random rnd = new Random();
        //    int sayi = 0;
        //    for (int i = 0; i < sifre; i++)
        //    {
        //        sayi = rnd.Next(0, 9);
        //        sifreDizi[i] = sayi;
        //    }

        //    foreach (int i in sifreDizi)
        //    {
        //        Console.Write(i);
        //    }

        //    Console.WriteLine("Hocanın çözümü!!!");
            #endregion
            #region HOCANIN ÇÖZÜMÜ
        //    kullanıcıya kaç haneli şifreye sahip olmak istediğini soran ve şifre oluşturan

        //    Random rnd2 = new Random();
        //    Console.WriteLine("kaç haneli şifreye sahip olmak istersiniz");
        //    int sifre2 = Convert.ToInt32(Console.ReadLine());
        //    for (int i = 0; i < sifre; i++)
        //    {
        //        int ascii = rnd.Next(32, 127);
        //        char generateChar = Convert.ToChar(ascii);
        //        Console.WriteLine(generateChar);
        //    }
            #endregion
            #region SORU 2
        //    0 - 1001 arasında sayı tuttur kullanıcı bilmeye çalışşsın bileeyenince sayıya göre in ya da çık desin doğru bilincede bildin desin
        //    Random rnd = new Random();
        //    int sayi = rnd.Next(0, 10);
        //    while (true)
        //    {
        //        Console.WriteLine("Bir sayı giriniz :");
        //        int deger = Convert.ToInt32(Console.ReadLine());
        //        if (deger == sayi)
        //        {
        //            Console.WriteLine("Bildin");
        //            break;
        //        }
        //        else if (deger > sayi)
        //        {
        //            Console.WriteLine("İn");
        //        }
        //        else if (deger < sayi)
        //        {
        //            Console.WriteLine("Çık");
        //        }
        //    }
            #endregion
            #region SORU 3
        //    1)kullanıcıya kaç adet sayı girmesini istediğini sorulan ve o kadar sayı girmesine izin veren girdiği sayıların ort alan program
        //    Console.WriteLine(" kac adet sayı gırmek ıstersınız");
        //    int sayı = Convert.ToInt32(Console.ReadLine());
        //    int toplam = 0;
        //    for (int i = 0; i < sayı; i++)
        //    {
        //        Console.WriteLine("{0}. sayıyı gırınız", i + 1);
        //        int deger = Convert.ToInt32(Console.ReadLine());
        //        toplam += deger;


        //    }
        //    double ortalama = toplam / sayı;
        //    Console.WriteLine("ortalamanız: " + ortalama);

            #endregion
            #region SORU 4
        //    bir firmada çalışan 5 personele ait isim,soyisim,doğumyılı ve telefon bilg. alan kişinin adı girildiğinde o kişiye ait tüm bil.ekrana
        //    yazan(aynı isimde 1 er kişi vardır)

        //    string[] isim = new string[5];
        //    for (int i = 0; i < isim.Length; i++)
        //    {
        //        Console.WriteLine("İsim giriniz:");
        //        string isimler = Console.ReadLine();
        //        isim[i] = isimler;
        //    }

        //    string[] soyisim = new string[5];
        //    for (int i = 0; i < soyisim.Length; i++)
        //    {
        //        Console.WriteLine("soyisim giriniz:");
        //        string isimler2 = Console.ReadLine();
        //        soyisim[i] = isimler2;
        //    }

        //    string[] tel = new string[5];
        //    for (int i = 0; i < tel.Length; i++)
        //    {
        //        Console.WriteLine("tel giriniz:");
        //        string isimler3 = Console.ReadLine();
        //        tel[i] = isimler3;
        //    }

        //    Console.WriteLine("İsim giriniz :");
        //    string deger = Console.ReadLine();

        //    for (int i = 0; i < isim.Length; i++)
        //    {
        //        if (deger == isim[i])
        //        {
        //            Console.WriteLine("Soyisim :" + soyisim[i]);
        //            Console.WriteLine("Tel :" + tel[i]);

        //        }
        //    }
            #endregion
            #region SAMILIN COZUM
        //    string[] isimler = new string[5];

        //    for (int i = 0; i < isimler.Length; i++)
        //    {
        //        Console.WriteLine("{0}. kısının isim giriniz ", i + 1);
        //        string isim = Console.ReadLine();
        //        isimler[i] = isim;
        //    }

        //    string[] soyısımler = new string[5];

        //    for (int i = 0; i < soyısımler.Length; i++)
        //    {
        //        Console.WriteLine("{0}. kısının soyısım giriniz ", i + 1);
        //        string soyısım = Console.ReadLine();
        //        soyısımler[i] = soyısım;
        //    }

        //    string[] teller = new string[5];

        //    for (int i = 0; i < teller.Length; i++)
        //    {
        //        Console.WriteLine("{0}. kısının tel giriniz ", i + 1);
        //        string tel = Console.ReadLine();
        //        teller[i] = tel;
        //    }


        //    Console.WriteLine("bılgılerını ıstedıgınız ısımı gırınız");

        //    string deger = Console.ReadLine();

        //    for (int i = 0; i < isimler.Length; i++)
        //    {
        //        if (deger == isimler[i])
        //        {
        //            Console.WriteLine(isimler[i] + soyısımler[i] + teller[i]);
        //        }
        //    }
            #endregion
            #region SORU5

        //    2)50 elemanlı diziye rastgele 0 - 1000 ARasında değer atadıktan sonra kullanıcıdan 1 sayı alan alınan sayıdan dizide kaç tane old.ekrana yazan program

        //    int[] elemanlar = new int[50];

        //    int sayac = 0;


        //    Console.WriteLine("lutfen bır sayı gırınız: ");
        //    int sayi = Convert.ToInt32(Console.ReadLine());

        //    Random rnd = new Random();
        //    for (int i = 0; i < elemanlar.Length; i++)
        //    {
        //        elemanlar[i] = rnd.Next(0, 10);
        //        if (elemanlar[i] == sayi)
        //        {
        //            sayac++;
        //        }
        //    }
        //    Console.WriteLine(sayac);
        //    #endregion

        //    #region SORU6
        //    1)kullanıcıya kaç adet sayı girmesini istediğini sorulan ve o kadar sayı girmesine izin veren girdiği sayıların ort alan program

        //    Console.Write("kac adet sayı gırmek ıstıyorsunuz: ");
        //    int sayı = Convert.ToInt32(Console.ReadLine());

        //    int toplam = 0;

        //    for (int i = 0; i < sayı; i++)
        //    {
        //        Console.Write("lutfen {0}. sayıyı gırınız: ", i + 1);
        //        int girilensayı = Convert.ToInt32(Console.ReadLine());

        //        toplam += girilensayı;
        //    }
        //    double ortalama = toplam / sayı;

        //    Console.Write("gırdıgınız sayıların ortalaması: " + ortalama);

        //    Console.ReadLine();

            #endregion
        }
    }
}
