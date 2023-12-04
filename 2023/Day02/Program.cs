// https://adventofcode.com/2023/day/2
// Part1 = 3035
// Part2 = 66027

namespace Day02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var lines = File.ReadLines("input.txt");
            int answer = Part2(lines);
            Console.WriteLine(answer);
        }

        static int Part1(IEnumerable<string> lines)
        {
            var gamesCount = 0;
            int maxR = 12, maxG = 13, maxB = 14;

            foreach (var line in lines)
            {
                int gameNumber = int.Parse(line.Split(":")[0].Split(" ")[1]);
                bool possible = true;

                foreach (var game in line.Split(":")[1].Split(";"))
                    foreach(var round in game.Split(","))
                    {
                        if (round.Contains("red") && (int.Parse(round.Trim().Split(" ")[0]) > maxR))
                            possible = false;
                        if (round.Contains("green") && (int.Parse(round.Trim().Split(" ")[0]) > maxG))
                            possible = false;
                        if (round.Contains("blue") && (int.Parse(round.Trim().Split(" ")[0]) > maxB))
                            possible = false;
                    }

                if (possible)
                    gamesCount += gameNumber;
            }

            return gamesCount;
        }

        static int Part2(IEnumerable<string> lines)
        {
            var gamesCount = 0;

            foreach (var line in lines)
            {
                int gameNumber = int.Parse(line.Split(":")[0].Split(" ")[1]);
                int maxR = 0, maxG = 0, maxB = 0;

                foreach (var game in line.Split(":")[1].Split(";"))
                    foreach (var round in game.Split(","))
                    {
                        if (round.Contains("red") && (int.Parse(round.Trim().Split(" ")[0]) > maxR))
                            maxR = int.Parse(round.Trim().Split(" ")[0]);
                        if (round.Contains("green") && (int.Parse(round.Trim().Split(" ")[0]) > maxG))
                            maxG = int.Parse(round.Trim().Split(" ")[0]);
                        if (round.Contains("blue") && (int.Parse(round.Trim().Split(" ")[0]) > maxB))
                            maxB = int.Parse(round.Trim().Split(" ")[0]); ;
                    }

                gamesCount += (maxR * maxG * maxB);
            }

            return gamesCount;
        }

    }
}