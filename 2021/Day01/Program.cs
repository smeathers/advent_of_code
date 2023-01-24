using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

// https://adventofcode.com/2022/day/1
// Part1 = 66306
// Part2 = 

namespace Day01
{
    class Program
    {
        static void Main(string[] args)
        {
            var lines = File.ReadLines("input.txt");
            Part1(lines);
            Part2(lines);
        }

        static void Part1(IEnumerable<string> lines)
        {
            int? number = null;
            int count = 0;

            foreach (var line in lines)
            {
                int current = int.Parse(line);
                if (number is null)
                    number = current;
                else if (current > number)
                    count++;

                number = current;

            }
            Console.WriteLine("Answer: " + count);
        }

        static void Part2(IEnumerable<string> lines)
        {
            int? number = null;
            List<string> sumNumbers = new List<string>();

            var newLines = lines.ToArray();

            for (int i=2; i < newLines.Count(); i++)
            {
                int current = int.Parse(newLines[i]) + int.Parse(newLines[i - 1]) + int.Parse(newLines[i - 2]);
                sumNumbers.Add(current.ToString());
                
                if (number is null)
                    number = current;
                else if (current > number)
                    number = current;
            }

            Part1(sumNumbers);
        }

    }
}
