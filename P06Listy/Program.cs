using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P06Listy
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] tab1 = new string[4];

            List<string> lista1 = new List<string>();

            lista1.Add("jan");
            lista1.Add("ala");

            lista1[lista1.Count - 1] = "lukasz";

            lista1.Insert(1, "ola");

            lista1.RemoveAt(1);

            lista1.Remove("jan"); // usuwa pierwszego napotkanego jana

           // lista1.RemoveAll()


        }
    }
}
