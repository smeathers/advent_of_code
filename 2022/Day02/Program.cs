// See https://aka.ms/new-console-template for more information

// https://adventofcode.com/2022/day/2
// Part1 = 14531
// Part2 = 11258

var lines = File.ReadLines("input.txt");

//A for Rock        1
//B for Paper       2
//C for Scissors    3

//X for Rock        1
//Y for Paper       2
//Z for Scissors    3

// Win  = 6 Z
// Draw = 3 Y
// Loss = 0 X

Console.WriteLine(Part2(lines));

static int Part1(IEnumerable<string> lines)
{
    var opponentTotalScore = 0;
    var playerTotalScore = 0;

    foreach (var line in lines)
    {
        var opponentMove = line.Split(" ")[0];
        var playerMove = line.Split(" ")[1];

        var opponentRoundScore = 0;
        var playerRoundScore = 0;

        switch (opponentMove)
        {
            case "A":
                opponentRoundScore = 1;
                break;
            case "B":
                opponentRoundScore = 2;
                break;
            case "C":
                opponentRoundScore = 3;
                break;
            default:
                break;
        }

        switch (playerMove)
        {
            case "X":
                playerRoundScore = 1;
                break;
            case "Y":
                playerRoundScore = 2;
                break;
            case "Z":
                playerRoundScore = 3;
                break;
            default:
                break;
        }

        if (playerRoundScore == opponentRoundScore)
        {
            playerRoundScore += 3;
            opponentRoundScore += 3;
        }

        if (line == "C X" || line == "A Y" || line == "B Z")
            playerRoundScore += 6;

        if (line == "A Z" || line == "B X" || line == "C Y")
            opponentRoundScore += 6;

        //Console.WriteLine(opponentRoundScore + " " + playerRoundScore);

        playerTotalScore += playerRoundScore;
        opponentTotalScore += opponentRoundScore;

    }

    return (playerTotalScore);
}

static int Part2(IEnumerable<string> lines)
{
    var opponentTotalScore = 0;
    var playerTotalScore = 0;

    foreach (var line in lines)
    {
        var opponentMove = line.Split(" ")[0];
        var playerMove = line.Split(" ")[1];

        var opponentRoundScore = 0;
        var playerRoundScore = 0;

        switch (playerMove)
        {
            case "X": //loss
                playerRoundScore = 0;
                switch (opponentMove)
                {
                    case "A": //Rock
                        opponentRoundScore += 1;
                        playerRoundScore += 3;
                        break;
                    case "B": //Paper
                        opponentRoundScore += 2;
                        playerRoundScore += 1;
                        break;
                    case "C": //Scissors
                        opponentRoundScore += 3;
                        playerRoundScore += 2;
                        break;
                    default:
                        break;
                }
                break;
            case "Y": //draw
                playerRoundScore = 3;
                switch (opponentMove)
                {
                    case "A": //Rock
                        opponentRoundScore += 1;
                        playerRoundScore += 1;
                        break;
                    case "B": //Paper
                        opponentRoundScore += 2;
                        playerRoundScore += 2;
                        break;
                    case "C": //Scissors
                        opponentRoundScore += 3;
                        playerRoundScore += 3;
                        break;
                    default:
                        break;
                }
                break;
            case "Z": //win
                playerRoundScore = 6;
                switch (opponentMove)
                {
                    case "A": //Rock
                        opponentRoundScore += 1;
                        playerRoundScore += 2;
                        break;
                    case "B": //Paper
                        opponentRoundScore += 2;
                        playerRoundScore += 3;
                        break;
                    case "C": //Scissors
                        opponentRoundScore += 3;
                        playerRoundScore += 1;
                        break;
                    default:
                        break;
                }
                break;
            default:
                break;
        }

        //Console.WriteLine(opponentRoundScore + " " + playerRoundScore);

        playerTotalScore += playerRoundScore;
        opponentTotalScore += opponentRoundScore;

    }

    return (playerTotalScore);
}