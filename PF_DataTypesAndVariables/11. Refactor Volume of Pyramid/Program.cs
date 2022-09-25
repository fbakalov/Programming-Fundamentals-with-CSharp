using System;

namespace _11._Refactor_Volume_of_Pyramid
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Length: ");

            var length = int.Parse(Console.ReadLine());

            Console.WriteLine("Width: ");

            var widh = int.Parse(Console.ReadLine());

            Console.WriteLine("Heigth: ");

            var height = int.Parse(Console.ReadLine());

            double volume = (double)(length + widh + height) / 3;

            Console.WriteLine($"Pyramid Volume: {volume:f2}");
        }
    }
}
