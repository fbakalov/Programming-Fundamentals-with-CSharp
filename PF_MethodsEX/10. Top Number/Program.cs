using System;

namespace _10._Top_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            for (int i = 1; i <= n; i++)
            {
                if (IsDivBy8(i) == true && AtLeastOneOdd(i) == true)
                {
                    Console.WriteLine(i);
                }
            }
        }

        static bool IsDivBy8(int number)
        {
            int sumOfDigt = 0;
            while (number != 0)
            {
                sumOfDigt += number % 10;
                number /= 10;
            }

            if (sumOfDigt % 8 == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        static bool AtLeastOneOdd(int number)
        {
            char[] charArr = number.ToString().ToCharArray();
            for (int i = 0; i < charArr.Length; i++)
            {
                int currNum = Convert.ToInt32(charArr[i]);
                if (currNum % 2 != 0)
                {
                    return true;
                }
            }
            return false;
        }
    }
}
