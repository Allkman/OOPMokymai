using System;
using System.Collections.Generic;
using System.Text;

namespace OOPMokymai.P1.Models
{
    public class PersonInterests
    {
        private string peron;

        const decimal costOfHobby = 100;
        const int maxHobbyCount = 4;
        public PersonInterests(Person person)
        {
            Person = person;           
            
            
        }
        public Person Person { get; }
        public List<Hobby> Hobbies { get; protected set; } = new List<Hobby>();//protected?
        public decimal CostOfHobby => Hobbies.Count * costOfHobby;
        public List<string> HobbiesLog { get; set; } = new List<string>();
        

        public void RemoveSelectedHobby(int hobbyId, string removalReason )
        {
            for (int i = 0; i < Hobbies.Count; i++)
            {
                if (Hobbies[i].HobbyId == hobbyId)
                {
                    HobbiesLog.Add($"removed \"{Hobbies[i].Text}\", reason - {removalReason}");
                    Hobbies.RemoveAt(i);
                    return;
                }
                Console.WriteLine($"Error removing hobbie. Hobby with Id {hobbyId} not found");
            }
        }
        public void AddNewHobby(Hobby hobby)
        {
            if(Hobbies.Count < maxHobbyCount)
            {
                Hobbies.Add(hobby);
            }
            else
            {
                Console.WriteLine($"Can not add {hobby.Text}. Person has too many hobbies");
            }
        }
    }
}
