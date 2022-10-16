using System;
using System.Collections.Generic;
using System.Linq;

namespace _08._Anonymous_Threat
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> inputs = Console.ReadLine()
                                .Split()
                                .ToList();
            string command;
            while ((command = Console.ReadLine()) != "3:1")
            {
                string[] comndArr = command.Split();

                if (comndArr[0] == "merge")
                {
                    int startIndex = int.Parse(comndArr[1]);
                    int endIndex = int.Parse(comndArr[2]);
                    inputs = Merge(inputs, startIndex, endIndex);
                }
                else if (comndArr[0] == "divide")
                {
                    int index = int.Parse(comndArr[1]);
                    int portions = int.Parse(comndArr[2]);
                    inputs = Divide(inputs, index, portions);
                }
            }

            Console.WriteLine(string.Join(" ", inputs));
        }

        static List<string> Divide(List<string> inputs, int index, int portions)
        {
            string divString = inputs[index];

            char[] charStr = divString.ToCharArray();

            int charsInPort = charStr.Length / portions;

            int counter = 0;
            string port = "";
            List<string> divadedStr = new List<string>();
            for (int i = 0; i < charStr.Length; i++)
            {
                counter++;
                if (counter <= charsInPort)
                {
                    port += charStr[i].ToString();
                }
                else
                {
                    divadedStr.Add(port);
                    counter = 0;
                    port = "";
                    i--;
                }
            }

            if (port != "" && port.Length == 1)
            {
                divadedStr[divadedStr.Count - 1] += port; 
            }
            else
            {
                divadedStr.Add(port);
            }

            inputs.RemoveAt(index);
            inputs.InsertRange(index, divadedStr);

            return inputs;
        }

        static List<string> Merge(List<string> inputs, int startIndex, int endIndex)
        {
            while (startIndex < 0)
            {
                startIndex++;
            }

            while (endIndex > inputs.Count - 1)
            {
                endIndex--;
            }

            for (int i = startIndex; i < endIndex; i++)
            {
                inputs[i] += inputs[i + 1];
                inputs.RemoveAt(i + 1);
                i--;
                endIndex--;           
            }

            return inputs;
        }
    }
}
