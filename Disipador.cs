using System;
using System.Collections.Generic;
using System.Text;

namespace AllHardware
{
    class Disipador
    {
        string marca;
        string potencia;
        string socket;

        public Disipador(string marca, string potencia, string socket)
        {
            this.marca = marca;
            this.potencia = potencia;
            this.socket = socket;
        }
    }
}
