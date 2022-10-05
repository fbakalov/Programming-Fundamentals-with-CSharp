using System;

namespace _10._Multiply_Evens_by_Odds
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            int absValue = Math.Abs(int.Parse(input));


            int sumOfOdd = SumOdd(absValue.ToString());
            int sumOfEven = SumEven(absValue.ToString());

            int result = sumOfEven * sumOfOdd;
            Console.WriteLine(result);
        }

        static int SumOdd(string input)
        {
            int sum = 0;
            for (int i = 0; i < input.Length; i++)
            {
                int currNum = int.Parse(input[i].ToString());
                if (currNum % 2 != 0)
                {
                    sum += currNum;
                }                
            }
            return sum;
        }

        static int SumEven(string input)
        {
            int sum = 0;
            for (int i = 0; i < input.Length; i++)
            {
                int currNum = int.Parse(input[i].ToString());
                if (currNum % 2 == 0)
                {
                    sum += currNum;
                }
            }
            return sum;
        }
    }
}
