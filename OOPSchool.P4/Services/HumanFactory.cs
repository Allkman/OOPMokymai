using OOPSchool.P4.Enums;
using OOPSchool.P4.InitialData;
using OOPSchool.P4.Models;
using OOPSchool.P4.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OOPSchool.P4.Services
{
    public class HumanFactory : IHumanFactory
    {
        public IEnumerable<Human> Bind()
        {
            foreach (var line in CharacterInitialData.DataSeedCSV.Where(p => p.Contains("Human")))
            {
                var personArr = line.Split(",");
                yield return new Human(personArr[0].Trim(), personArr[1].Trim(), (EGender)int.Parse(personArr[4].Trim()));
            };
        }
    }
}
