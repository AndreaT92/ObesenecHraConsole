namespace Obesenec
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Slovo slovo = new Slovo(); // inicializace třídy slovo
            Hrac hrac = new Hrac(5); // incializace třídy hráče s tím, že počet životů nastavíme na 5

            slovo.VymysliNoveSlovo(); 
            int pocetPismen = slovo.PocetPismen();
            Console.WriteLine($"Vítám tě u hry Oběšenec. Myslím si slovo. Hádej počet písmen: {pocetPismen}");

            while (!hrac.JeKonecHry())
            {
                slovo.VratSlovo();
                hrac.ZadejPismeno(slovo);

                if (slovo.TrefilVsechny())
                {
                    Console.WriteLine($"Gratuluji, uhádl jsi slovo {slovo.VratHadaneSlovo()}!");
                    break;
                }
            }

            if (hrac.JeKonecHry())
            {
                Console.WriteLine($"Bohužel, vyčerpal jsi všechny životy. Správné slovo bylo: {slovo.VratHadaneSlovo()}");
            }
        }
    }
}
