namespace AdventOfCode.day1;

class day1
{
    private static string txt = File.ReadAllText(@"./day01/input.txt");
    private int Sum(string inputText)
    {
        var file = txt
       .Split("\n\n")
       .Select(group => group
           .Split("\n")
           .Select(line => int.Parse(line))
           .Sum());

        var tx = file.ToArray();
        Array.Sort(tx);
        var sum = 0;
        for (int i = tx.Length - 1; i > tx.Length - 4; i--)
        {
            sum += tx[i];
        }
        return sum;
    }
}