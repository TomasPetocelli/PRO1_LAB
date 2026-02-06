using System;

internal class Program {
    private static void Main(string[] args) {
        //---------------NALOGA 10.4---------------
        //int[] tab = new int[10];
        //int max = -1;
        //int min = 1000000;

        //int vsota = 0;
        //double povprecnoVrednost = 0;

        ////Vnos vrednosti v tabelo
        //for (int i = 0; i < tab.Length; i++) {
        //    Console.Write("Vnesi število " + (i+1) + ": ");
        //    tab[i] = int.Parse(Console.ReadLine());

        //    if (tab[i] > max) {
        //        max = tab[i];
        //    } 

        //    if (tab[i] < min) {
        //        min = tab[i];
        //    }

        //    vsota += tab[i];

        //}//Konec For zanke

        //Console.WriteLine("Najmanjši elemet v tabeli: " + min);
        //Console.WriteLine("Največji elemet v tabeli: " + max);

        //Console.WriteLine("\nVsota: " + vsota);

        //povprecnoVrednost = (double)vsota / 10;
        //Console.WriteLine("Povprečna vrednost: " + povprecnoVrednost);

        /*====================================
                      EXCEPTIONS
        ====================================*/

        //try {
        //    Console.Write("Vnesi prvo število: ");
        //    int a = int.Parse(Console.ReadLine());

        //    Console.Write("Vnesi drugo število: ");
        //    int b = int.Parse(Console.ReadLine());

        //    int rezultat = a / b;

        //    Console.WriteLine("\nRezultat deljenja: " + rezultat);

        //} catch (DivideByZeroException) {
        //    Console.WriteLine("\nNapaka deljenje z 0");
        //} finally {
        //    Console.WriteLine("\nIzjema");
        //}

        /*====================================
                      METODE
        ====================================*/

        //PozdravUporabniku();

        //double rez = Povprecje(5, 10);
        //Console.WriteLine("Rezultat: " + rez); //ali
        //Console.WriteLine("Rezultat: " + Povprecje(5,10));

        //---------------NALOGA 12.1---------------
        //Console.WriteLine("Rezultat: " + VsotaDvomestnih());

        //---------------NALOGA 12.2---------------
        //int[] ocene = new int[10];

        //for (int i = 0; i < ocene.Length; i++) {
        //    Console.Write("Vnesi " + (i+1) + ". oceno: ");
        //    ocene[i] = int.Parse(Console.ReadLine());
        //}
        //Console.WriteLine("\nPovprečje ocen: " + PovprecjeOcen(ocene));
        //Console.WriteLine("Najnižja ocena: " + MinOcena(ocene));
        //Console.WriteLine("Najvišja ocena: " + MaxOcena(ocene));

        //---------------NALOGA 12.3: KALKULATOR---------------
        Console.WriteLine("Vnesi vrednosti in znak za operacijo \n------------------------------------");

        Console.Write("Vnesi prvo vrednost: ");
        double a = double.Parse(Console.ReadLine());

        Console.Write("Vnesi operacijo (+,-,*,/): ");
        string o = Console.ReadLine();

        Console.Write("Vnesi drugo vrednost: ");
        double b = double.Parse(Console.ReadLine());

        switch (o) {
            case ("+"): Console.WriteLine("Rezultat: " + Setstevanje(a, b)); break;
            case ("-"): Console.WriteLine("Rezultat: " + Odstevanje(a, b)); break;
            case ("*"): Console.WriteLine("Rezultat: " + Mnozenje(a, b)); break;
            case ("/"): Console.WriteLine("Rezultat: " + Deljenje(a, b)); break;
            default: Console.WriteLine("\nNapaka pri vnosu!\n"); break;
        }

    }//Konec Main

    public static void PozdravUporabniku() {
        Console.Write("Vnesi ime: ");
        string ime = Console.ReadLine();
        Console.WriteLine("Pozdravljen " + ime + ".");
    }//Konec PozdravUporabniku

    public static double Povprecje(double a, double b) {
        return (a + b) / 2.0;
    }//Konec Povprecje

    //---------------NALOGA 12.1---------------
    public static int VsotaDvomestnih() {
        int vsota = 0;
        for (int i = 10; i < 100; i++) {
            if (i % 5 == 0) {
                vsota = vsota + i;
            }
        }
        return vsota;
    }//Konec VsotaDvomestnih

    //---------------NALOGA 12.2---------------
    public static double PovprecjeOcen(int[] tab) {
        int vsota = 0;
        for (int i = 0; i < tab.Length; i++) {
            vsota += tab[i];
        }
        return (double)vsota / tab.Length;
    }

    public static int MinOcena(int[] tab) {
        int min = tab[0];

        for (int i = 1; i < tab.Length; i++) {
            min = Math.Min(min, tab[i]);
        }
        return min;
    }

    public static int MaxOcena(int[] tab) {
        int max = tab[0];

        for (int i = 1; i < tab.Length; i++) {
            max = Math.Max(max, tab[i]);
        }
        return max;
    }

    //---------------NALOGA 12.3: KALKULATOR---------------
    public static double Setstevanje(double a, double b) {
        double rezultat = a + b;
        return rezultat;
    }

    public static double Odstevanje(double a, double b) {
        double rezultat = a - b;
        return rezultat;
    }

    public static double Mnozenje(double a, double b) {
        double rezultat = a * b;
        return rezultat;
    }

    public static double Deljenje(double a, double b) {
        double rezultat = a / b;
        return rezultat;
    }


}//Konec class Program 

