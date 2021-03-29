using System;
using System.Collections.Generic;
using System.Text;

namespace OOPMokymai.P2.Models.Abstract
{
    public abstract class RaceBase
    {
        protected RaceBase(int id, string firstName)
        {
            Id = id;
            FirstName = firstName;
        }

        public int Id { get; set; }
        public virtual string FirstName { get; set; }
        public abstract int Gender { get; }

        public abstract string RaceDiscriminator { get; }
        public abstract string FullName { get; }
    }
}
