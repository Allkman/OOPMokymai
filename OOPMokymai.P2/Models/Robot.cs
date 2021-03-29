using System;
using System.Collections.Generic;
using System.Text;
using OOPMokymai.P2.Enums;
using OOPMokymai.P2.Models.Abstract;

namespace OOPMokymai.P2.Models
{
    public class Robot : RaceBase
    {
        public Robot(int id, string firstName) : base(id, firstName)
        {

        }
        public Robot(int id, string firstName, string lastName) : this(id, firstName)
        {
            LastName = lastName;
        }

        public string LastName { get; set; }
        public override string RaceDiscriminator => RaceClassificators.ARTIFICIAL;
        public override int Gender => (int)EArtificialLifeGender.ROBOT;

        public override string FullName
        {
            get
            {
                return string.IsNullOrWhiteSpace(LastName) ? $"R. {FirstName}" : $"R. {FirstName} {LastName}";
            }

        }
    }
}
