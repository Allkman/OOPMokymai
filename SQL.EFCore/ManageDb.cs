using System;
using System.Collections.Generic;
using System.Text;

namespace SQL.EFCore
{
    public class ManageDb
    {
        public void AddPerson(string firstName, string lastName, int age)
        {
            using (var context = new ApplicationDbContext())
            {
                context.Database.EnsureCreated();
                var person = new Person
                {
                    FirstName = firstName,
                    LastName = lastName,
                    Age = age
                };
                //context.Persons.Add(person);
                context.SaveChanges();
            }
        }
    }
}
