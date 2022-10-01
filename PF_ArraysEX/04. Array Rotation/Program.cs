using System;
using System.Linq;

namespace _04._Array_Rotation
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr1 = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            int numOfRotton = int.Parse(Console.ReadLine());

            int lastNum = 0;
            for (int i = 0; i < numOfRotton; i++)
            {
                lastNum = arr1[0];               
                int eq = 0;
                for (int j = 0; j < arr1.Length - 1; j++)
                {
                    arr1[eq] = arr1[eq + 1]; 
                    eq = j + 1;                                      
                }
               arr1[arr1.Length - 1] = lastNum;
            }
            Console.WriteLine(string.Join(" ", arr1));
        }
    }
}
