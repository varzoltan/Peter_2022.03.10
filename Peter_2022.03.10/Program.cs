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
            public string nev;
            public int uszasi_ido { get; set; }
            public int kerkpar_ido { get; set; } 
            public int futas_ido { get; set; } 
            public int osszesitett_ido {get { return uszasi_ido + kerkpar_ido + futas_ido; } }
        }

        static List<Adat> lista = new List<Adat>();
        static Adat adatok = new Adat();
        static void Beolvas()//Eljárás, amivel beolvassuk a fájlt.
        {
            
            StreamReader olvas = new StreamReader("TRIATLON.BE");
            int tombadat = int.Parse(olvas.ReadLine());
            for (int i = 0; i < tombadat; i++)
            {
                adatok.nev = olvas.ReadLine();
                adatok.uszasi_ido = int.Parse(olvas.ReadLine());
                adatok.kerkpar_ido = int.Parse(olvas.ReadLine());
                adatok.futas_ido = int.Parse(olvas.ReadLine());
                lista.Add(adatok);
            }
            olvas.Close();
        }
        static void Main(string[] args)//Main
        {
            //1.feladat
            Beolvas();
            Console.WriteLine("1.feladat: Beolvasás kész!");

            //2.feladat
            Console.WriteLine("\n2.feladat");
            var gyoztesek = lista.OrderBy(x => x.osszesitett_ido);
            int k = 0;
            foreach(var i in gyoztesek)
            {
                k++;
                Console.WriteLine($"{i.nev}: {i.osszesitett_ido}");
                if (k == 3) break;
            }

            //3.feladat
            Console.WriteLine("\n3.feladat");
            Console.WriteLine($"{gyoztesek.ElementAt(0).nev}");
            Console.WriteLine($"{1500.0/gyoztesek.ElementAt(0).uszasi_ido * 3,6}");
            Console.ReadKey();
        }
    }
}
