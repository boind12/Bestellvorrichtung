using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Auto_kaufen
{
    class LKW: Automobil
    {
        public int Zuladung_Max = 30;

        public LKW()
        {
            verbrauch = 15;
            kilometerstand = 592343;
            tankinhalt = 156;
        }
    }
}
