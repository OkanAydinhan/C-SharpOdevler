using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace odev
{
    public class Araba
    {
        public string marka = null;
        public string vites = null;
    
    
        public void markaVitesYaz(string marka,string vites)
        {
            Console.WriteLine(marka + " " + vites+"lidir.");
        }
    }
}
