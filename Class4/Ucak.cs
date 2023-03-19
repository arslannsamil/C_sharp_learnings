using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class4
{
    class Ucak:Yolcu //yolcu sınıfındakı bılgılerı ucak sınıfına aktarmıs olduk. program.cs'den ıkı tarafın bılgısını de alabılecegız.
    {
        private string marka;
        private string kalkıs;
        private string varıs;
        
        // private tanimlanmis bir yapiya bu sekilde erisme islemine kapsulleme denir.
        public string MARKA
        {
            get { return marka; }// Basmis oldugumuz markayi geri program.cs`e yolla
            set { marka = value.ToUpper(); } // Girdigimiz markayi private olarak aldigimiz markaya bas 
        }
        public string KALKIS
        {
            get { return kalkıs; }
            set { kalkıs = value.ToUpper(); }
        }
        public string VARIS
        {
            get { return varıs; }
            set { varıs = value.ToUpper(); }
        }
    }
}
