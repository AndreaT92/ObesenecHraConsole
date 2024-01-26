using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Obesenec
{
    internal class Slovo
    {
        private string[] seznamSlov = new string[] {"prase", "kočka", "vlak", "program", "víno", "počítač"}; // seznam slov, ze kterých vybírá
        private string hadaneSlovo;
        private char[] castecneOdhaleneSlovo;

        public Slovo()
        {
            VymysliNoveSlovo();
        }

        public void VymysliNoveSlovo ()
        {
            Random nahodnyVyber = new Random();
            hadaneSlovo = seznamSlov[nahodnyVyber.Next(0, seznamSlov.Length)];
        }

        public int PocetPismen()
        { 
            return hadaneSlovo.Length; 
        }
        //metoda bool JePismenoObsazeneVeSlove par pismeno
        //metoda na ReadKey?
        
        public void VratSlovo()
        {
            string slovo = hadaneSlovo;
            char [] poleZnakuSlova = slovo.ToArray();
            char hadanePismeno;
            string castecneOdhaleneSlovo = "";
            for (int i = 0; i < poleZnakuSlova.Length; i++)
            {
                if (hadanePismeno == poleZnakuSlova[i])
                {
                    castecneOdhaleneSlovo += hadanePismeno();
                }
            }
            // vrat castecneodhaleneslovo (-----) a postupne se to bude doplnovat pismenky
        }
        
    }
}
