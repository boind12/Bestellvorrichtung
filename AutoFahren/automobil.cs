using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Auto_fahren
{ 
    class Automobil
    {
        //Variablen
        public int kilometerstand;
        public double verbrauch;
        public double tankinhalt;
        public string name;

        //Methoden
        public void tanken(int neu_getankt)
        {
            tankinhalt += neu_getankt;
        }

        public Boolean fahren(int kilometer)
        {
            double tmp_tank=(kilometer * verbrauch / 100);
            if(tmp_tank>tankinhalt)
            {
                kilometerstand += Convert.ToInt32((tankinhalt / verbrauch * 100));
                tankinhalt = 0;
                return false;
            }
            else
            {
                kilometerstand += kilometer;
                tankinhalt -= (kilometer * verbrauch / 100);
                return true;
            }
        }

        //Konstruktor
        public Automobil()
        {
            kilometerstand = 112234;
            tankinhalt = 50;
            verbrauch = 6.0;
        }

    }
}
