using System;

namespace Kalkulator
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Kalkulator kalkulator = new Kalkulator();
            int a = kalkulator.Mnoz(1, 2);
            int b = kalkulator.Dodaj(1, 2);
            int c = kalkulator.Dziel(4, 2);
            int d = kalkulator.Odejmij(1, 2);
            Console.WriteLine("Wynik mnożenia: " + a + "");
            Console.WriteLine("Wynik dodawania: " + b + "");
            Console.WriteLine("Wynik dzielenia: " + c + "");
            Console.WriteLine("Wynik odejmowania: " + d + "");
        }
    }
}