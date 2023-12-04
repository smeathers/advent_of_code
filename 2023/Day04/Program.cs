// https://adventofcode.com/2023/day/4
// Part1 = 24733
// Part2 = 

namespace Day04
{
    internal class Program
    {

        static IEnumerable<string> Cards = File.ReadLines("example.txt");

        static void Main(string[] args)
        {
            var lines = File.ReadLines("example.txt");
            int answer = Part1(lines);
            Console.WriteLine(answer);
        }

        static int Part1(IEnumerable<string> lines)
        {
            var scoreTotal = 0;

            foreach (var line in lines)
            {
                int score = 0;
                int cardNumber = int.Parse(line.Split(":")[0].Split(" ", StringSplitOptions.RemoveEmptyEntries)[1]);
                var winners = line.Split(":")[1].Split("|")[0].Trim().Split(" ", StringSplitOptions.RemoveEmptyEntries);
                var myNumbers  = line.Split(":")[1].Split("|")[1].Trim().Split(" ", StringSplitOptions.RemoveEmptyEntries);

                foreach (var winner in winners)
                    if (winner.Length > 0)
                        foreach (var number in myNumbers)
                            if (number .Length > 0)
                                if (winner == number)
                                {
                                    if (score == 0)
                                        score = 1;
                                    else
                                        score *= 2;
                                }
                scoreTotal += score;
            }

            return scoreTotal;
        }

        static int Part2(IEnumerable<string> lines)
        {
            var scoreTotal = 0;

            foreach (var line in lines)
            {
                int score = 0;
                //int cardNumber = int.Parse(line.Split(":")[0].Split(" ", StringSplitOptions.RemoveEmptyEntries)[1]);
                var winners = line.Split(":")[1].Split("|")[0].Trim().Split(" ", StringSplitOptions.RemoveEmptyEntries);
                var myNumbers = line.Split(":")[1].Split("|")[1].Trim().Split(" ", StringSplitOptions.RemoveEmptyEntries);

                foreach (var winner in winners)
                    if (winner.Length > 0)
                        foreach (var number in myNumbers)
                            if (number.Length > 0)
                                if (winner == number)
                                    score += 1;

                scoreTotal += score;
            }

            return scoreTotal;
        }

        static void processCard (int cardNumber)
        {
        }


    }
}