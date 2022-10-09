using System;
using System.Linq;

namespace _11._Array_Manipulator
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            string command = null;
            while ((command = Console.ReadLine()) != "end")
            {
                string[] cmdArgs = command
                    .Split(' ');

                if (cmdArgs[0] == "exchange")
                {
                    if (Exchange(numbers, cmdArgs[1]) == null)
                    {
                        Console.WriteLine("Invalid index");
                    }
                    else
                    {
                        int[] exchangedArr = Exchange(numbers, cmdArgs[1]);
                        Console.WriteLine("[" + string.Join(", ", exchangedArr) + "]");
                    }
                    
                }


                if (cmdArgs[0] == "max" && cmdArgs[1] == "even")
                {
                    int inex = MaxEven(numbers);
                    if (inex == 0 && numbers[inex] % 2 != 0)
                    {
                        Console.WriteLine("No matches");
                        break;
                    }
                    Console.WriteLine(inex);
                }
                else if (cmdArgs[0] == "min" && cmdArgs[1] == "even")
                {
                    int inex = MinEven(numbers);
                    if (inex == 0 && numbers[inex] % 2 != 0)
                    {
                        Console.WriteLine("No matches");
                        break;
                    }
                    Console.WriteLine(inex);
                }

                if (cmdArgs[0] == "max" && cmdArgs[1] == "odd")
                {
                    int inex = MaxOdd(numbers);
                    if (inex == 0 && numbers[inex] % 2 == 0)
                    {
                        Console.WriteLine("No matches");
                        break;
                    }
                    Console.WriteLine(inex);
                }
                else if (cmdArgs[0] == "min" && cmdArgs[1] == "odd")
                {
                    int inex = MinOdd(numbers);
                    if (inex == 0 && numbers[inex] % 2 == 0)
                    {
                        Console.WriteLine("No matches");
                        break;
                    }
                    Console.WriteLine(inex);
                }


                if (cmdArgs[0] == "first")
                {
                    if (cmdArgs[2] == "even")
                    {                     
                        if (FirstCntEven(numbers, int.Parse(cmdArgs[1])) == null)
                        {
                            Console.WriteLine("Invalid count");
                        }
                        else
                        {
                            int[] firstCnt = FirstCntEven(numbers, int.Parse(cmdArgs[1]));
                            Console.WriteLine("[" + string.Join(", ", firstCnt) + "]");
                        } 
                        
                        if (FirstCntEven(numbers, int.Parse(cmdArgs[1]))[0] == 0)
                        {
                            Console.WriteLine("[]");
                            break;
                        }
                    }
                    else if (cmdArgs[2] == "odd")
                    {
                        if (FirstCntOdd(numbers, int.Parse(cmdArgs[1])) == null)
                        {
                            Console.WriteLine("Invalid count");
                        }
                        else
                        {
                            int[] firstCnt = FirstCntOdd(numbers, int.Parse(cmdArgs[1]));
                            Console.WriteLine("[" + string.Join(", ", firstCnt) + "]");
                        }

                        if (FirstCntOdd(numbers, int.Parse(cmdArgs[1]))[0] == 0)
                        {
                            Console.WriteLine("[]");
                            break;
                        }
                    }
                }
                else if (cmdArgs[0] == "last")
                {
                    if (cmdArgs[2] == "even")
                    {

                    }
                    else if (cmdArgs[2] == "odd")
                    {

                    }
                }
            }
            
        }

        static int[] Exchange(int[] numbers, string inputIndex)
        {
            int index = Convert.ToInt32(inputIndex);

            if (index > numbers.Length || index < numbers[0])
            {
                return null;
            }

            int[] arrBeforeIndex = new int[index + 1];
            int[] arrAfterIndex = new int[numbers.Length - index - 1];
            int couter = 0;
            for (int i = 0; i < numbers.Length; i++)
            {                
                if (i <= index)
                {
                    arrBeforeIndex[i] = numbers[i];
                    couter++;
                }
            }
            for (int j = 0; j < numbers.Length - couter; j++)
            {
                arrAfterIndex[j] = numbers[j + couter];
            }

            int[] newArr = arrAfterIndex.Concat(arrBeforeIndex).ToArray();
            return newArr;
        }

        static int MaxEven(int[] numbers)
        {
            int max = 0;
            int index = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] % 2 == 0)
                {
                    if (max < numbers[i])
                    {
                        max = numbers[i];
                        index = i;
                    }
                }
            }
            return index;
        }

        static int MinEven(int[] numbers)
        {
            int min = 0;
            int index = 0;
            int currNum = 0;
            bool isFirst = true;
            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] % 2 == 0)
                {
                    currNum = numbers[i];
                    if (isFirst)
                    {
                        min = currNum;
                        isFirst = false;
                    }
                }
                if (min > currNum)
                {
                    min = currNum;
                    index = i;
                }
            }
            return index;
        }

        static int MaxOdd(int[] numbers)
        {
            int max = 0;
            int index = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] % 2 != 0)
                {
                    if (max < numbers[i])
                    {
                        max = numbers[i];
                        index = i;
                    }
                }
            }
            return index;
        }

        static int MinOdd(int[] numbers)
        {
            int min = 0;
            int index = 0;
            int currNum = 0;
            bool isFirst = true;
            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] % 2 != 0)
                {
                    currNum = numbers[i];
                    if (isFirst)
                    {
                        min = currNum;
                        isFirst = false;
                    }
                }
                if (min > currNum)
                {
                    min = currNum;
                    index = i;
                }
            }
            return index;
        }

        static int[] FirstCntEven(int[] numbers, int countOfNumbers)
        {
            int[] endArr = new int[countOfNumbers];

            if (numbers.Length < countOfNumbers || countOfNumbers < numbers[0])
            {
                return null;
            }

            int counter = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] % 2 == 0 && countOfNumbers >= counter)
                {
                    endArr[counter] = numbers[i];
                    counter++;
                }
            }

            return endArr;
        }

        static int[] FirstCntOdd(int[] numbers, int countOfNumbers)
        {
            int[] endArr = new int[countOfNumbers];

            if (numbers.Length < countOfNumbers || countOfNumbers < numbers[0])
            {
                return null;
            }

            int counter = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] % 2 != 0 && countOfNumbers >= counter)
                {
                    endArr[counter] = numbers[i];
                    counter++;
                }
            }

            return endArr;
        }
    }
}
