using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P11TablicaTablic
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] tablicaJednoWymiarowa = new string[3];
            string[,] tablicaDwuWymiarowa = new string[3, 2];

            string[][] tablicaTablic = new string[4][];

            tablicaTablic[0] = new string[2];
            tablicaTablic[1] = new string[3];
            tablicaTablic[2] = new string[1];


            tablicaTablic[0][0] = "A";
            tablicaTablic[0][1] = "B";

            tablicaTablic[1][0] = "C";
            tablicaTablic[1][1] = "D";
            tablicaTablic[1][2] = "E";

            tablicaTablic[2][0] = "F";



        }
    }
}
