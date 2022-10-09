using System;

namespace _06._Middle_Characters
{
    class Program
    {
        static void Main(string[] args)
        {
            string inputStr = Console.ReadLine();
            Console.WriteLine(TakeMiddle(inputStr));
        }

        static string TakeMiddle(string inputStr)
        {
            if (inputStr.Length % 2 == 0)
            {
                char[] charOfString = inputStr.ToCharArray();
                int arrLenthDevByTwo = charOfString.Length / 2;
                string outputString = charOfString[arrLenthDevByTwo - 1].ToString() + charOfString[arrLenthDevByTwo].ToString();
                return outputString;
            }
            else
            {
                char[] charOfString = inputStr.ToCharArray();
                char outputString = charOfString[inputStr.Length / 2];
                return outputString.ToString();

            }
        }
    }
}
