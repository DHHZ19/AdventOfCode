namespace AdventOfCode;

public class Program
{
    private static string txt = File.ReadAllText(@"./day02/input.txt");

    // opponent:  A for Rock, B for Paper, and C for Scissors
    static int A = 1;
    static int B = 2;
    static int C = 3;
    //  You: X for Rock, Y for Paper, and Z for Scissors
    static int X = 1;
    static int Y = 2;
    static int Z = 3;

    static int Win = 6;
    static int loss = 0;
    static int draw = 3;
    static int totalScore = 0;
    static string[][] file = txt.Split("\n").Select(letter => letter.Split()).ToArray();

    public static int calcScore(string[][] file)
    {
        for (int i = 0; i < file.Length; i++)
        {
            string yourThrow = file[i][1];
            string thereThrow = file[i][0];
            checkIfDraw(thereThrow, yourThrow);
            checkIfWin(thereThrow, yourThrow);

            switch (yourThrow)
            {
                case "X":
                    totalScore = 1;
                    break;
                case "Y":
                    totalScore = 2;
                    break;
                case "Z":
                    totalScore = 3;
                    break;
                default:
                    return 0;
            }
        }
        return totalScore;
    }

    public static void checkIfWin(string thereThrow, string yourThrow)
    {
        // win state
        if (thereThrow == "A" && yourThrow == "X")
        {
            totalScore += 6;

        }
    }

    public static void checkIfDraw(string thereThrow, string yourThrow)
    {
        // draw state
        if (thereThrow == yourThrow)
        {
            totalScore += 3;
        }
    }



    public static void Main(string[] args)
    {
        calcScore(file);
        // win and a loss state for each type

        // shape you selected (1 for Rock, 2 for Paper, and 3 for Scissors)

        // outcome of the round (0 if you lost, 3 if the round was a draw, and 6 if you won)

        // creats a 2D array of the inputs 
    }
}