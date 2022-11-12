using System;
using System.Text;

namespace _06._Replace_Repeating_Chars
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string toRemoveRep = string.Empty;
            string output = string.Empty;
            for (int i = 0; i < input.Length; i++)
            {
                if (i + 1 >= input.Length)
                {
                    output += input[i];
                    break;
                }
                if (input[i] == input[i + 1])
                {
                    toRemoveRep += input[i];
                    if (i + 2 < input.Length)
                    {
                        if (input[i + 1] != input[i + 2])
                        {
                            toRemoveRep += input[i];
                            toRemoveRep = string.Empty;
                        }
                    }
                   
                }
                else
                {
                    output += input[i];
                }
            }
            Console.WriteLine(output);
        }
    }
}
