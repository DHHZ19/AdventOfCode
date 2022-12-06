namespace AdventOfCode;

public class Program
{
    static string txt = File.ReadAllText(@"./day02/input.txt");
    static int totalScore = 0;
    static string[][] file = txt.Split("\n").Select(letter => letter.Split()).ToArray();

    public static int calcScore(string[][] file)
    {
        for (int i = 0; i < file.Length; i++)
        {
            string yourThrow = file[i][1];
            string thereThrow = file[i][0];
            part2ScoreCalc(thereThrow, yourThrow);
            // checkIfDraw(thereThrow, yourThrow);
            switch (yourThrow)
            {
                case "X":
                    totalScore += 1;
                    break;
                case "Y":
                    totalScore += 2;
                    break;
                case "Z":
                    totalScore += 3;
                    break;
            }
        }
        return totalScore;
    }

    public static void checkIfWin(string thereThrow, string yourThrow)
    {
        if (thereThrow == "C" && yourThrow == "X")
        {
            totalScore += 6;

        }
        if (thereThrow == "A" && yourThrow == "Y")
        {
            totalScore += 6;

        }
        if (thereThrow == "B" && yourThrow == "Z")
        {
            totalScore += 6;

        }

    }

    public static void checkIfDraw(string thereThrow, string yourThrow)
    {
        // draw state
        if (thereThrow == "A" && yourThrow == "X")
        {
            totalScore += 3;

        }
        if (thereThrow == "B" && yourThrow == "Y")
        {
            totalScore += 3;

        }
        if (thereThrow == "C" && yourThrow == "Z")
        {
            totalScore += 3;

        }
    }
    public static void part2ScoreCalc(string thereThrow, string yourThrow)
    {
        // draw state
        if (yourThrow == "X")
        {
            totalScore += 0;

        }
        if (yourThrow == "Y")
        {
            totalScore += 3;

        }
        if (yourThrow == "Z")
        {
            totalScore += 6;

        }
    }


    public static void Main(string[] args)
    {
        Console.WriteLine(calcScore(file));
    }
}