using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Visual_Studio_Vaje_02_12 {
    internal class Banka {
        double glavnica, obresnaMera, stLet;

        public Banka(double glavnica, double obresnaMera, double stLet) {
            this.glavnica = glavnica;
            this.obresnaMera = obresnaMera;
            this.stLet = stLet;
        }//Konec konstruktor Banka

        public double LetneObresti() {
            return (glavnica * Math.Pow(1 + obresnaMera, stLet));
        }//Konec LetneObresti

        public double DnevneObresti() {
            return (glavnica * Math.Pow(1 + obresnaMera / 365, stLet * 365));
        }//Konec DnevneObresti

        static void Main(string[] args) {
            Console.Write("Vnesi glavnico: ");
            double glavnica = double.Parse(Console.ReadLine());

            Console.Write("Vnesi obrestno mero: ");
            double obrestnaMera = double.Parse(Console.ReadLine()) / 100.0;

            Console.Write("Vnesi število let: ");
            double stLet = double.Parse(Console.ReadLine());

            Banka b = new Banka(glavnica, obrestnaMera, stLet);

            Console.WriteLine("Letne obresti:  " + b.LetneObresti());
            Console.WriteLine("Dnevne obresti: " + b.DnevneObresti());

        }//Konec Main
    }//Konec class Banka
}
