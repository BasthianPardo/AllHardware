using System;
using System.Collections.Generic;
using System.Text;

namespace AllHardware
{
    class PlacaBase
    {
        string chipset;
        string marca;
        string socket;

        public PlacaBase(string chipset, string marca, string socket)
        {
            this.chipset = chipset;
            this.marca = marca;
            this.socket = socket;
        }
    }
}
