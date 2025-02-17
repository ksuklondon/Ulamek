using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ulamek
{
    public struct Ulamek
    {
        public int Licznik { get; set; }
        public int Mianownik { get; set; }

        public Ulamek(int licznik, int mianownik)
        {
            if (mianownik == 0)
                throw new ArgumentException("Mianownik nie może być równy zero.");

            Licznik = licznik;
            Mianownik = mianownik;
            Skroc();
        }

        // Operator dodawania
        public static Ulamek operator +(Ulamek u1, Ulamek u2)
        {
            return new Ulamek(u1.Licznik * u2.Mianownik + u2.Licznik * u1.Mianownik, u1.Mianownik * u2.Mianownik);
        }

        // Operator odejmowania
        public static Ulamek operator -(Ulamek u1, Ulamek u2)
        {
            return new Ulamek(u1.Licznik * u2.Mianownik - u2.Licznik * u1.Mianownik, u1.Mianownik * u2.Mianownik);
        }

        // Operator mnożenia
        public static Ulamek operator *(Ulamek u1, Ulamek u2)
        {
            return new Ulamek(u1.Licznik * u2.Licznik, u1.Mianownik * u2.Mianownik);
        }

        // Operator dzielenia
        public static Ulamek operator /(Ulamek u1, Ulamek u2)
        {
            if (u2.Licznik == 0)
                throw new DivideByZeroException("Nie można dzielić przez ułamek o liczniku zero.");

            return new Ulamek(u1.Licznik * u2.Mianownik, u1.Mianownik * u2.Licznik);
        }

        // Metoda skracająca ułamek
        public void Skroc()
        {
            int nwd = NWD(Math.Abs(Licznik), Math.Abs(Mianownik));
            Licznik /= nwd;
            Mianownik /= nwd;
        }

        // Metoda zwracająca NWD dla dwóch liczb
        public static int NWD(int a, int b)
        {
            while (b != 0)
            {
                int t = b;
                b = a % b;
                a = t;
            }
            return a;
        }

        // Metoda konwertująca ułamek na liczbę zmiennoprzecinkową
        public double ToDouble()
        {
            return (double)Licznik / Mianownik;
        }

        // Statyczna metoda zwiększająca licznik ułamka
        public static void ZwiekszLicznik(ref Ulamek ulamek)
        {
            ulamek.Licznik++;
            ulamek.Skroc();
        }

        // Metoda ToString przeciążona do reprezentacji tekstowej ułamka
        public override string ToString()
        {
            return $"{Licznik} / {Mianownik}";
        }
    }
}
