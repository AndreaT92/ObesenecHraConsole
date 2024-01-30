namespace Obesenec
{
    internal class Hrac
    {
        private int pocetZivotu;

        public Hrac(int pocetZivotu) // konstruktor s parametrem počet životů
        {
            this.pocetZivotu = pocetZivotu;
        }

        public void ZadejPismeno(Slovo slovo) // metoda na čtení zadaného písmena
        {
            Console.Write("Zadej písmeno: ");
            char hadanePismeno = Console.ReadKey().KeyChar;
            Console.WriteLine(); 

            bool spravne = slovo.JePismenoObsazeneVeSlove(hadanePismeno); // kontrola, zda je pismeno obsaženo v hádaném slově

            if (!spravne) // odebrání počtu životů, pokud písmeno není ve slově
            {
                pocetZivotu--;
                Console.WriteLine($"Špatně! Zbývající počet životů: {pocetZivotu}");
            }
            else // písmeno je ve slově
            {
                Console.WriteLine("Správně!");
            }
        }

        public bool JeKonecHry() // bool, který vrací true, pokud došly životy
        {
            return pocetZivotu <= 0;
        }
    }
}
