using System;
using System.Collections.Generic;
using System.IO;

// https://adventofcode.com/2021/day/1
// Part1 = 1477
// Part2 = 1523

namespace Day01
{
    class Program
    {
        static void Main()
        {
            var lines = File.ReadLines("input.txt");
            Part1(lines);
            Console.WriteLine("Hello World!");
        }

        static void Part1(IEnumerable<string> lines)
        {

            int number = 1;
            int bestCount = 0;
            int bestNumber = 0;
            int count = 0;

            foreach (var line in lines)
            {

                
                if (int.TryParse(line, out int temp))
                {
                    Console.WriteLine("Line: " + line);
                    count += temp;
                }
                else if (count > bestCount)
                {
                    
                    Console.WriteLine("Number: " + number);
                    Console.WriteLine("Count: " + count);
                    Console.WriteLine("");
                    bestCount = count;
                    count = 0;
                    bestNumber = number;
                    number++;
                }
                else
                {
                    Console.WriteLine("Number: " + number);
                    Console.WriteLine("Count: " + count);
                    Console.WriteLine("");
                    count = 0;
                    number++;
                }
            }

            if (count > bestCount)
            {

                Console.WriteLine("Number: " + number);
                Console.WriteLine("Count: " + count);
                Console.WriteLine("");
                bestCount = count;
                count = 0;
                bestNumber = number;
                number++;
            }
            else
            {
                Console.WriteLine("Number: " + number);
                Console.WriteLine("Count: " + count);
                Console.WriteLine("");
                count = 0;
                number++;
            }

            Console.WriteLine("BestNumber: " + bestNumber);
            Console.WriteLine("BestCount: " + bestCount);
        }

    }
}
