using System;
using System.Collections.Generic;
using System.IO;

// https://adventofcode.com/2021/day/2
// Part1 = 2027977
// Part2 = 1903644897

namespace Day02
{
    class Program
    {
        static void Main(string[] args)
        {
            var lines = File.ReadLines("input.txt");
            Console.WriteLine("Part 1 Answer: " + Part1(lines));
            Console.WriteLine("Part 2 Answer: " + Part2(lines));
        }

        static int Part1(IEnumerable<string> lines)
        {
            int horizontal = 0;
            int depth = 0;

            foreach (var line in lines)
            {
                string direction = line.Split(" ")[0];
                int distance = int.Parse(line.Split(" ")[1]);
                switch (direction)
                {
                    case "forward":
                        horizontal += distance;
                        break;
                    case "up":
                        depth -= distance;
                        break;
                    case "down":
                        depth += distance;
                        break;
                    default:
                        Console.WriteLine("ERROR!");
                        break;
                }
                //Console.WriteLine("horizontal: " + horizontal + " depth: " + depth);
            }
            return horizontal * depth;
        }

        static int Part2(IEnumerable<string> lines)
        {
            int horizontal = 0;
            int depth = 0;
            int aim = 0;

            foreach (var line in lines)
            {
                string direction = line.Split(" ")[0];
                int distance = int.Parse(line.Split(" ")[1]);
                switch (direction)
                {
                    case "forward":
                        horizontal += distance;
                        depth += (aim * distance);
                        break;
                    case "up":
                        aim -= distance;
                        break;
                    case "down":
                        aim += distance;
                        break;
                    default:
                        Console.WriteLine("ERROR!");
                        break;
                }
                //Console.WriteLine("horizontal: " + horizontal + " depth: " + depth + " aim: " + aim);
            }
            return horizontal * depth;
        }
    }
}
