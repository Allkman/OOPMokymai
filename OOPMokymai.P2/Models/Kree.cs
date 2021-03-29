using OOPMokymai.P2.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace OOPMokymai.P2.Models
{
    public class Kree : Humanoid
    {
        public Kree(int id, string firstName, string lastName, EHumanoidGender gender) : base(id, firstName, lastName)
        {
            Gender = (int)gender;
        }
        public override int Gender { get; }
        public override string RaceDiscriminator => RaceClassificators.KREE;
    }
}
