using OOPSchool.P4.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace OOPSchool.P4.Services.Interfaces
{
    public interface IHumanFactory
    {
        IEnumerable<Human> Bind(); //betkokia kolekcija
    }
}
