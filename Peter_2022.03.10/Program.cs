using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Peter_2022._03._10
{
    internal class Program
    {
        struct Adat
        {
                public int szam1, szam2, szam3;
                public string nev;
        }

        static void Beolvas()
        {
            StreamReader olvas = new StreamReader("TRIATLON.BE");
            int tombadat = int.Parse(olvas.ReadLine());
            Adat[] adatok = new Adat[tombadat];
            for (int i = 0; i < adatok.Length; i++)
            {
                adatok[i].nev = olvas.ReadLine();
                adatok[i].szam1 = int.Parse(olvas.ReadLine());
                adatok[i].szam2 = int.Parse(olvas.ReadLine());
                adatok[i].szam3 = int.Parse(olvas.ReadLine());
            }
            olvas.Close();
        }
        static void Main(string[] args)
        {
            Beolvas();
        }
    }
}
