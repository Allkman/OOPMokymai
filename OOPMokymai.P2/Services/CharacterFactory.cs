using OOPMokymai.P2.Models;
using OOPMokymai.P2.Models.Abstract;
using OOPSchool.P2.InitialData;
using OOPSchool.P2.Models;
using OOPSchool.P2.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace OOPSchool.P2.Services
{
    public class CharacterFactory
    {
        public IEnumerable<RaceBase> BildAll()
        {
            foreach (var race in RaceInitialData.DataSeed)
            {
                yield return Build(race);
            }
        }

        protected RaceBase Build(RaceDto race)
        {
            Dictionary<string, IRaceFactory> strategy = new Dictionary<string, IRaceFactory>
            {
                { RaceClassificators.HUMAN, new HumanFactory() },
                { RaceClassificators.KREE, new KreeFactory() },
                { RaceClassificators.ARTIFICIAL, new ArtificialLifeFactory() },
            };
            var character = strategy[race.RaceDiscriminator].Build(race);
            return character;
        }

    }
}
