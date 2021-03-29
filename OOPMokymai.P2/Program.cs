using OOPMokymai.P2.Enums;
using OOPMokymai.P2.Models;
using System;

namespace OOPMokymai.P2
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            **PAVELDEJIMAS * *
          -Sukurkite klasę Humanoid,
           -iš Human perkelkite properčius FirstName, LastName, FullName, NameChanges
           -Human paveldi iš Humanoid
          - !isitikinkite, kad Human vis dar turi FullName
           */
            var human = new Human(1, "Vardenis", "Pavardenis", EHumanoidGender.MALE);
            Console.WriteLine($"{human.FullName} is {human.RaceDiscriminator}");
            /*
             Skurkite statinę klasę RaceClassificators su const fieldais (string):
            HUMAN, SKRULL, KREE, CHITAURI, LIZARD, ARTIFICIAL, OLDONE, WATCHER
             */

            var kree1 = new Kree(1, "Elleanor", "Park", EHumanoidGender.FEMALE);
            Console.WriteLine($"{kree1.FullName} is {kree1.RaceDiscriminator}");

            /*
            ** UŽDUOTIS 1 **
            - Sukurkite klasę Zmogus : Vardas, Pavarde, metodas Info (atspausdina informaciją apie žmogų vienoje eilutėje).
            - Sukurkite klasę Pilietis, kuri paveldi iš klasės Zmogus , ir savyje turi AsmensKodas, Pilietybe
            - Sukurkite klasę Gyventojas, kuri turi GyvenamojiVieta 
            Kiekvienos klasės konstruktorius inicializuoja duomenis.
               ** UŽDUOTIS 2 **
            Pilietis klasėje perrašykite metodą Info. 
            - Jo viduje iškvieskite tėvinės klasės metodą ir papildomai atspausdinkite Pilietis klasės informaciją.
            Gyventojas klasėje perrašykite metodą Info . 
            - Jo viduje iškvieskite tėvinės klasės metodą ir papildomai atspausdinkite Gyventojas  klasės informaciją.
            Main metode sukurkite Zmogus , Pilietis, Gyventojas objektus ir kiekvienam iškvieskite į ekraną metodo Info grąžinamus duomenis
             */
           

            Console.WriteLine();
            Console.WriteLine("-End of program. Press any key-");
            Console.ReadKey();
        }
    }
}
