using System;
using System.Collections.Generic;
using System.Linq;

namespace _01._Valid_Usernames
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> usernames = Console.ReadLine()
                .Split(", ")
                .ToList();

            for (int i = 0; i < usernames.Count; i++)
            {
                char[] charArr = usernames[i].ToCharArray();
                if (charArr.Length >= 3 && charArr.Length <= 16)
                {
                    bool validUsername = charArr.All(t => Char.IsLetterOrDigit(t) || t.Equals('_') || t.Equals('-'));
                    if (validUsername)
                    {
                        string output = new string(charArr);
                        Console.WriteLine(output);
                    }
                }                             
            }
        }
    }
}
