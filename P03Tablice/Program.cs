using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P03Tablice
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string miasto1 = "kraków";
            string miasto2;
            string miasto3;

            string[] miasta = new string[3];

            miasta[0] = "warszawa";
            miasta[1] = miasto1;

            // co jest w komórka [2] ?
            // co jest w komórka [3] ?
            // miasta[3] = "ala";

            Console.WriteLine(miasta[2]);

            int?[] liczby = new int?[3];

            bool[] wartosciLogiczne = new bool[4];


            int[] liczby2 = { 4, 6, 7, 2 };
            string[] miasta2 = { "Kraków", "Warszawa", "Wrocław" };

            int[] liczby3 = new int[3]
            {
                4,6,3
            };

            Console.ReadKey();
        }
    }
}
