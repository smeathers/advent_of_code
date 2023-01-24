using System;
using System.Collections.Generic;
using System.IO;

// https://adventofcode.com/2022/day/1
// Part1 = 66306
// Part2 = 

namespace Day01
{
    class Program
    {
        static void Main()
        {
            var lines = File.ReadLines("input.txt");
            int answer = Part1(lines);
            Console.WriteLine(answer);
        }

        static int Part1(IEnumerable<string> lines)
        {

            int number = 1;
            int count = 0;
            int bestCount = 0;
            int bestNumber = 0;

            foreach (var line in lines)
            {
                if (int.TryParse(line, out int parsed))
                {
                    //Console.WriteLine("Line: " + line);
                    count += parsed;
                }
                else
                {
                    process(ref number, ref count, ref bestCount, ref bestNumber);
                }
            }

            process(ref number, ref count, ref bestCount, ref bestNumber);

            Console.WriteLine("BestNumber: " + bestNumber);
            Console.WriteLine("BestCount: " + bestCount);
            return bestCount;
        }

        static void process(ref int number, ref int count, ref int bestCount, ref int bestNumber)
        {
            //Console.WriteLine("Number: " + number);
            //Console.WriteLine("Count: " + count);
            //Console.WriteLine("");
            if (count > bestCount)
            {
                bestCount = count;
                count = 0;
                bestNumber = number;
                number++;
            }
            else
            {
                count = 0;
                number++;
            }
        }

    }
}
