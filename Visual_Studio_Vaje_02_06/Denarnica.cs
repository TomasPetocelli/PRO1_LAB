using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Visual_Studio_Vaje_02_06 {
    internal class Denarnica {
        public string ime;
        public double stanje;

        public Denarnica(string ime, double stanje) {
            this.ime = ime;
            this.stanje = stanje;
        }//Konec konstruktor Denarnica

        public void Dvig(double znesek) {
            stanje = stanje - znesek;
        }//Konec Dvig

        public void Polog(double znesek) {
            stanje = stanje + znesek;
        }//Konec Polog
        public static void Main(string[] args) {
            Denarnica Peter = new Denarnica("Peter", 1000);
            Console.WriteLine("Peter - začetno stanje: " + Peter.stanje);
            Peter.Dvig(500);
            Console.WriteLine("Peter - po dvigu: " + Peter.stanje);
            Peter.Polog(100);
            Console.WriteLine("Peter - po pologu: " + Peter.stanje);

        }//Konec Main
    }//Konec class Denarnica
}
