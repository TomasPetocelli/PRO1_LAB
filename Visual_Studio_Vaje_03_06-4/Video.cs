using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Visual_Studio_Vaje_03_06_4 {
    public class Video : CD {
        protected double dodatek;

        public Video (double dodatek) {
            this.dodatek = dodatek;
        }//Konec Video

        public override double Izracun(int dni) {
            return base.Izracun(dni) + dni * dodatek;
        }//Konec Izracun
    }//Konec class Video
}
