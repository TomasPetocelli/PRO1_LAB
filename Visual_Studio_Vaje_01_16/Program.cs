internal class Program {
    //DEKLARACIJA

    enum Predmeti1 {
        PRO1,
        ROM,
        ZBP1,
        PRO2,
        ZBP2
    }

    enum Predmeti2 {
        PRO1 = 10,
        ROM = 8,
        ZBP1 = 7,
        PRO2 = 5,
        ZBP2 = 9
    }

    private static void Main(string[] args) {
        /*====================================
                    ENUM
        ====================================*/

        //Console.WriteLine("Pozicija ROM: " +(int)Predmeti2.ROM);

        /*====================================
                    BRANJE PODATKOV
        ====================================*/

        //Console.WriteLine("Vnesi stavek: ");
        //string stavek = Console.ReadLine();
        //Console.WriteLine("Prebrani stavek: "+stavek);

        //Console.WriteLine("Vnesi poljubno celo število: ");
        //int stevilo = int.Parse(Console.ReadLine());
        //// ALI -> int stevilo = Convert.ToInt32(Console.ReadLine())
        //Console.WriteLine("Prebrano število: "+stevilo);

        /*====================================
                    POGOJNI STAVKI
        ====================================*/

        //---------------POGOJNI STAVEK IF - NALOGA 1: PRESTOPNO LETO---------------
        //Prestopno leto = deljivo s 4 in NI deljivo s 100 ALI ko je deljivo s 400

        //Console.WriteLine("Vpiši leto: ");
        //int leto = int.Parse(Console.ReadLine());

        //if ((leto % 4 == 0) && (leto % 100 != 0) || (leto % 400 == 0)) {
        //    Console.WriteLine("Leto je prestopno.");
        //} else {
        //    Console.WriteLine("Leto ni prestopno.");
        //}

        //---------------GNEZDENI STAVEK IF - NALOGA 2: INDEX TELESNE MASE---------------
        //double itm; //Index Telesne Mase

        //Console.WriteLine("Vnesi maso (v kg): ");
        //double masa = double.Parse(Console.ReadLine());

        //Console.WriteLine("Vnesi višino (v m): ");
        //double visina = double.Parse(Console.ReadLine());

        //itm = masa / (visina * visina);

        //if (itm < 18.5) {
        //    Console.WriteLine("Premajhna telesna teža.");
        //}
        //else if (itm < 25) {
        //    Console.WriteLine("Normalna telesna teža.");
        //}
        //else {
        //    Console.WriteLine("Čezmerna telesna teža.");
        //}

        //---------------STAVEK SWITCH - NALOGA 4: OCENE---------------
        //Console.WriteLine("Vnesi oceno (5-10): ");
        //int ocena = int.Parse(Console.ReadLine());

        //switch (ocena) {
        //    case 5: Console.WriteLine("Nezadostno"); break;
        //    case 6: Console.WriteLine("Zadostno"); break;
        //    case 7: Console.WriteLine("Dobro"); break;
        //    case 8: case 9: Console.WriteLine("Prav dobro"); break;
        //    case 10: Console.WriteLine("Odlično"); break;
        //    default: Console.WriteLine("Nisi pravilno vnesel ocene"); break;
        //}
        /*==================================================================
                                    Skrajšani IF
                    spremenljivka = (pogoj) ? stavekTrue : stavekFalse;
        ==================================================================*/

        //---------------NALOGA 7: STRANICE TRIKOTNIKA---------------
        //Console.WriteLine("Vnesi stranico a: ");
        //int stranica_a = int.Parse(Console.ReadLine());

        //Console.WriteLine("Vnesi stranico b: ");
        //int stranica_b = int.Parse(Console.ReadLine());

        //Console.WriteLine("Vnesi stranico c: ");
        //int stranica_c = int.Parse(Console.ReadLine());

        //if (((stranica_a + stranica_b) > stranica_c) && ((stranica_a + stranica_c) > stranica_b) && ((stranica_b + stranica_c) > stranica_a)) {
        //    Console.WriteLine("So stranice trikotnika: ");
        //} else {
        //    Console.WriteLine("Niso stranice trikotnika: ");
        //}

        //---------------NALOGA 8: TEMPERATURA VODE---------------
        //Console.WriteLine("Vnesi temperaturo vode (5-100): ");
        //int temperaturaVode = int.Parse(Console.ReadLine());

        //if (temperaturaVode <= 10) {
        //    Console.WriteLine("Zelo mrzla");
        //} else if (temperaturaVode > 10 && temperaturaVode <= 20) {
        //    Console.WriteLine("Hladna");
        //} else if (temperaturaVode > 20 && temperaturaVode <= 30) {
        //    Console.WriteLine("Topla");
        //} else if (temperaturaVode > 30 && temperaturaVode <= 50) {
        //    Console.WriteLine("Vroča");
        //} else if (temperaturaVode > 50) {
        //    Console.WriteLine("Zelo Vroča");
        //}

        //---------------NALOGA 9: SWITCH STAVEK---------------
        //Console.WriteLine("Vnesi poljubno cifro: ");
        //int cifra = Convert.ToInt16(Console.ReadLine());

        //switch (cifra) {
        //    case 3: Console.WriteLine("Cifra = 3"); break;
        //    case 6: case 7: case 8: case 9: Console.WriteLine("Cifra je med 5 in 10"); break;
        //    default: Console.WriteLine("Nisi vnesel cifre!"); break;
        //}

        /*====================================
                    ZANKE
        ====================================*/

        //---------------WHILE ZANKA - NALOGA 10: RAČUN VSOTA N ČLENOV ZAPOREDJA---------------
        //Console.WriteLine("Vnesi število členov zaporedja: ");
        //int stClenov = int.Parse(Console.ReadLine());
        //int n = 1;
        //int vsota = 0;

        //while (n <= stClenov) {
        //    int clen = (n + 1) * (n - 1);
        //    Console.WriteLine(clen + " ");

        //    vsota = vsota + clen;

        //    n++;
        //}
        //Console.WriteLine("Vsota: " +vsota);

        //---------------WHILE ZANKA - NALOGA 11: OCENE PREDMETOV---------------
        Console.Write("Vnesi število predmetov: ");
        int stPredmetov = int.Parse(Console.ReadLine());

        int vsota = 0;
        int stevec = 1;
        int najnizja = 10;
        int najvisja = 1;

        while (stevec <= stPredmetov) {
            Console.Write("Vnesi oceno: ");
            int ocena = int.Parse(Console.ReadLine());

            vsota = vsota + ocena;

            if (ocena > najvisja) {
                najvisja = ocena;
            } else {
                najnizja = Math.Min(najnizja, ocena);
            }

            stevec++;
        }

        double povprecje = (double)vsota / stPredmetov;
        Console.WriteLine("Povprečje ocen: " + povprecje);
        Console.WriteLine("Zaokroženo povprečje ocen: " + (int)(povprecje + 0.5));
        Console.WriteLine("Najnižja ocena: " + najnizja);
        Console.WriteLine("Najvišja ocena: " + najvisja);

    }
}

