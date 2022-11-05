using System;
using System.Collections.Generic;
using System.Linq;

namespace _01._Count_Chars_in_a_String
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<char, int> letterCout = new Dictionary<char, int>();

            string inputStr = Console.ReadLine();

            inputStr = string.Join("", inputStr.Split(default(string[]), StringSplitOptions.RemoveEmptyEntries));

            char[] arrCh = inputStr
                .ToCharArray();

            foreach (var currCh in arrCh)
            {
                if (!letterCout.ContainsKey(currCh))
                {
                    letterCout.Add(currCh, 0);
                }

                letterCout[currCh] += 1;
            }

            foreach (var item in letterCout)
            {
                Console.WriteLine($"{item.Key} -> {item.Value}");
            }
        }
    }
}
