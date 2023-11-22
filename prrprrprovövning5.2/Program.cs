using System;

namespace prrprrprovCA52
{
    class Program
    {
        static void Main(string[] args)
        {
        Console.WriteLine("Hur många tal vill du skriva in?");
        int[] tal = new int[int.Parse(Console.ReadLine())];
        for(int i = 0; i < tal.Length; i++)
        {
            Console.WriteLine("Skriv in " + (i+1) + " heltal");
            tal[i] = int.Parse(Console.ReadLine());
        }
        Console.WriteLine("Här är talen du skrev in");
        for (int i = 0;i < tal.Length; i++)
        {
            Console.WriteLine("Tal " + (i+1) + ": " + tal[i]);
        }
        }
    }
}
