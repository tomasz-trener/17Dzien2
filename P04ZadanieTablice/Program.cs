using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P04ZadanieTablice
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] imiona = new string[100];

            string imie;
            int i = 0;
            do
            {
                imie = Console.ReadLine();
                imiona[i] = imie;
                i++;
            } while (imie!= "koniec");

            // teraz wyswietlamy 
            for (int j = 0; j < i-1; j++)
                if (imiona[j].Length>3)
                    Console.WriteLine($"{imiona[j]} ({imiona[j].Length})");

            Console.ReadKey();
        }
    }
}
