using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KALITIM_ORNEK
{
    internal  class satılıkdaıre:ev
    {
        public string emlakcı { get; set; }
        public decimal satısfıyatı { get; set; }
        public void satılıkozellık()
        {
            Console.WriteLine("satılılk ozellık= emlakcı: {0}, fıyat: {1}"+emlakcı,satısfıyatı);
        }
    }
}
