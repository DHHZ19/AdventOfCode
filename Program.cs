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
    public static void Main(string[] args)
    {
        // shape you selected (1 for Rock, 2 for Paper, and 3 for Scissors)

        // outcome of the round (0 if you lost, 3 if the round was a draw, and 6 if you won)

        var file = txt.Split("\n").Select(letter => letter.Split());
        Console.WriteLine(file.ToList()[2][0]);
        if (file.ToList()[2][0] == "C")
        {
            Console.WriteLine(C);
        }
    }
}