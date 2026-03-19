using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Visual_Studio_Vaje_03_19_ {
    internal class Depozit : Racun {
        public double znesek;
        public int steviloDni;
        public DateTime zacetekVezave;

        const double obresti1 = 2.2;
        const double obresti2 = 3.0;
        const double obresti3 = 4.5;

        public Depozit(string ime, double stanje, double z, int d, DateTime zv) : base (ime, stanje) {
            this.znesek = z;
            this.steviloDni = d;
            this.zacetekVezave = zv;
        }//Konec Depozit

        public override double Obresti() {
            double procent = obresti1;
            if (znesek > 10000 && znesek <= 50000) {
                procent = obresti2;
            } else if (znesek > 50000) {
                procent = obresti3;
            }
            double obresti = Math.Round(znesek * (double)procent / 100 * steviloDni / 365, 2);
            return obresti;
            
        }//Konec Obresti
    }//Konec class Deposit
}
