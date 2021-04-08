using OOPSchool.P4.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace OOPSchool.P4.Models
{
    public class Human
    {
        private decimal _weight;
        public Human(string firstName, string lastName, EGender gender)
        {
            FirstName = firstName;
            LastName = lastName;
            Gender = gender;
        }

        public string FirstName { get; set; }
        public string LastName { get; set; }
        public EGender Gender { get; set; }
        public decimal Weight 
        { 
            get => _weight;
            set {  _weight = value; WriteBiography(); } }

        private void WriteBiography()
        {
            
        }

        public DateTime? BirthDate { get; set; }
        public string Biography { get; set; }
        public int? Age { get; set; }

        public string GetBiographyWithAge()
        {
            return $"{FirstName} {LastName}. {FirstName} ";
        }
        public string GetBiographyNoAge()
        {

        }

    }
}
