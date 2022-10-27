using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace P07ZadaniePogoda2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> temperatury = new List<int>();
            List<string> miasta = new List<string>();
            while (true)
            {
                string szukanyZnak = "°";
                string znakKoncowy = ">";

                Console.WriteLine("Podaj nazwe miasta");
                string miasto = Console.ReadLine();

                if (miasto == "koniec")
                    break;

                string adres = $"https://www.google.com/search?q=pogoda {miasto}";

                WebClient wc = new WebClient();
                string dane = wc.DownloadString(adres);

                int indx = dane.IndexOf(szukanyZnak);
                int aktuanaPozycja = indx;

                while (dane.Substring(aktuanaPozycja, 1) != znakKoncowy)
                    aktuanaPozycja--;

                string wynik = dane.Substring(aktuanaPozycja + 1, indx - aktuanaPozycja + 1);
                temperatury.Add(Convert.ToInt32(wynik.Substring(0,wynik.Length-2)));
                miasta.Add(miasto);
                Console.WriteLine(wynik);
            }

            double suma = 0;
            for (int i = 0; i < temperatury.Count(); i++)
                suma += temperatury[i];

            double srednia = suma / temperatury.Count();

            string raport = string.Format("średnia temepratura w miastach {0} wynosi {1}",
                string.Join(", ", miasta), srednia);

            Console.WriteLine(raport);
            Console.ReadKey();
        }
    }
}
