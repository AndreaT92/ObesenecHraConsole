namespace Obesenec
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Slovo slovo = new Slovo();
            slovo.VymysliNoveSlovo();
            int pocetPismen = slovo.PocetPismen();
            Console.WriteLine($"Vítám tě u hry Oběšenec. Myslím si slovo. Hádej počet písmen: {pocetPismen}");
            // cyklus dokud nebudou uhadnuta vsechna pismena
        }
    }
}
