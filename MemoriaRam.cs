using System;
using System.Collections.Generic;
using System.Text;

namespace AllHardware
{
    class MemoriaRam
    {
        string marca;
        string memoria;
        string factordeforma;
        int potencia;

        public MemoriaRam(string marca, string memoria, string factordeforma, int potencia)
        {
            this.marca = marca;
            this.memoria = memoria;
            this.factordeforma = factordeforma;
            this.potencia = potencia;
        }
    }
}
