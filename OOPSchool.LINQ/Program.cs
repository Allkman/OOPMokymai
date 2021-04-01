using System;
using System.Collections.Generic;
using System.Linq;

namespace OOPSchool.LINQ
{
    class Program
    {
        public static List<string> miestai = new List<string> { "Vilnius", "Kaunas", "Klaipeda", "Alytus" };
        static List<int> skaiciai = new List<int> {1,2,3,4,5,6,7,8,9};
        static void Main(string[] args)
        {
        //    Console.WriteLine("Visi miestai {0}", string.Join(", ", miestai));
        //    foreach (var miestas in miestai)
        //    {
        //        if (miestas[0] == 'K')
        //        {
        //            Console.WriteLine($"miestas is K yra {miestas}");
        //        }
        //    }
        //    Console.WriteLine("Miestai is K raides su LINQ {0}", string.Join(", ", miestai.Where(m =>m.StartsWith("K") )));
        //    Console.WriteLine("Miestu su K raide kiekis su LINQ {0}", miestai.Count(m =>m.StartsWith("K") ));

        //    Console.WriteLine("Ar yra miestas Kaunas? {0}", miestai.Any(m =>m == "Kaunas") ? "Taip": "Ne");
        //    Console.WriteLine("Ar yra miestas Utena? {0}", miestai.Any(m =>m == "Utena") ? "Taip": "Ne");

        //    var tikrinamiMiestai = new string[] { "Taurage", "Pabrade" };
        //    Console.WriteLine("Ar yra miestu tarp miestu is masyvo [Taurage, Pabrade] {0}", 
        //        miestai.Any(miestas =>tikrinamiMiestai.Contains(miestas)) ? "Taip": "Ne");

        //    Console.WriteLine("Surusiuoti miestai nuo A iki Z {0}", string.Join(", ", 
        //        miestai.OrderBy(miestas => miestas) ));
        UzduotysLINQ results = new UzduotysLINQ();
           
        results.CountPositive();
        results.CountNegative();
        results.CompareAndPrintHigherQuantity();


        }
    }
}
