internal class Program {
    private static void Main(string[] args) {
        /*====================================
                 PODATKOVNI TIP - CHAR
        ====================================*/

        //---------------NALOGA 9.1---------------
        //Random geslo = new Random();

        //int stevka1 = geslo.Next(10);
        //int stevka2 = geslo.Next(10);

        //char crka1 = (char)geslo.Next('A', 'Z' + 1);
        //char crka2 = (char)geslo.Next('A', 'Z' + 1);
        //char crka3 = (char)geslo.Next('A', 'Z' + 1);

        //int stevka3 = geslo.Next(10);

        //int stevilo = geslo.Next(100, 1000);

        //Console.WriteLine("Geslo: " +stevka1 +stevka2 +crka1 +crka2 +crka3 +stevka3 +stevilo);

        /*====================================
                 PODATKOVNI TIP - STRING
        ====================================*/

        //string niz = "Ljubljana";
        //Console.WriteLine("Niz: " +niz);

        //char znak = niz[5];
        //Console.WriteLine("Znak[5]: " +znak);

        //for (int i = 0; i < niz.Length; i++) {
        //    if (i % 2 == 0)
        //        Console.Write(niz[i] + " ");
        //}
        //Console.WriteLine();

        ////------------------------------------------------
        //string niz1 = "danes";
        //string niz2 = "banes";

        //bool enakost = niz1.Equals(niz2);

        //Console.WriteLine(enakost);
        ////--------------------
        //int primerjava = String.Compare(niz1, niz2);

        //Console.WriteLine(primerjava);

        //---------------NALOGA 9.2---------------
        Console.WriteLine("Vnesi niz: ");
        string niz = Console.ReadLine();

        string samoglasniki = "aAeEiIoOuU";
        string novNiz = "";

        for (int i = 0; i < niz.Length; i++) {
            char znak = niz[i];

            if (samoglasniki.IndexOf(znak) != -1) {
                novNiz = novNiz + '*';
            } else {
                novNiz = novNiz + znak;
            }
        }

        Console.WriteLine("Spremenjeni niz: " + novNiz);
    }
}

