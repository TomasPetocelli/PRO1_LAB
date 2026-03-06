using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Visual_Studio_Vaje_03_06_4 {
    public class DVD : Video {
        private double kavcija;

        public DVD (double dodatek, double kavcija) : base (dodatek) {
            this.kavcija = kavcija;
        }//Konec DVD

        public override double Izracun(int dni) {
            return base.Izracun(dni) + kavcija;
        }//Konec Izracun
    }//Konec class DVD
}
