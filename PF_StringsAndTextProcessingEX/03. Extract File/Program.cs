using System;

namespace _03._Extract_File
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] inputs = Console.ReadLine()
                .Split(@"\");

            string[] nameAndExt = inputs[inputs.Length - 1].Split('.');

            string name = nameAndExt[0];
            string ext = nameAndExt[1];

            Console.WriteLine($"File name: {name}");
            Console.WriteLine($"File extension: {ext}");
        }
    }
}
