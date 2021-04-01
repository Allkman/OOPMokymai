using System;

namespace OOPSchool.P3
{
    class Program
    {
        static void Main(string[] args)
        {
            Automobolis auto1 = new Automobolis("Ford", 70);
            auto1.Vaziuoti();
            Automobolis auto2 = new Automobolis("Volvo", 50);
            auto2.Vaziuoti();
            Automobolis auto3 = new Automobolis("BMW", 80);
            auto3.Vaziuoti();

        }
    }
}
