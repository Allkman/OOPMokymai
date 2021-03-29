using System;
using System.Collections.Generic;
using System.Text;

namespace DeckOfCards.Models
{
    public class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public Person()
        {

        }
        public Person(string firstName, string lastName)
        {
            FirstName = firstName;
            LastName = lastName;
        }

        public virtual string PersonInfo()
        {
            return $"Name: {FirstName}, Surname: {LastName}";
        }

    }
}
