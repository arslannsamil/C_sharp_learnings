using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Foreach_Dongusu
{
    class Program
    {
        static void Main(string[] args)
        {

            // Diziler icin kullanilan bir dongu cesitidir.

            string[] isimler = { "ahmet", "mehmet", "sevda", "mehtap", "seren" };

            foreach (string a in isimler) //isimler dizisindeki degerleri al ve string turunde tanimlanmis a degerinin icine at demek.
            {
                Console.WriteLine(a);
            }
            Console.ReadLine();



            /* foreach (var item in collection) */

            // Var = veri tipi     item = degerlerin icin eatilacagi kutu      collection = kullanilan dizi



          













        }
    }
}
