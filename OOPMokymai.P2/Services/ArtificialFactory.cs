using OOPMokymai.P2.Models;
using OOPMokymai.P2.Models.Abstract;
using OOPSchool.P2.Models;
using OOPSchool.P2.Services.Interfaces;

namespace OOPSchool.P2.Services
{
    public class ArtificialFactory : IRaceFactory
    {
        public RaceBase Build(RaceDTO race)
        {
            if (race.Gender == )
            {

            }
            return new Human(race.Id, race.FirstName, race.LastName, race.Gender);
        }
    }
}
