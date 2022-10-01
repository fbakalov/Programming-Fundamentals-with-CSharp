using System;
using System.Linq;

namespace _06._Equal_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = Console.ReadLine().Split().Select(int.Parse).ToArray();
         
            bool doesntHave = true;
            for (int i = 0; i < arr.Length; i++)
            { 
                int sumR = 0;
                int sumL = 0;
                for (int k = 0; k < i; k++)
                {
                    sumL += arr[k];
                }
                for (int j = arr.Length - 1; j > i; j--)
                {
                    sumR += arr[j];
                }  
                
                if (sumL == sumR)
                {
                    Console.WriteLine(i);
                    return;
                }
            }

            if (doesntHave)
            {
                Console.WriteLine("no");
            }
        }
    }
}
