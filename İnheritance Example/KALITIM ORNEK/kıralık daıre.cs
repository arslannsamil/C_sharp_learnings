using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KALITIM_ORNEK
{
    internal class kıralık_daıre:ev
    {
        public bool esyalımı { get; set; }
        public double kırabedelı { get; set; }
        public double depozıto { get; set; }

        public void kıralıkozellıkler()
        {
            Console.WriteLine("kıra bedelı: {0}, depozıto: {1}, esyalı: {2}"+kırabedelı,depozıto,esyalımı);
        }
    }
}
