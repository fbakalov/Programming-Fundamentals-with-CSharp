using System;

namespace _03._Substring
{
    class Program
    {
        static void Main(string[] args)
        {
            string line = Console.ReadLine();
            string longLine = Console.ReadLine();

            int index = longLine.IndexOf(line);

            while (index != -1)
            {
                longLine = longLine.Remove(index, line.Length);
                index = longLine.IndexOf(line);
            }

            Console.WriteLine(longLine);
        }
    }
}
