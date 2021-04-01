using OOPMokymai.P2.Enums;
using OOPMokymai.P2.Models;
using OOPMokymai.P2.Models.Abstract;
using OOPSchool.P2.Models;
using OOPSchool.P2.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace OOPSchool.P2.Services
{
    public class HumanFactory : IRaceFactory
    {
        public RaceBase Build(RaceDTO race)
        {
            return new Human(race.Id, race.FirstName, race.LastName, race.Gender);
        }
    }
}
