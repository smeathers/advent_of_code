
// https://adventofcode.com/2022/day/4
// Part1 = 605
// Part2 = 914

namespace Day04
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
            
            int total  = 0;
            foreach (var line in lines)
            {
                bool overlap = false;
                var A1 = int.Parse(line.Split(",")[0].Split("-")[0]);
                var A2 = int.Parse(line.Split(",")[0].Split("-")[1]);
                var B1 = int.Parse(line.Split(",")[1].Split("-")[0]);
                var B2 = int.Parse(line.Split(",")[1].Split("-")[1]);

                if (A1 <= B1 && A2 >= B2)
                    overlap = true;
                if (A1 >= B1 && A2 <= B2)
                    overlap = true;
                if (overlap)
                    total += 1;
            }
            return total;
        }

        static int Part2(IEnumerable<string> lines)
        {

            int total = 0;
            foreach (var line in lines)
            {
                bool overlap = false;
                var A1 = int.Parse(line.Split(",")[0].Split("-")[0]);
                var A2 = int.Parse(line.Split(",")[0].Split("-")[1]);
                var B1 = int.Parse(line.Split(",")[1].Split("-")[0]);
                var B2 = int.Parse(line.Split(",")[1].Split("-")[1]);

                if (A1 <= B1 && A2 >= B2) // AB-BA
                    overlap = true;
                if (A1 >= B1 && A2 <= B2) // BA-AB
                    overlap = true;

                if (A1 >= B1 && B1 >= A2 || A2 >= B2 && A1 <= B2)
                    overlap = true;
                if (A1 <= B1 && B1 <= A2 || A2 <= B2 && A1 >= B2)
                    overlap = true;

                if (overlap)
                    total += 1;
            }
            return total;
        }

        static int Part2x(IEnumerable<string> lines)
        {
            lines = string.Join(",", lines.ToArray()).Split(",").ToList();
            int total = 0;

            for (int i = 0; i < lines.Count(); i++)
            {
                for (int j = i+1; j < lines.Count(); j++)
                {
                    if (i != j)
                    {
                        bool overlap = false;
                        var A1 = int.Parse(lines.ToArray()[i].Split("-")[0]);
                        var A2 = int.Parse(lines.ToArray()[i].Split("-")[1]);
                        var B1 = int.Parse(lines.ToArray()[j].Split("-")[0]);
                        var B2 = int.Parse(lines.ToArray()[j].Split("-")[1]);

                        Console.WriteLine(A1+"-"+A2+","+B1+"-"+B2);

                        if (A1 <= B1 && A2 >= B2)
                            overlap = true;
                        if (A1 >= B1 && A2 <= B2)
                            overlap = true;
                        if (overlap)
                            total += 1;
                    }
                }
            }
            return total;
        }
    }
}