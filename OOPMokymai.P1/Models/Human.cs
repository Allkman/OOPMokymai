using OOPMokymai.P1.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace OOPMokymai.P1.Models
{
    public class Human
    {
        private string _firstName;
        private string _lastName;
        public Human(int id, string firstName, string lastName, EHumanoidGender gender)
        {
            Id = id;
            FirstName = firstName;
            LastName = lastName;
            Gender = gender;
            Hobbies = new List<Hobby>();
        }
        public Human(int id, string firstName, string lastName, EHumanoidGender gender, DateTime? birthDate) : this(id, firstName, lastName, gender)
        {
            BirthDate = birthDate;
        }
        public int Id { get; set; }
        public string FirstName
        {
            get
            {
                return _firstName;
            }
            set
            {
                if (!string.IsNullOrWhiteSpace(_firstName)) // kol sis vardas nera uzsetintas
                {
                    NameChanges += $"{_firstName} -> {value} {Environment.NewLine}";
                }
                _firstName = value;
            } // => tai tas pat kas return
        }
        public string LastName
        {
            get => _lastName;
            set
            {
                if (!string.IsNullOrWhiteSpace(_lastName)) // kol sis vardas nera uzsetintas
                {
                    NameChanges += $"{_lastName} -> {value} {Environment.NewLine}";
                }
                _lastName = value;
            } // => tai tas pat kas return
        }
        public DateTime? BirthDate { get; }
        public EHumanoidGender Gender { get; set; }
        public string FullName
        {
            get
            {
                return $"{FirstName} {LastName}";
            }
        }
        public string NameChanges { get; protected set; } //gali but keiciama tik is sios klases
        public int? Age => GetAge();
        //Kompozicija 1:1
        public Profession Profession { get; set; }

        //Kompizicija 1: daug
        public List<Hobby> Hobbies { get; set; }

        protected int? GetAge() // int? = nullable
        {
            if (BirthDate == null)
            {
                return null;
            }
            var timeSpan = DateTime.Now.Subtract((DateTime)BirthDate);
            return new DateTime(timeSpan.Ticks).Year-1;
        }
    }
}