using System;

namespace _09._Chars_to_String
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char a = char.Parse(Console.ReadLine());
            char b = char.Parse(Console.ReadLine());
            char c = char.Parse(Console.ReadLine());

            string ch = Char.ToString(a) + Char.ToString(b) + Char.ToString(c);
            Console.WriteLine(ch);
        }
    }
}
