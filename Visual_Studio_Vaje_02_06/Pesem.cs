using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Visual_Studio_Vaje_02_06 {
    internal class Pesem {
        public string naslov;
        public int minute;
        public int sekunde;

        public Pesem(string n, int m, int s) {
            naslov = n;
            minute = m;
            sekunde = s;
            
        }//Konec konstruktor Pesem
    }//Konec class Pesem
}
