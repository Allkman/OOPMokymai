using System;
using System.Collections.Generic;
using System.Text;

namespace OOPMokymai.P2.Exercises.Models
{
    public class Zmogus
    {
        public string firstName;
        public string lastName;

        public Zmogus(string firstName, string lastName)
        {
            FirstName = firstName;
            LastName = lastName;
        }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public virtual void Info()
        {
            Console.WriteLine($"{FirstName} {LastName}");
        }
    }
}
