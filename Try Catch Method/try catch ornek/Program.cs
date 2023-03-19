using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace try_catch_ornek
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine(" lutfen bolmek ıstedıgınız ıkı sayıyı gırınız.");
                int a = Convert.ToInt32(Console.ReadLine());
                int b = Convert.ToInt32(Console.ReadLine());
                int sayı = a / b;
                Console.WriteLine("sonuc: " + sayı);
            }
            catch (FormatException)
            {
                Console.WriteLine("gecersız deger gırdınız !");
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("payda sıfır olamaz !");
            }
            catch (OverflowException)
            {
                Console.WriteLine("gırılen deger aralık dısı !");
            }
            catch (OutOfMemoryException)
            {
                Console.WriteLine("deger sınırını astınız !");
            }
            catch (StackOverflowException)
            {
                Console.WriteLine("stack asımı !");
            }
            catch (NullReferenceException)
            {
                Console.WriteLine("bellekte bunun ıcın yer ayrılmamıs !");
            }
            catch (System.InvalidCastException)
            {
                Console.WriteLine("gecersız tur hatası !");
            }
            catch (IndexOutOfRangeException)
            {
                Console.WriteLine("dızı sınırları dısında !");
            }
            catch (ArrayTypeMismatchException)
            {
                Console.WriteLine("tur uyumsuzlugu !");
            }
            catch (ArithmeticException)
            {
                Console.WriteLine("matematıksel hata !");
            }
            catch (Exception)
            {
                Console.WriteLine("genel hata !");
            }
            finally
            {
                Console.WriteLine("fınally calıstı !");
            }

            Console.ReadLine();
        }
    }
}
