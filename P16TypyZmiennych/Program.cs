using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace P16TypyZmiennych
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a    = 7;
            int a2;

            char b   = 'x';
            string c = "hej"; // to klasa, która wyglada jak struktura i przezuje uchwyt przez kopie 
            double d = 8.5;
            bool e   = false;

            bool e2 = e; 

            DateTime data = new DateTime();
            DateTime data2 = data;
            WebClient wc = new WebClient();


            StringBuilder sb = new StringBuilder();
            sb.Append("ala ");
            sb.Append("ma ");
            sb.Append("kota");
            string s = sb.ToString();

            WebClient wc2;
            wc2 = new WebClient();


            // klasy przekazuja przez referencje
            // struktury przez wartosc 








        }
    }
}
