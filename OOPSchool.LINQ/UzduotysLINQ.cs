using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OOPSchool.LINQ
{
    public class UzduotysLINQ
    {
        public int positiveNumbers { get; set; }
        public int negativeNumbers { get; set; }

        private Random rnd = new Random();
        int[] numbers01 = new int[20];
        

        public UzduotysLINQ()
        {

        }
        public void GenerateArray()
        {
            for (int i = 0; i < numbers01.Length; i++)
            {
                numbers01[i] = rnd.Next(-100, 101);
            }            
        }

        public void CountPositive()
        {
            GenerateArray();
            positiveNumbers = numbers01.Count(n => n > 0);
            Console.WriteLine($"There are {positiveNumbers} positive numbers"); 
        }
        public void CountNegative()
        {
            GenerateArray();
            negativeNumbers = numbers01.Count(n => n < 0);
            Console.WriteLine($"There are {negativeNumbers} negative numbers");
        }
        public void CompareAndPrintHigherQuantity()
        {
            GenerateArray();
            if (positiveNumbers - negativeNumbers == 0)
            { Console.WriteLine("Po lygiai"); }
            else if (positiveNumbers > negativeNumbers) 
            { Console.WriteLine("Teigiamu daugiau"); }
            else 
            { Console.WriteLine("Neigiamu daugiau"); }           
        }
    }
}
