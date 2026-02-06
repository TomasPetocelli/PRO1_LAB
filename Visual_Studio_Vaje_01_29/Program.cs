internal class Program {
    private static void Main(string[] args) {

        /*====================================
                       TABELE
       ====================================*/

        ////Deklaracija in inicializacija tabele
        //int[] tab = new int[5];

        ////Vnos vrednosti v tabelo
        //for (int i = 0; i < tab.Length; i++) {
        //    Console.Write("Vnesi število: ");
        //    tab[i] = int.Parse(Console.ReadLine());
        //}

        ////Izpis vrednosti iz tabele
        //for (int i = 0; i < tab.Length; i++) {
        //    Console.Write(tab[i] + " ");
        //}

        //---------------RAZLIKA MED TABELE IN NIZ-i---------------
        //int[] tab = { 1, 2, 3, 4, 5 };
        //string niz = "Višja šola";

        ////Pridobivanje vrednosti
        //int element = tab[2]; // 3
        //char znak = niz[2];

        ////spreminjanje vrednosti
        //tab[1] = 10; //{1,10,3,4,5}
        ////niz[5] = 'X' //NAPAKA!!!!!!

        //---------------NALOGA 10.1: POVPREČNA TEMPERATURA---------------
        //double[] meseci = new double[12];
        //double letnoPovp = 0;

        //for (int i = 0; i < meseci.Length; i++) {
        //    Console.Write("Povprečna temperatura za " + (i+1) + ", mesec: ");
        //    meseci[i] = double.Parse(Console.ReadLine());
        //    letnoPovp = letnoPovp + meseci[i];
        //}

        //letnoPovp = Math.Round(letnoPovp / 12, 2);
        //Console.WriteLine("\nPovprečna letna temperatura: " + letnoPovp);
        //Console.WriteLine("\nMrzli meseci: ");

        //for (int i = 0; i < meseci.Length; i++) {
        //    if (meseci[i] < letnoPovp) {
        //        Console.WriteLine((i +1) + ". mesec");
        //    }
        //}

        //---------------NALOGA 10.2: VREJANJE VREDNOSTI V TABELI---------------
        //Console.Write("Vnesi velikost tabele: ");
        //int n = int.Parse(Console.ReadLine());

        //int[] tab = new int[n];

        //for (int i = 0; i < tab.Length; i++) {
        //    Console.Write("Vnesi vrednost: ");
        //    tab[i] = int.Parse(Console.ReadLine());
        //}

        //for (int i = 0; i < tab.Length; i++) {
        //    Console.Write(tab[i]);
        //}

        //for (int i = 0; i < tab.Length; i++) {
        //    int min = tab[i];
        //    int indeks = i;
        //    for (int j = i + 1; j < tab.Length; j++) {
        //        if (tab[j] < min) {
        //            min = tab[j];
        //            indeks = j;
        //        }
        //    }// Konec for j
        //    int pomozna = tab[i];
        //    tab[i] = tab[indeks];
        //    tab[indeks] = pomozna;
        //}// Konec for i

        //Console.WriteLine();
        //for (int i = 0; i < tab.Length; i++) {
        //    Console.Write(tab[i]);
        //}

        //---------------NALOGA 10.3: 2D TABELA---------------
        //int[,] tab = new int[10, 10];

        //int max = 9;
        //int vsota = 0;

        //Random r = new Random();

        //for (int i = 0; i < 10; i++) {
        //    for (int j = 0; j < 10; j++) {
        //        tab[i, j] = r.Next(10, 100);
        //        Console.Write(tab[i, j] + " ");

        //        if (tab[i,j] > max) {
        //            max = tab[i, j];
        //        }
        //        vsota += tab[i, j];
        //    }
        //    Console.WriteLine();
        //}
        //Console.WriteLine("\nMaksimalen element je: " +max);
        //Console.WriteLine("Vsota vseh elementov: " +vsota);

        //Console.WriteLine("\nDiagonala - Leva");
        //for (int i = 0; i < 10; i++) {
        //    for (int j = 0; j < 10; j++) {
        //        if (i == j) {
        //            Console.Write(tab[i,j] + " ");
        //        } else {
        //            Console.Write(" " + " ");
        //        }
        //    }
        //    Console.WriteLine();
        //}

        //Console.WriteLine("\nDiagonala - Desna");
        //for (int i = 0; i < 10; i++) {
        //    for (int j = 0; j < 10; j++) {
        //        if (i+j == 9) {
        //            Console.Write(tab[i, j] + " ");
        //        } else {
        //            Console.Write(" " + " ");
        //        }
        //    }
        //    Console.WriteLine();
        //}

        //---------------NALOGA 10.4---------------
        char[,] tab = new char[5, 5];
        Random r = new Random();

        char min = 'z';

        for (int i = 0; i < 5; i++) {
            for (int j = 0; j < 5; j++) {
                tab[i, j] = (char)(r.Next(26) + 97);
                Console.Write(tab[i, j] + " ");

                if (tab[i, j] < min) {
                    min = tab[i, j];
                }
            }
            Console.WriteLine();
        }

        Console.WriteLine("Najmanjši znak: " + min);

    }// Konec Main
}

