using OOPMokymai.P1.Enums;
using OOPMokymai.P1.Models;
using OOPMokymai.P1.Services;
using System;

namespace OOPMokymai.P1
{
    class Program
    {
        static void Main(string[] args)
        {
            var hobby1 = new Hobby();
            hobby1.HobbyId = 1;
            hobby1.Text = "Robotics";
            hobby1.Text = "Robotika";

            var hobby2 = new Hobby(2, "Music", "Muzika");

            var hobby3 = new Hobby { HobbyId = 3, Text = "Space exploration", TextLT = "Kosmoso tyrinėjimai" };

            hobby3.Text = "Change from \"Space exploration\" to: Star gazing";

            var profession1 = new Profession(1);
            profession1.SetText("Kazkoks tekstas");

            var professionFactory = new ProfessionFactory();
            var profession2 = professionFactory.BuildEngineer();
            var profession3 = professionFactory.BuildPharmacist();

            var human1 = new Human(1, "Algirdas", "Cernevicius", EHumanoidGender.MALE, new DateTime(2000, 02, 01));
            Console.WriteLine($"human1= {human1.FullName}");
            human1.FirstName = "SomethingElse";
            Console.WriteLine($"human1= {human1.FullName}");
            Console.WriteLine($"human1 vardu keitimas \n = {human1.NameChanges}");
            Console.WriteLine("--------------------------------------------");
            var person = new Person("Algirdas", "Černevičius", 35);
            person.PrintPersonData();
           
            person.Paseno();
            person.PrintPersonData();
            Console.WriteLine("----------------============--------------------");
            human1.Profession = new Profession(2, "Programmer", "Programuotojas");

            human1.Hobbies.Add(new Hobby(1, "Art", "Menas"));
            human1.Hobbies.Add(new Hobby(1, "Astrology", "Astrologija"));
            int costOfHobby = 100;
            Console.WriteLine("----------------======--------------------------");
            PersonInterests personInterests = new PersonInterests(person);
            
            personInterests.AddNewHobby(new Hobby(1, "Art", "Menas"));
            personInterests.AddNewHobby(new Hobby(2, "Adfgrt", "werghdgf"));
            personInterests.AddNewHobby(new Hobby(3, "Arfgmt", "sfsdfsdf"));
            personInterests.AddNewHobby(new Hobby(4, "ghfg", "sdf"));
            personInterests.AddNewHobby(new Hobby(5, "sdd", "Msdfsdfenas"));
            personInterests.AddNewHobby(new Hobby(6, "Art", "Menas"));
            Console.WriteLine("---ADD---");

            Console.WriteLine($"person {personInterests.Person.FirstName} has hobbies");
            foreach (var hobby in personInterests.Hobbies)
            {
                Console.WriteLine($"{hobby.Text}");
            }

            Console.WriteLine("---REMOVE-----");
            personInterests.RemoveSelectedHobby(2, "fsdf");
            personInterests.RemoveSelectedHobby(4, "fsfdsfdf");
            personInterests.RemoveSelectedHobby(5, "fsdmmmmmmf");

            Console.WriteLine("----HobbiesLog-----");
            foreach (var log in personInterests.HobbiesLog)
            {
                Console.WriteLine($"{log}");
            }


            Console.WriteLine("-= End of program. Press any key to close =-");
            Console.ReadKey();

        }
    }
}
