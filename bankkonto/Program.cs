using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bankkonto
{
    class Program
    {
        static void Main(string[] args)
        {
            Konto a = new Konto();
            int option;
            double input;
            
            while (true)
            {
                Console.Clear();
                Console.WriteLine("Wähle aus 1 einzahlen 2 auszahlen 3 Kontostand 4 CheatCode");
                option = Convert.ToInt32(Console.ReadLine());
                if (option == 1)
                {
                    Console.WriteLine("Wähle deinen einzuzahlenden Wert ein");
                    input = Convert.ToDouble(Console.ReadLine());
                    a.einzahlen(Convert.ToDouble(input));
                    Console.WriteLine(a.kontostand);
                }
                else if (option == 2)
                {
                    Console.WriteLine("Wähle deinen auszuzahlenden Wert ein");
                    input = Convert.ToDouble(Console.ReadLine());
                    a.auszahlen(Convert.ToDouble(input));
                    Console.WriteLine(a.kontostand);
                }
                else if (option == 3)
                {
                    Console.WriteLine(a.kontostand);
                }
                else if (option == 4)
                {
                    Console.WriteLine("Wähle den Wert des Kontos aus");
                    a.kontostand = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine(a.kontostand);
                }
                Console.ReadKey();
            }
            
        }
    }
}
