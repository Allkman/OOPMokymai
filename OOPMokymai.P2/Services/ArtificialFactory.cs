using OOPMokymai.P2.Models;
using OOPMokymai.P2.Models.Abstract;
using OOPSchool.P2.Models;
using OOPSchool.P2.Services.Interfaces;

namespace OOPSchool.P2.Services
{
    public class ArtificialFactory : IRaceFactory
    {
        public RaceBase Build(RaceDto race)
        {
            if (race.Gender == (int)EArtificialLifeGender.ROBOT)
            {
                return new Robot(race.Id, race.FirstName, race.LastName);
            }
            else
            {
                return new Artificial(race.Id, race.FirstName, race.Gender);
            }
        }
    }
}
