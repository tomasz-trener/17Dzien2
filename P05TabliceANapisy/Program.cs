using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P05TabliceANapisy
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // SPLIT - rozdzielanie
            string napis = "ala ma kota";

            string[] wyrazy = napis.Split(' ');


            string napis2 = "ala!%ma**kota";

            string[] separatory = { "!%", "**" };

            string[] wyrazy2 = napis2.Split(separatory, StringSplitOptions.RemoveEmptyEntries);

            // JOIN - łączenie

            string[] tablica = { "jan", "ola", "adam" };

            string wynik = string.Join(" - ", tablica);
        }
    }
}
