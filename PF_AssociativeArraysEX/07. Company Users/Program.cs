using System;
using System.Collections.Generic;

namespace _07._Company_Users
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, List<string>> companyUsers = new Dictionary<string, List<string>>();

            string input;
            while ((input = Console.ReadLine()) != "End")
            {
                string[] comnArgs = input.Split(" -> ");
                string company = comnArgs[0];
                string user = comnArgs[1];

                if (!companyUsers.ContainsKey(company))
                {
                    companyUsers.Add(company, new List<string>());
                    companyUsers[company].Add(user);
                }
                else
                {
                    if (!companyUsers[company].Contains(user))
                    {
                        companyUsers[company].Add(user);
                    }
                }
            }

            foreach (var item in companyUsers)
            {
                Console.WriteLine($"{item.Key}");
                Console.Write("-- ");
                Console.Write(string.Join($"{Environment.NewLine}-- ", item.Value));
                Console.WriteLine();
            }
        }
    }
}
