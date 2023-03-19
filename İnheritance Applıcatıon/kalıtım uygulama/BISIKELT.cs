using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kalıtım_uygulama
{
    class BISIKELT:MOTORSUZ
    {
        public bool katlanabılırmı;
        public string govdemalzemesı;
        public double tekerınc;
        public override string ToString()
        {
            return string.Format("katlanabılır mı: {0}, govde malzemesı: {1}, teker ınc boyutu: {2} ", katlanabılırmı, govdemalzemesı,tekerınc);
        }
    }
}
