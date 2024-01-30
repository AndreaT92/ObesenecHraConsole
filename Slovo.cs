namespace Obesenec
{
    internal class Slovo
    {
        private string[] seznamSlov = new string[] { "prase", "kočka", "vlak", "program", "víno", "počítač" };
        private string hadaneSlovo;
        private char[] castecneOdhaleneSlovo;

        public void VymysliNoveSlovo() // výběr hádaného slova ze seznamu a nastavení místo písmen _ 
        {
            Random nahodnyVyber = new Random();
            hadaneSlovo = seznamSlov[nahodnyVyber.Next(0, seznamSlov.Length)];
            castecneOdhaleneSlovo = new char[hadaneSlovo.Length];
            for (int i = 0; i < hadaneSlovo.Length; i++)
            {
                castecneOdhaleneSlovo[i] = '_';
            }
        }

        public int PocetPismen() // metoda, která vrací počet písmen ve slově
        {
            return hadaneSlovo.Length;
        }

        public bool JePismenoObsazeneVeSlove(char pismeno) // bool na kontrolu písmena ve slově
        {
            bool obsahujePismeno = false;

            for (int i = 0; i < hadaneSlovo.Length; i++)
            {
                if (hadaneSlovo[i] == pismeno)
                {
                    obsahujePismeno = true;
                    castecneOdhaleneSlovo[i] = pismeno; // odhalí písmeno v částečně odhaleném slově
                }
            }

            return obsahujePismeno;
        }

        public void VratSlovo() // metoda, která vypíše na consoli hádané slovo (____ nebo s částečně odhalenými písmeny)
        {
            Console.WriteLine("Hádané slovo: " + new string(castecneOdhaleneSlovo));
        }

        public char[] VratCastecneOdhaleneSlovo() // vrací částečně odhalené slovo
        {
            return castecneOdhaleneSlovo;
        }

        public string VratHadaneSlovo() // vrací hádané slovo
        {
            return hadaneSlovo;
        }
    }
}

