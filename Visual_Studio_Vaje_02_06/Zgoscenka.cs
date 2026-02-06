using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Visual_Studio_Vaje_02_06 {
    internal class Zgoscenka {
        public string avtor;
        public string naslov;
        public Pesem[] seznamPesmi;
        
        public Zgoscenka(string avtor, string naslov, Pesem[] seznam) {
            this.avtor = avtor;
            this.naslov = naslov;
            this.seznamPesmi = new Pesem[seznam.Length];

            for (int i = 0; i < seznam.Length; i++) {
                this.seznamPesmi[i] = new Pesem(seznam[i].naslov, seznam[i].minute, seznam[i].sekunde);
            }//Konec for
        }//Konec konstruktor Zgoscenka

        public int Dolzina() {
            int dolzina = 0;
            for (int i = 0; i < seznamPesmi.Length; i++) {
                dolzina = dolzina + seznamPesmi[i].minute * 60 + seznamPesmi[i].sekunde;
            }//Konec for
            return dolzina;
        }//konec Dolzina

        public static void Main(string[] args) {
            Zgoscenka cd = new Zgoscenka("Siddharta", "Na soncu", new Pesem[] { new Pesem("Na soncu", 3, 10), new Pesem("Pesem 2", 4, 0), new Pesem("Pesem 3", 2, 58) });
            Console.WriteLine("CD skupine: " +cd.avtor +"\nNaslov albuma: " +cd.naslov);

            Console.WriteLine("Pesmi: ");
            for (int i = 0; i < cd.seznamPesmi.Length; i++) { 
                Console.WriteLine(cd.seznamPesmi[i].naslov);
            }//Konec for
            Console.WriteLine("Dolzina pesmi: " + cd.Dolzina() + "sekund");

        }//Konec Main
    }//Konec class Zgoscenka
}
