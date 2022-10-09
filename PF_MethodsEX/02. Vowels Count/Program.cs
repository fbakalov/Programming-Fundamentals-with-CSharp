using System;

namespace _02._Vowels_Count
{
    class Program
    {
        static void Main(string[] args)
        {
            string inputStr = Console.ReadLine();
            Console.WriteLine(VowelCount(inputStr));
        }

        static int VowelCount(string str)
        {
            char[] charStr = str.ToCharArray();
            int couter = 0;
            for (int i = 0; i < charStr.Length; i++)
            {
                if (charStr[i] == 65 || charStr[i] == 69 || charStr[i] == 73 || 
                    charStr[i] == 79 || charStr[i] == 85 || charStr[i] == 89 || 
                    charStr[i] == 97 || charStr[i] == 101 || charStr[i] == 105 || 
                    charStr[i] == 111 || charStr[i] == 117 || charStr[i] == 121)
                {
                    couter++;
                }
            }

            return couter;
        }
    }
}
