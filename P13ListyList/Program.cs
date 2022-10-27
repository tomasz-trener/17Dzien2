using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P13ListyList
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> lista = new List<string>();

            List<List<string>> listaList = new List<List<string>>();

            List<List<List<string>>> listaListList = new List<List<List<string>>>();


            listaList.Add(new List<string>());
            listaList[0].Add("A");
            listaList[0].Add("B");

            listaList.Add(new List<string>());
            listaList[1].Add("C");
            listaList[1].Add("D");

            listaList.Add(new List<string>());
            listaList[2].Add("E");
            listaList[2].Add("F");

            listaList.Add(new List<string>() { "G", "H" });


            List<string> listaNapisow = new List<string>()
            { "ala","ma","kota"};


            List<List<string>> listaListNapisow = new List<List<string>>()
            {
                new List<string>() { "A", "B"},
                new List<string>() { "C", "D"},
                new List<string>() { "E", "F"},
            };











        }
    }
}
