using System;
using System.Collections.Generic;

namespace Ole_U_35_2
{
    class Program
    {
        static void Main(string[] args)
        {

            Database a = new Database();

            a.opretArbejder(32500, "Jan");
            a.ArbejderListe();
            a.opretArbejder(35000, "Kristoffer");
            a.ArbejderListe();
            a.opretArbejder(37500, "Adam");
            a.ArbejderListe();

            List<Medarbejder> listeAfArbejdere = a.returnArbejderListe();

           
            foreach (var item in listeAfArbejdere)
            {
                Console.WriteLine("------------------------");
                Console.WriteLine($"{item.returnString()} {item.returnInt()} kr.");
                Console.WriteLine(" ");
                
            }
            Console.ReadKey();

            }
    }
}
