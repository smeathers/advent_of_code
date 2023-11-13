using System.ComponentModel.DataAnnotations;

// https://adventofcode.com/2022/day/3
// Part1 = 7980
// Part2 = 2881

namespace Day03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var lines = File.ReadLines("input.txt");
            int answer = Part2(lines);
            Console.WriteLine(answer);
        }

        static public int Part1(IEnumerable<string> lines)
        {
            var total = 0;
            foreach (var line in lines)
            {
                var A = line.Substring(0, line.Length / 2);
                var B = line.Substring(line.Length / 2);

                var output = 0;

                foreach (var itemA in A)
                    foreach (var itemB in B)
                        if (itemA.Equals(itemB))
                            if (itemA.ToString().Any(char.IsUpper))
                                output = itemA - 38;
                            else
                                output = itemA - 96;

                total += output;
            }
            return total;
        }

        static public int Part2(IEnumerable<string> lines)
        {
            var total = 0;
            for (int i = 0; i < lines.Count(); i=i+3)
            {
                var A = lines.ToArray()[i];
                var B = lines.ToArray()[i + 1];
                var C = lines.ToArray()[i + 2];


                var output = 0;

                foreach (var itemA in A)
                    foreach (var itemB in B)
                        if (itemA.Equals(itemB))
                            foreach(var itemC in C)
                                if (itemA.Equals(itemC))
                                    if (itemA.ToString().Any(char.IsUpper))
                                        output = itemA - 38;
                                    else
                                        output = itemA - 96;
                total += output;
            }
            return total;
        }
    }
}