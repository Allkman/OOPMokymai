using OOPSchool.P2.Exercises.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace OOPSchool.P2.Exercises
{
    public class Skaicius :IMatematika
    {
        private readonly int number01 = 15;

        public Skaicius(int num01)
        {
            Number01 = num01;
        }
        public int Number01 { get; }

        public int Atimti(int num02)
        {
            return number01 - num02;
        }

        public double Padalinti(int num02)
        {
            return (double)number01 / num02;
        }

        public int Padauginti(int num02)
        {
            return number01 * num02;
        }

        public int PakeltiKubu()
        {
            return number01 * number01 * number01;
        }

        public int PakeltiKvadratu() => Math.Pow(number01, 2);


        public int Prideti(int num02)
        {
            return number01 + num02;
        }
    }
}
