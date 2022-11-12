using System;

namespace _04._Caesar_Cipher
{
    class Program
    {
        static void Main(string[] args)
        {
            string inputStr = Console.ReadLine();

            char[] chStr = inputStr.ToCharArray();

            string outputStr = string.Empty;

            for (int i = 0; i < chStr.Length; i++)
            {
                outputStr += (char)(chStr[i] + 3);
            }

            Console.WriteLine(outputStr);
        }
    }
}
