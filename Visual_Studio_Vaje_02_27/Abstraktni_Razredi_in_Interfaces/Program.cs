using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Visual_Studio_Vaje_02_27.Abstraktni_Razredi_in_Interfaces {
    internal class Program {
        public static void Main(string[] args) {
            Zival p = new Pes("Rex", 5);
            p.Izpis();
            p.Oglasanje();
            p.Premik();

            Zival m = new Macka("Mici", 5);
            m.Izpis();
            m.Oglasanje();
            m.Premik();

            IZvok papigaZvok = new Papiga("Charlie");
            IPremik papigaPremik = new Papiga("Bela");
            papigaZvok.SproziZvok();
            papigaPremik.Premik();

        }//Konec Main
    }//Konec class Program
}
