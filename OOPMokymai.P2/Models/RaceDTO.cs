using System;
using System.Collections.Generic;
using System.Text;

namespace OOPSchool.P2.Models
{
    public class RaceDTO
    {
        public RaceDTO(int id, string firstName, string lastName, int gender, string raceDiscriminator)
        {
            Id = id;
            FirstName = firstName;
            LastName = lastName;
            Gender = gender;
            RaceDiscriminator = raceDiscriminator;
        }

        public int Id { get; set; }
        public  string FirstName { get;}
        public  string LastName { get;}
        public  int Gender { get; }
        public  string RaceDiscriminator { get; }

    }
}
