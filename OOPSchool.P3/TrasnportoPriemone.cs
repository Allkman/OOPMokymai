using System;
using System.Collections.Generic;
using System.Text;

namespace OOPSchool.P3
{
    public abstract class TrasnportoPriemone
    {
        protected TrasnportoPriemone(string pavadinimas, int vidutinisGreitis)
        {
            Pavadinimas = pavadinimas;
            VidutinisGreitis = vidutinisGreitis;
        }

        public string Pavadinimas { get; set; }
        public int VidutinisGreitis { get; set; }
        public abstract void Vaziuoti();       

    }
    public class Dviratis : TrasnportoPriemone
    {
        public Dviratis(string pavadinimas, int vidutinisGreitis) : base(pavadinimas, vidutinisGreitis)
        {
        }

        public override void Vaziuoti()
        {
            Random rnd = new Random();
            int stovejimoLaikas = rnd.Next(5,20);
            int vaziavimoLaikas = rnd.Next(10, 90);
            Console.WriteLine($"Dviratis: {Pavadinimas} stovejo {stovejimoLaikas} min");
            var atstumas = VidutinisGreitis * (vaziavimoLaikas - stovejimoLaikas)/60;
            Console.WriteLine($"Viso vaziavo {vaziavimoLaikas} ir per ta laika nuvaziavo {atstumas} metru");
            Console.WriteLine($"Vidutinis greitis buvo {VidutinisGreitis}");
        }
    }
    public class Automobolis : TrasnportoPriemone
    {
        public Automobolis(string pavadinimas, int vidutinisGreitis) : base(pavadinimas, vidutinisGreitis)
        {
        }

        public override void Vaziuoti()
        {
            Random rnd = new Random();
            int stovejimoLaikas = rnd.Next(5, 10);
            int vaziavimoLaikas = rnd.Next(10, 50);
            Console.WriteLine($"Automobilis: {Pavadinimas} stovejo {stovejimoLaikas} min");
            var atstumas = VidutinisGreitis * (vaziavimoLaikas - stovejimoLaikas)/60;
            Console.WriteLine($"Viso vaziavo {vaziavimoLaikas} ir per ta laika nuvaziavo {atstumas}");
            Console.WriteLine($"Vidutinis greitis buvo {VidutinisGreitis}");
        }
    }
}
