using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Obesenec
{
    internal class Slovo
    {
        private string[] seznamSlov = new string[] {"prase", "kočka", "vlak", "program", "víno", "počítač"};
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

        public void VratSlovo()
        {
            //metoda na ReadKey + cyklus a zobrazovani uhadnutych pismen do slova
        }
        
    }
}
