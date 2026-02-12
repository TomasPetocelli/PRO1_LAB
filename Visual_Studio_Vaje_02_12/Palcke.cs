using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Visual_Studio_Vaje_02_12 {
    internal class Palcke {
        int stPalck;
        int igralec;

        public Palcke() {
            this.stPalck = 7;
            this.igralec = 1;
        }//Konec Konstruktor Palcke

        public int StPalck { get => stPalck; }

        public bool VzemiPalcke() {
            Console.Write("Vnesi stevilo palčk, ki jih želite vzeti: ");
            int stVzetihPalck = int.Parse(Console.ReadLine());
            if (stVzetihPalck >= 1 && stVzetihPalck <= 3) {
                igralec = 3 - igralec;
                stPalck -= stVzetihPalck;
                return true;
            } else {
                return false;
            }//Konec if-else
        }//Konec metoda VzemiPalcke

        public bool KonecIgre() {
            if (stPalck <= 0) {
                return true;
            } else {
                return false;
            }//Konec if-else
        }//Konec metode KonecIgre

        public void DobiZmagovalca() {
            if (stPalck < 1) {
                Console.WriteLine("\nZmagal je igralec: " +igralec + ".");
            }//Konec if
        }//Konec metode DobiZmagovalca

        public void Izpis() {
            Console.Write("Na mizi je še " +stPalck +" palčk");
            Console.WriteLine("\tNa vrsti je igralec: " + igralec);
        }

        public static void Main(string[] args) {
            Palcke p = new Palcke();

            while (p.KonecIgre() != true) { 
                p.Izpis();
                p.VzemiPalcke();
                p.DobiZmagovalca();
            }//Konec while
        }//Konec Main
    }//Konec class Palcke
}
