﻿using System;
using System.Text.RegularExpressions;

namespace WinningTicket
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            string pattern = @">>([A-z]+)<<([\d+.?]+)!(\d+)";
            Regex regex = new Regex(pattern);

            string input = Console.ReadLine();
            double sum = 0;

            Console.WriteLine("Bought furniture:");

            while (input != "Purchase")
            {
                Match match = regex.Match(input);

                if (match.Success)
                {
                    string name = match.Groups[1].Value;
                    double price = double.Parse(match.Groups[2].Value);
                    int quantity = int.Parse(match.Groups[3].Value);

                    sum += price * quantity;

                    Console.WriteLine(name);
                }

                input = Console.ReadLine();
            }

            Console.WriteLine($"Total money spend: {sum:f2}");
        }
    }
}
