using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace operatoroverloading
{
    class Program
    {
        static void Main(string[] args)
        {
            myclass x = new myclass{ x=10};
            myclass y = new myclass{ x=7}; 

            myclass z = x + y;

            Console.WriteLine(z.x);

            Console.ReadLine();
        }
    }
    class myclass
    {
       // operatorleri asiri yuklemem icin  public veya static olmasi lazim.
       public int x { get; set; }
        public static myclass operator+(myclass left,myclass right)
        {
            return new myclass { x = left.x + right.x };
        }
    }
}
