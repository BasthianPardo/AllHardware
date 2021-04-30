using System;
using System.Collections.Generic;
using System.Text;

namespace AllHardware
{
    class Mouse
    {
        string marca;
        int dpi;
        Boolean rgb;

        public Mouse(string marca, int dpi, bool rgb)
        {
            this.marca = marca;
            this.dpi = dpi;
            this.rgb = rgb;
        }
    }
}
