﻿// https://adventofcode.com/2023/day/1
// Part1 = 54877
// Part2 = 

using System.Linq;
using System.Threading;

namespace Day01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var lines = File.ReadLines("input.txt");
            int answer = Part1(lines);
            Console.WriteLine(answer);
        }

        static int Part1(IEnumerable<string> lines)
        {
            int answer = 0;

            foreach (var line in lines)
            {
                int result;
                string first = "", last = "";

                foreach (var character in line)
                {
                    if (int.TryParse(character.ToString(), out result) && first == "")
                        first = result.ToString();
                    if (int.TryParse(character.ToString(), out result))
                        last = result.ToString();
                }
                answer += int.Parse(first.ToString() + last.ToString());
            }

            return answer;
        }

        static int Part2(IEnumerable<string> lines)
        {
            int answer = 0;
            string[] words = { "one", "two", "three", "four", "five", "six", "seven", "eight", "nine" };

            foreach (var line in lines)
            {
                int result;
                string first = "", last = "";

                foreach (var word in words)
                {
                    //string.
                }

                foreach (var character in line)
                {
                    Console.Write(character);
                }
                Console.WriteLine();







                foreach (var character in line.Reverse())
                {
                    Console.Write(character);
                }
                answer += int.Parse(first.ToString() + last.ToString());
            }

            return answer;
        }
    }

}