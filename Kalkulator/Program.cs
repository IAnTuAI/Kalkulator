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
            Console.WriteLine(a + " " + b);
        }
    }
}