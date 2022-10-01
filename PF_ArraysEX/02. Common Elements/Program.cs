using System;
using System.Linq;

namespace _02._Common_Elements
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] firstArr = Console.ReadLine()
                .Split()
                .ToArray();

            string[] secndArr = Console.ReadLine()
                .Split()
                .ToArray();
           
            for (int i = 0; i < secndArr.Length; i++)
            {
                string currValue = secndArr[i];
                for (int j = 0; j < firstArr.Length; j++)
                {
                    if (currValue == firstArr[j])
                    {
                        Console.Write(currValue + " ");
                    }
                }
            }
        }
    }
}
