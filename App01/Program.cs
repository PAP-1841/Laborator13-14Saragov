using System;

namespace App01
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Dati numarul a:");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Dati numarul b:");
            int b = int.Parse(Console.ReadLine());
            int rezultat; rezultat = a / b;
            Console.WriteLine("Rezultatul este: {0}", rezultat);
            Console.ReadKey();
        }
    }
}
