using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace SQL.EFCore
{
    public class ApplicationDbContext : DbContext
    {

        DbSet<Person> Persons { get; set; }
    }
}
