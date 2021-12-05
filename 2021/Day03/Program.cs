using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

// https://adventofcode.com/2021/day/3
// Part1 = 
// Part2 = 

namespace Day03
{
    class Program
    {
        static void Main(string[] args)
        {
            var lines = File.ReadLines("input.txt");
            Console.WriteLine("Part 1 Answer: " + Part1(lines));
        }

        static int Part1(IEnumerable<string> lines)
        {
            
            int[,] counts = new int[lines.First().Length, 2];
            string output = "";

            foreach (var line in lines)
            {
                int lineNum = 0;
                foreach (var value in line.ToArray())
                {
                    switch (value)
                    {
                        case '0':
                            counts[lineNum, 0]++;
                            break;
                        case '1':
                            counts[lineNum, 1]++;
                            break;
                        default:
                            Console.WriteLine("ERROR!");
                            break;
                    }
                    lineNum++;
                }
            }

            for (int i=0; i < lines.First().Length; i++)
            {
                if (counts[i,0] > counts[i,1])
                    output += '0';
                if (counts[i, 0] < counts[i, 1])
                    output += '1';
            }
            Console.WriteLine(output + " " + Convert.ToInt32(output, 2).ToString());
            int gamma = Convert.ToInt32(output, 2);
            int epsilon = Convert.ToInt32(Convert.ToString(~Convert.ToInt32(output, 2), 2)[^lines.First().Length..], 2);
            return gamma * epsilon;
        }
    }
}
