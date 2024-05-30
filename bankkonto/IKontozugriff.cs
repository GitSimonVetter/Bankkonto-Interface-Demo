using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bankkonto
{
  public interface IKontozugriff
    {
        double getKontostand();
        void setKontostand(double wert);
        void einzahlen(double wert);
        void auszahlen(double wert);
    }
}
