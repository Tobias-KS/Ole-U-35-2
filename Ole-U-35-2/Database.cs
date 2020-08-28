using System;
using System.Collections.Generic;
using System.Text;

namespace Ole_U_35_2
{
    class Database : IArbejderRegister
    {
        
        private List<Medarbejder> arbejderListe = new List<Medarbejder>();
        private Medarbejder arb;

        public List<Medarbejder> ArbejderListe()
        {
            arbejderListe.Add(arb);
            return arbejderListe;
        }

        public Medarbejder opretArbejder(int x, string z)
        {
            arb = new Medarbejder(x, z);

            return arb;
        }

        public List<Medarbejder> returnArbejderListe()
        {
            return arbejderListe;
        }
    }
}
