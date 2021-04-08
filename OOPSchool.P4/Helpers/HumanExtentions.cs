using OOPSchool.P4.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace OOPSchool.P4.Helpers
{
    public static class HumanExtentions
    {
        public static IEnumerable<Human> GenerateRandomWeight(this IEnumerable<Human> input, int min, int max)
        {
            var random = new Random();
            foreach (var person in input)
            {
                person.Weight = random.Next(min, max + 1);
            }
            return input; 
        }

        public static IEnumerable<Human> GenerateRandomBirthDate(this IEnumerable<Human> input)
        {
            var random = new RandomDateTime();
            foreach (var person in input)
            {
                person.BirthDate = random.Next();//papildyti RandomDateTime class
            }
            return input;
        }

    }
}
