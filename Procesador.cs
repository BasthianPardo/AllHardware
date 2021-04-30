using System;
using System.Collections.Generic;
using System.Text;

namespace AllHardware
{
    class Procesador
    {
        string marca;
        int nucleos;
        int hilos;
        int cache;
        float frecuencia;

        public Procesador(string marca, int nucleos, int hilos, int cache, float frecuencia)
        {
            this.marca = marca;
            this.nucleos = nucleos;
            this.hilos = hilos;
            this.cache = cache;
            this.frecuencia = frecuencia;
        }
    }
}
