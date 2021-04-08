using System;
using System.Collections.Generic;
using System.Text;

namespace SQL.EFCore
{
    public class Person
    {
        public int PersonId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
    }
}
