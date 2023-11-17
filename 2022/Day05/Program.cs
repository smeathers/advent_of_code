// https://adventofcode.com/2022/day/5
// Part1 = 
// Part2 = 

namespace Day05
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var lines = File.ReadLines("example.txt");
            string answer = Part1(lines);
            Console.WriteLine(answer); 
        }

        static string Part1(IEnumerable<string> lines)
        {
            List<char>[] boat = new List<char>[(lines.First().Length + 1) / 4];

            foreach (var line in lines)
            {
                if (line.Contains("["))
                    for (int i = 1; i <= lines.First().Length; i += 4)
                    {
                        Console.WriteLine(i);
                        var value = char.Parse(line.Substring(i, 1));
                        Console.WriteLine(value);
                        if (value != ' ')
                            boat[i - 3].Add(value);
                    }
            }
            Console.WriteLine("Hello, World!");
            return "";
        }
    }
}