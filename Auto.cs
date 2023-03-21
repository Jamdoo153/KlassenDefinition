using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KlassenDefinieren
{
    internal class Auto
    {
        private int aktuelleGeschwindigkeit;

        public Auto(string autoMarke)
        {
            marke = autoMarke;
            BauJahr = 0;
            aktuelleGeschwindigkeit = 0;
        }

        private string marke;

        public string Marke
        {
            get { return marke; }
            set
            {
                if (value == "Porsche")
                {
                    marke = value;
                }
                else
                {
                    marke = "Nicht unterstützt";
                }
            }    
        }

        private int bauJahr;

        public int BauJahr
        {
            get { return bauJahr; }
            set { bauJahr = value;}
        }


         public void Beschleunigung()
         {
            aktuelleGeschwindigkeit = 100;
            if (istSchnell())
            {
               Console.WriteLine("Ich bin mit den {0} schnell beschleunigung Year", marke);
            }
            else
            {
               Console.WriteLine("Das Fahrzeug wird nicht {0}, acht wie doof",marke);
            }
            }
            private bool istSchnell()
            {
                if (marke == "Porsche")
                {
                    return true;
                }
                return false;
            }
    }
}
