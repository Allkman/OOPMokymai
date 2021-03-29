using System;

namespace OOPMokymai.P2.Exercises.Models
{
    public class Pilietis : Zmogus
    {
        public Pilietis(string asmensKodas, string pilietybe, string firstName, string lastName) :base( firstName, lastName)
        {
            AsmensKodas = asmensKodas;
            Pilietybe = pilietybe;
        }

        public string AsmensKodas { get; set; }
        public string Pilietybe { get; set; }
        public override void Info()
        {
            Console.WriteLine($"{FirstName} {LastName} {AsmensKodas} {Pilietybe}");
        }
    }

}
