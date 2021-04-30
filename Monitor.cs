using System;
using System.Collections.Generic;
using System.Text;

namespace AllHardware
{
    class Monitor
    {
        string marca;
        string resolucion;
        string consumo;
        string tamanio;

        public Monitor(string marca, string resolucion, string consumo, string tamanio)
        {
            this.marca = marca;
            this.resolucion = resolucion;
            this.consumo = consumo;
            this.tamanio = tamanio;
        }
    }
}
