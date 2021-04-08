using OOPSchool.P4.Helpers;
using OOPSchool.P4.Services;
using OOPSchool.P4.Services.Interfaces;
using System;
using System.Linq;

namespace OOPSchool.P4
{
    class Program
    {
        static void Main(string[] args)
        {
            IHumanFactory humanFactory = new HumanFactory();
            var people = humanFactory.Bind().ToList();

            foreach (var human in people)
            {
                Console.WriteLine($"{human.FirstName} {human.LastName}");
            }

            people.GenerateRandomWeight(60, 120).GenerateRandomBirthDate();

        }
    }
}
