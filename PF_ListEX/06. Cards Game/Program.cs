using System;
using System.Collections.Generic;
using System.Linq;

namespace _06._Cards_Game
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> playerA = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();

            List<int> playerB = Console.ReadLine()
               .Split()
               .Select(int.Parse)
               .ToList();

            while (playerA.Count > 0 && playerB.Count > 0)
            {
                if (playerA[0] > playerB[0])
                {
                    (playerA, playerB) = CardShuffleWhenHandIsWon(playerA, playerB);
                }
                else if (playerA[0] < playerB[0])
                {
                    (playerA, playerB) = CardShuffleWhenHandIsWon(playerA, playerB);
                }
                else
                {
                    playerA.RemoveAt(0);
                    playerB.RemoveAt(0);
                }
            }

            if (playerB.Count == 0)
            {
                Console.WriteLine($"First player wins! Sum: {playerA.Sum()}");
            }
            else
            {
                Console.WriteLine($"Second player wins! Sum: {playerB.Sum()}");
            }
        }

        static (List<int>, List<int>) CardShuffleWhenHandIsWon(List<int> winningDeck, List<int> losingDeck)
        {
            winningDeck.Add(winningDeck[0]);
            winningDeck.Add(losingDeck[0]);
            winningDeck.RemoveAt(0);
            losingDeck.RemoveAt(0);
            return (winningDeck, losingDeck);
        }
    }
}

