using System;
using System.Collections.Generic;
using System.Text;

namespace AllHardware
{
    class Gabinete
    {
        string marca;
        string factordeforma;
        Boolean rgb;

        public Gabinete(string marca, string factordeforma, Boolean rgb)
        {
            this.marca = marca;
            this.factordeforma = factordeforma;
            this.rgb = rgb;
        }
    }
}
