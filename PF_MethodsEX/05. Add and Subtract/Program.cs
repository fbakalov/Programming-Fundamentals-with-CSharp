using System;

namespace _05._Add_and_Subtract
{
    class Program
    {
        static void Main(string[] args)
        {
            int number1 = int.Parse(Console.ReadLine());
            int number2 = int.Parse(Console.ReadLine());
            int number3 = int.Parse(Console.ReadLine());

            int sum = SumFirstTwo(number1, number2);
            Console.WriteLine(SubtractSum(sum, number3));
        }

        static int SumFirstTwo(int number1, int number2)
        {
            return number1 + number2;
        }

        static int SubtractSum(int sum, int number3)
        {
            return sum - number3;
        }
    }
}
