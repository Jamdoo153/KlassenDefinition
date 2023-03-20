using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KlassenDefinieren
{
    internal class Auto
    {
        public string marke;
        public int bauJahr;

         public void Beschleunigung()
         {
            if (istSchnell())
            {
               Console.WriteLine("Habe schnell beschleunigung Year");
            }
            else
            {
               Console.WriteLine("Habe normal beschleunigt ööööh");
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
