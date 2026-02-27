using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Visual_Studio_Vaje_02_27.Abstraktni_Razredi_in_Interfaces {
    abstract class Zival {
        protected int starost;

        public string ime {  get; set; }
        public string vrsta { get; set; }

        public Zival(string i, string v, int s) { 
            ime = i;
            vrsta = v;
            starost = s;
        }//Konec Zival

        public void Izpis() {
            Console.WriteLine("Ime: " + ime + ", Vrsta: " + vrsta + ", Starosyt: " + starost);
        }//konec Izpis

        public abstract void Oglasanje();

        public abstract void Premik();

    }//Konec class Zival
}
