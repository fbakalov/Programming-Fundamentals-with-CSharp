using System;

namespace _03._Characters_in_Range
{
    class Program
    {
        static void Main(string[] args)
        {
            char startCh = char.Parse(Console.ReadLine());
            char finshCh = char.Parse(Console.ReadLine());

            if (startCh > finshCh)
            {
                char switcher = startCh;
                startCh = finshCh;
                finshCh = switcher;
            }

            FindASCIIRange(startCh, finshCh);
        }

        static void FindASCIIRange(int start, int finsh)
        {
            for (int i = start + 1; i < finsh; i++)
            {
                Console.Write((char)i + " ");
            }
        }
    }
}
