using System;

namespace _05._Login
{
    class Program
    {
        static void Main(string[] args)
        {
            string ussername = Console.ReadLine();
            string password = "";
            string passTry = "";

            for (int i = ussername.Length - 1; i >= 0; i--)
            {
                password += ussername[i];
            }

            for (int i = 1; i <= 4; i++)
            {
                passTry = Console.ReadLine();

                if (passTry == password)
                {
                    Console.WriteLine($"User {ussername} logged in.");
                    return;
                }
                else
                {
                    if (i == 4)
                    {
                        continue;
                    }
                    Console.WriteLine("Incorrect password. Try again.");
                }
            }
            Console.WriteLine($"User {ussername} blocked!");
        }
    }
}
