using System;
using System.Text.RegularExpressions;
using System.Collections.Generic;
using System.Linq;

namespace _02._Race
{
    class Program
    {
        static void Main(string[] args)
        {
            string patternForLetter = @"[A-Za-z]";
            string patternForDigit = @"[0-9]";
            Regex regexLetter = new Regex(patternForLetter);
            Regex regexDigit = new Regex(patternForDigit);

            Dictionary<string, double> trackedRacers = new Dictionary<string, double>();

            List<string> players = Console.ReadLine()
                .Split(", ")
                .ToList();

            foreach (string player in players)
            {
                if (!trackedRacers.ContainsKey(player))
                {
                    trackedRacers[player] = 0;
                }
            }

            string inputLine;
            while ((inputLine = Console.ReadLine()) != "end of race")
            {
                MatchCollection letters = regexLetter.Matches(inputLine);
                
                string name = string.Empty;
                foreach (Match letter in letters)
                {
                    name += letter.Value;
                }

                
                if (trackedRacers.ContainsKey(name))
                {
                    MatchCollection digits = regexDigit.Matches(inputLine);

                    double distance = 0;
                    foreach (Match digit in digits)
                    {
                        distance += double.Parse(digit.Value);
                    }
                   
                    trackedRacers[name] += distance;
                }
                
            }

            var ordered = trackedRacers.OrderByDescending(x => x.Value).Take(3);

            int count = 1;
            foreach (var item in ordered)
            {
                string place = count == 1 ? "st" : count == 2 ? "nd" : "rd";
                Console.WriteLine($"{count}{place} place: {item.Key}");
                count++;
            }
        }
    }
}
