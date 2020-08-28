using System;
using System.Collections.Generic;
using System.Text;

namespace Ole_U_35_2
{
    class Medarbejder
    {
        private int Loen;
        private string Navn;
        public Medarbejder(int x, string z)
        {
            Loen = x;
            Navn = z;
        }
        public string returnString()
        {
            return Navn;
        }
        public int returnInt()
        {
            return Loen;
        }
    }
}
