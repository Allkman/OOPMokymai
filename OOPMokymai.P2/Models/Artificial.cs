using OOPMokymai.P2.Enums;
using OOPMokymai.P2.Models.Abstract;

namespace OOPMokymai.P2.Models
{
    public class Artificial : RaceBase
    {
        public Artificial(int id, string firstName, EArtificialLifeGender gender) : base(id, firstName)
        {
            Gender = gender != EArtificialLifeGender.ROBOT ? (int)gender : 0;
        }
        public Artificial(int id, string firstName, int gender) : base(id, firstName)
        {
            Gender = gender != 2 ? (int)gender : 0;
        }

        public override string RaceDiscriminator => RaceClassificators.ARTIFICIAL;

        public override int Gender { get; }

        public override string FullName => FirstName;
    }
}
