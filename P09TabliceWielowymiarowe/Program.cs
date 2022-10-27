using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P09TabliceWielowymiarowe
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] tablicaJednoWym = new string[3];

            string[,] tablicaDwuWym = new string[4, 2];

            string[,,] tablicaTrzyWym = new string[4, 2, 2];

            tablicaTrzyWym[0, 0, 0] = "a";
            tablicaTrzyWym[0, 0, 1] = "b";

            int dlugosc =  tablicaTrzyWym.Length; // 16

            tablicaTrzyWym.GetLength(1); // dlugosc wymiaru drugiego z kolei (środkowego)
            // ----------------


            tablicaDwuWym[0, 0] = "A";
            tablicaDwuWym[0, 1] = "B";

            tablicaDwuWym[1, 0] = "C";
            tablicaDwuWym[1, 1] = "D";

            tablicaDwuWym[2, 0] = "E";
            tablicaDwuWym[2, 1] = "F";

            tablicaDwuWym[3, 0] = "G";
            tablicaDwuWym[3, 1] = "H";

            Console.WriteLine("---- sposób 1 -----");

            for (int i = 0; i < tablicaDwuWym.GetLength(0); i++)
            {
                for (int j = 0; j < tablicaDwuWym.GetLength(1); j++)
                    Console.Write(tablicaDwuWym[i,j] + " ");

                Console.WriteLine();
            }

            Console.WriteLine("---- sposób2  -----");
            
            for (int i = 0; i < tablicaDwuWym.GetLength(1); i++)
            {
                for (int j = 0; j < tablicaDwuWym.GetLength(0); j++)
                    Console.Write(tablicaDwuWym[j, i] + " ");

                Console.WriteLine();
            }


            Console.ReadKey();

        }
    }
}
