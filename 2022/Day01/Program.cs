using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

// https://adventofcode.com/2022/day/1
// Part1 = 66306
// Part2 = 195292

namespace Day01
{
    class Program
    {
        static void Main()
        {
            var lines = File.ReadLines("input.txt");
            int answer = Part2(lines);
            Console.WriteLine(answer);
        }

        static public int Part1(IEnumerable<string> lines)
        {

            int number = 1;
            int count = 0;
            int bestCount = 0;
            int bestNumber = 0;

            foreach (var line in lines)
            {
                if (int.TryParse(line, out int parsed))
                    count += parsed;
                else
                    process(ref number, ref count, ref bestCount, ref bestNumber);
            }

            process(ref number, ref count, ref bestCount, ref bestNumber);

            Console.WriteLine("BestNumber: " + bestNumber);
            Console.WriteLine("BestCount: " + bestCount);

            return bestCount;
        }

        static public int Part2(IEnumerable<string> lines)
        {
            //List<int> output;
            var output = new List<int>();
            int current = 0;
            int count = 3;

            foreach (var line in lines)
            {
                if (int.TryParse(line, out int parsed))
                    current += parsed;
                else
                {
                    output.Add(current);
                    current = 0;
                }
            }
            if (current != 0)
                output.Add(current);

            Console.WriteLine();
            output = output.OrderByDescending(i => i).ToList();

            foreach (var item in output)
            {
                Console.WriteLine(item);
            }

            int total = 0;
            for (int i = 0; i < count; i++)
                total += output[i];

            return total;
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
