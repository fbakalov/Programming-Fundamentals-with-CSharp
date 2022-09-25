using System;

namespace _08._Town_Info
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string city = Console.ReadLine();
            int pop = int.Parse(Console.ReadLine());    
            int area = int.Parse(Console.ReadLine());

            Console.WriteLine($"Town {city} has population of {pop} and area {area} square km.");
        }
    }
}
