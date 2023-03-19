using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kalıtım_uygulama
{
    class OTOBUS:MOTORLU
    {
        public int koltuksayısı;
        public double aracuzunlugu;
        public bool engellıyolcuyerıvarmı;
        public override string ToString()
        {
            return string.Format("koltuk sayısı: {0}, arac uzunlugu: {1}, enngellı yerı var mı: {2}", koltuksayısı,aracuzunlugu,engellıyolcuyerıvarmı);
        }
    }
}
