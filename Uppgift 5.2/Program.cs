using System;

namespace Uppgift
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] tal = new int[3];
            tal[0] = 5;
            tal[1] = 7;
            Console.WriteLine("Skriv ett heltal:");
            tal[2] = int.Parse(Console.ReadLine());
            Console.WriteLine(tal[0] + " " + tal[1] + " " + tal[2]);


        }
    }
}