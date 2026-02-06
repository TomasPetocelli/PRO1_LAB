internal class Program {
    private static void Main(string[] args) {

        /*====================================
                        ZANKA FOR
        ====================================*/

        //---------------NALOGA 8.3---------------
        //int najmanjse = Int32.MaxValue;

        //for (int i = 1; i <=10; i++) {
        //    Console.Write("Vnesi število: ");
        //    int stevilo = int.Parse(Console.ReadLine());

        //    if (stevilo < najmanjse) {
        //        najmanjse = stevilo;
        //    }
        //}

        //Console.WriteLine("Najmanjše število je: " + najmanjse);

        //---------------NALOGA 8.4: IZRIS PRAVOKOTNIKA---------------
        //Console.Write("Vnesi višino pravokotnika: ");
        //int vrstica = int.Parse(Console.ReadLine());

        //Console.Write("Vnesi širino pravokotnika: ");
        //int stolpec = int.Parse(Console.ReadLine());

        //for (int i = 1; i<= vrstica; i++) {
        //    for (int j = 1; j <= stolpec; j++) {
        //        Console.Write("*");
        //    }
        //    Console.WriteLine();
        //}

        /*====================================
             GENERIRANJE NAKLJUČNIH ŠTEVIL
         ====================================*/

        //---------------NALOGA 8.5: GENERIRANJE NAKLUČNIH ŠTEVIL---------------
        //Random r = new Random();

        //int vsota = 0;

        //for (int i = 1; i <= 100; i++) {
        //    int stevilo = r.Next(100); //med 0 in 99
        //    vsota = vsota + stevilo;
        //}

        //Console.WriteLine("Vsota: " + vsota);

        //---------------NALOGA 8.6: UGIBANJE NAKLUČNEGA ŠTEVILA---------------
        //Random zreb = new Random();

        //int naklucno = zreb.Next(1, 101);
        //int stevecPoskusov = 0;

        //while (true) {
        //    Console.Write("Ugibaj število: ");
        //    int stevilo = int.Parse(Console.ReadLine());

        //    stevecPoskusov++;
        //    if (stevilo == naklucno) {
        //        Console.Write("Bravo, ugnail si število! ");
        //        break;
        //    } else if (stevilo > naklucno) {
        //        Console.WriteLine("Število je preveliko");
        //        continue;
        //    } else {
        //        Console.WriteLine("Število je premajhno");
        //        continue;
        //    }
        //}

        //Console.WriteLine("Ugibal si " + stevecPoskusov + " krat");

        //---------------NALOGA 8.7: RULETA---------------
        Console.WriteLine("-------------------RULETA-------------------");

        Console.Write("Vnesi začetno stanje: ");
        int zacetnoStanje = int.Parse(Console.ReadLine());

        Console.Write("Vnesi začetno stavo: ");
        int zacetnaStava = int.Parse(Console.ReadLine());

        Random r = new Random();
        int trenutnoStanje = zacetnoStanje;
        int trenutnaStava = zacetnaStava;
        int max = trenutnoStanje, min = trenutnoStanje;

        for (int i = 1; i <= 10; i++) {
            int met = r.Next(37);

            if (met % 2 == 0 || met == 0) {
                trenutnoStanje = trenutnoStanje + trenutnaStava;
                trenutnaStava = zacetnaStava;
                Console.WriteLine("Met " + i + ": rdeča, stanje: " + trenutnoStanje);

                if (trenutnoStanje > max) {
                    max = trenutnoStanje;
                }
            } else {
                trenutnoStanje = trenutnoStanje - trenutnaStava;
                trenutnaStava = trenutnaStava * 2;
                Console.WriteLine("Met " + i + ": črna, stanje: " + trenutnoStanje);
                if (trenutnoStanje < min) {
                    min = trenutnoStanje;
                }
            }
        }

        Console.WriteLine("Najvišje stanje: " + max);
        Console.WriteLine("Najnižje stanje: " + min);
        Console.WriteLine("Dobiček / Izguba: " + (trenutnoStanje - zacetnoStanje));


        /*====================================
                     BREAK in CONTINUE
         ====================================*/

        //some code

        /*====================================
                    ZANKA FOR EACH
        ====================================*/

        //some code

    }
}

