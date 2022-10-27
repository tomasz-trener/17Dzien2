using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace P17WlasneKlasy
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //  Kalkulator k = new Kalkulator();

            Kalkulator k; // deklaracja zmiennej
                          // typu kalkulator, która jest gotowa
                          // na to żeby do niej przypisać 
                          // nowy obiekt jaki? Kalkulator 

            //Kalkulator k = new StringBuilder();

            k = new Kalkulator();

            Kalkulator k2 = new Kalkulator();
            // tutaj tworze nową zmienna i do niej przypisuje
            // nową instacę klasy kalkulator (czyli nowy 
            // obiekt typu kalkulator) 

            new Kalkulator(); // tworzy w pamieci obiekt ale nie mamy 
            // do niego uchwytu (w postaci zmiennej) 

            Kalkulator k3 = k2; // przekazujemy referencje 

            //  WebClient wc = new WebClient();
            //  WebClient wc2 = new WebClient();

            string s1 = "ala";
            string s2 = s1; // przekazujemy kopie 

            s2 = "xx";
            Console.WriteLine(s1);



        }
    }
}
