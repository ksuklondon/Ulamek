using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ulamek
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Ulamek u1 = new Ulamek(1, 2);
            Ulamek u2 = new Ulamek(3, 4);

            Ulamek suma = u1 + u2;
            Ulamek roznica = u1 - u2;
            Ulamek iloczyn = u1 * u2;
            Ulamek iloraz = u1 / u2;

            Console.WriteLine("Suma: " + suma);
            Console.WriteLine("Różnica: " + roznica);
            Console.WriteLine("Iloczyn: " + iloczyn);
            Console.WriteLine("Iloraz: " + iloraz);
            Console.WriteLine("Double: " + iloraz.ToDouble());
 
            Ulamek.ZwiekszLicznik(ref u1);
            Console.WriteLine("Zwiększony licznik u1: " + u1);
        }
    }
}
