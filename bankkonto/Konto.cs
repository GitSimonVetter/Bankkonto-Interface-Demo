using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bankkonto
{
        
    
    class Konto : IKontozugriff
    {
        public double kontostand;
        public Konto()
        {
            kontostand = 5000;
        }
        

        public void auszahlen(double wert)
        {
            Console.WriteLine("Es wurde " + wert +" Euro ausgezahlt");
            kontostand = kontostand - wert;

        }

        public void einzahlen(double wert)
        {
            Console.WriteLine("Es wurde " + wert + " Euro eingezahlt");
            kontostand = kontostand + wert;
        }

        public double getKontostand()
        {
            return kontostand;
        }

        public void setKontostand(double wert)
        {
            kontostand = wert;
        }
        
    }
}
