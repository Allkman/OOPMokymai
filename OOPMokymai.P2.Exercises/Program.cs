using OOPMokymai.P2.Exercises.Models;
using System;

namespace OOPMokymai.P2.Exercises
{
    class Program
    {
        static void Main(string[] args)
        {
            var zmogus = new Zmogus("Algirdas","Cernevicius");
            zmogus.Info();

            var pilietis = new Pilietis("385066544", "Lietuvis","Algiras","Cernevicius");
            pilietis.Info();
            var gyventojas = new Gyventojas("Vilnius","385066544", "Lietuvis","Algiras","Cernevicius");
            gyventojas.Info();
            Console.WriteLine("----------------------------------");

            

            Console.WriteLine("-= End of program. Press any key to close =-");
            Console.ReadKey();
        }
    }
}
