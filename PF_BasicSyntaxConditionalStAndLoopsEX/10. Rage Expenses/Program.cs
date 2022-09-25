using System;

namespace _10._Rage_Expenses
{
    class Program
    {
        static void Main(string[] args)
        {
            int lostGames = int.Parse(Console.ReadLine());
            double headsetPrice = double.Parse(Console.ReadLine());
            double mousePrice = double.Parse(Console.ReadLine());
            double keyboardPrice = double.Parse(Console.ReadLine());
            double displayPrice = double.Parse(Console.ReadLine());

            int headsetCnt = 0;
            int mouseCnt = 0;
            int keyboardCnt = 0;
            int displayCnt = 0;
            for (int i = 1; i <= lostGames; i++)
            {
                if (i % 2 == 0)
                {
                    headsetCnt++;
                }

                if (i % 3 == 0)
                {
                    mouseCnt++;
                }

                if (i % 2 == 0 && i % 3 == 0)
                {
                    keyboardCnt++;
                }

                if (i % 12 == 0)
                {
                    displayCnt++;
                }
            }

            double whLostMoney = (headsetPrice * headsetCnt) + (mousePrice * mouseCnt) + (keyboardPrice * keyboardCnt)
                + (displayPrice * displayCnt);

            Console.WriteLine($"Rage expenses: {whLostMoney:f2} lv.");
        }
    }
}
