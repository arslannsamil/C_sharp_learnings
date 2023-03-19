using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kalıtım_uygulama
{
    class ARABA:MOTORLU
    {
        public int maxsurat;
        public bool cabrıomu;
        public bool otomatıkmı;
        public override string ToString()
        {
            return string.Format("maksımum hız: {0}, cabrıo mu: {1}, otomatık mı: {2}", maxsurat,cabrıomu,otomatıkmı);
        }
    }
}
