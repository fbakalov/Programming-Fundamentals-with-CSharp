using System;

namespace _08._Beer_Kegs
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            string winner = "";
            double max = 0;
            for (int i = 1; i <= n; i++)
            {
                string type = Console.ReadLine();

                double rad = double.Parse(Console.ReadLine());
                int height = int.Parse(Console.ReadLine());
                double vol = Math.PI * (rad * rad) * height;
               
                if (max < vol)
                {
                    max = vol;
                    winner = type;
                }
            }
            Console.WriteLine(winner);
        }
    }
}
