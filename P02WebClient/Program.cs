using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace P02WebClient
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Podanj nazwe miasta");

            WebClient wc = new WebClient();

            string s = wc.DownloadString("https://www.google.com/search?q=warszawa+pogoda");

            File.WriteAllText("c:\\dane\\strona.html",s);

            //Console.WriteLine(s);

            Console.ReadKey();
        }
    }
}
