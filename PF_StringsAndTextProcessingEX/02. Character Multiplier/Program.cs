using System;

namespace _02._Character_Multiplier
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] inputs = Console.ReadLine()
                .Split();

            int output = MultiplyStrs(inputs[0], inputs[1]);
            Console.WriteLine(output);
        }

        private static int MultiplyStrs(string str1, string str2)
        {
            char[] longer = null;
            char[] shorter = null;

            if (str1.Length < str2.Length)
            {
                longer = str2.ToCharArray();
                shorter = str1.ToCharArray();
            }
            else
            {
                longer = str1.ToCharArray();
                shorter = str2.ToCharArray();
            }

            int whSum = 0;

            for (int i = 0; i < longer.Length; i++)
            {
                if (shorter.Length > i)
                {
                    whSum += longer[i] * shorter[i];
                }
                else
                {
                    whSum += longer[i];
                }
            }

            return whSum;
        }
    }
}
