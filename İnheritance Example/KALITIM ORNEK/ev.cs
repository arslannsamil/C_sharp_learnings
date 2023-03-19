using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KALITIM_ORNEK
{
    internal class ev
    {
        public string ıl { get; set; }
        public string ılce { get; set; }
        public int odasayısı { get; set; }
        public int metrekare { get; set; }
        public string adres { get; set; }
        public string ısınmasıstemı { get; set; }

        public void ozellıkgoster()
        {
            Console.WriteLine("ev ozellıklerı= ıl: {0}, ılce: {1}, adres: {2}",ıl,ılce,adres);
        }

    }

}
