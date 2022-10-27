using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace P10ZadanieTabliceWieloWym
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const string sciezka = "http://tomaszles.pl/wp-content/uploads/2019/06/zawodnicy.txt";

            WebClient wc = new WebClient();
            string dane = wc.DownloadString(sciezka);

            string[] wiersze= dane.Split(new string[1] { "\r\n" }, StringSplitOptions.RemoveEmptyEntries);

            int liczbaWierszy = wiersze.Length - 1;
            int liczbaKolumn = wiersze[0].Split(';').Length;

            string[,] tab = new string[liczbaWierszy, liczbaKolumn];

            for (int i = 1; i < wiersze.Length; i++)
            {
                string[] komorki=  wiersze[i].Split(';');
                for (int j = 0; j < komorki.Length; j++)
                    tab[i - 1, j] = komorki[j];
            }



        }
    }
}
