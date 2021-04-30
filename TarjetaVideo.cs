using System;
using System.Collections.Generic;
using System.Text;

namespace AllHardware
{
    class TarjetaVideo
    {
        string marca;
        string memoria;
        int frecuencia;
        int nucleos;

        public TarjetaVideo(string marca, string memoria, int frecuencia, int nucleos)
        {
            this.marca = marca;
            this.memoria = memoria;
            this.frecuencia = frecuencia;
            this.nucleos = nucleos;
        }
    }
}
