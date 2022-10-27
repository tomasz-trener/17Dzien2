using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace P01ZadaniePogoda
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                string szukanyZnak = "°";
                string znakKoncowy = ">";

                Console.WriteLine("Podaj nazwe miasta");
                string miasto = Console.ReadLine();
                string adres = $"https://www.google.com/search?q=pogoda {miasto}";

                WebClient wc = new WebClient();
                string dane = wc.DownloadString(adres);

                int indx = dane.IndexOf(szukanyZnak);
                int aktuanaPozycja = indx;

                while (dane.Substring(aktuanaPozycja, 1) != znakKoncowy)
                    aktuanaPozycja--;

                string wynik = dane.Substring(aktuanaPozycja + 1, indx - aktuanaPozycja + 1);

                Console.WriteLine(wynik);
            }
            //https://github.com/tomasz-trener/17Dzien2

        }
    }
}
