using System;
using System.Collections.Generic;
using System.Text;

namespace OOPMokymai.P1.Models
{
    public class Person
    {
        public string firstName;
        public string lastName;
        public int age;

        public Person( string firstName, string lastName, int age)
        {           
            FirstName = firstName;
            LastName = lastName;
            Age = age;
        }        
        public string FirstName { get; protected set; }
        public string LastName { get; protected set; }
        public int Age { get; protected set; }

        public void PrintPersonData()
        {
            Console.WriteLine($"{FirstName} {LastName} {Age}"); 
        }
        public void Paseno()
        {
            Age+=1;
        }

    }
}
