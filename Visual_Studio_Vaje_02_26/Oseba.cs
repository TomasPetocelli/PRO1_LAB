using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Visual_Studio_Vaje_02_26 {
    internal class Oseba {
        public string ime;

        public Oseba(string ime) {
            this.ime = ime;
        }//Konec Oseba

        public virtual string ToString() {
            return "Ime: " + ime;
        }//Konec ToString

    }//Konec class Oseba
}
