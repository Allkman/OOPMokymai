using System;

namespace OOPMokymai.P2.Exercises.Models
{
    public class Gyventojas : Pilietis
    {
        public Gyventojas(
            string gyvenamojiVieta, 
            string asmensKodas, 
            string pilietybe, 
            string firstName, 
            string lastName) : base(asmensKodas, pilietybe, firstName, lastName)
        {
            GyvenamojiVieta = gyvenamojiVieta;
        }
        public string GyvenamojiVieta { get; set; }
        public override void Info()
        {
            base.Info();
            Console.WriteLine($"gyvenamoji vieta {GyvenamojiVieta}");
        }
    }
}
