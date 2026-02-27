using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Visual_Studio_Vaje_02_27.Abstraktni_Razredi_in_Interfaces {
    internal class Papiga : IZvok, IPremik {
        public string ime {  get; set; }

        public Papiga(string ime) {
            this.ime = ime;
        }//Konec Papiga

        public void SproziZvok() {
            Console.WriteLine(ime + " se oglasa CIV CAV");
        }//Konec SproziZvok

        public void Premik() {
            Console.WriteLine(ime + " se guga na gugalniku");
        }//Konec Premik
    }//Konec class Papiga
}
