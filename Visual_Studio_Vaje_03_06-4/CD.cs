using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Visual_Studio_Vaje_03_06_4 {
    public class CD {
        protected const double enDan = 1.0;
        protected const double dvaDni = 2.0;
        protected const double triDni = 3.0;
        protected const double vecDni = 1.5;

        public virtual double Izracun(int dni) {
            double znesek = 0;
            if (dni > 3) {
                znesek = (dni - 3) * vecDni + triDni;
            } else {
                switch (dni) {
                    case 1: znesek = enDan; break;
                    case 2: znesek = dvaDni; break;
                    case 3: znesek = triDni; break;
                }//Konec switch
            }//Konec if-esle
            return znesek;
        }//Konec Izracun
    }//Konrec class CD
}
