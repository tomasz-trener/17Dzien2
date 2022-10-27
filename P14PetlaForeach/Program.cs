using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P14PetlaForeach
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // kolekcja to zbiór elementów 

            string[] tab = { "ala", "ma", "kota" };
            List<string> lista = new List<string>() { "ala", "ma", "kota" };

            for (int i = 0; i < tab.Length; i+=2)
            {
                Console.WriteLine(tab[i]);
            }

            for (int i = tab.Length-1; i >= 0; i--)
            {
                Console.WriteLine(tab[i]);
            }

            foreach (var e in tab)
            {
                Console.WriteLine(e);
            }









        }
    }
}
