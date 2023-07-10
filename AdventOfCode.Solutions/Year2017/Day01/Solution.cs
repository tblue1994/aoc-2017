namespace AdventOfCode.Solutions.Year2017.Day01;

class Solution : SolutionBase
{
    public Solution() : base(01, 2017, "") { }

    protected override string SolvePartOne()
    {
        var total = 0;
        var lines = Input.SplitByNewline();
        var input = lines.First();
        for (int i = 0; i < input.Length - 1; i++)
        {

            if (input[i] == input[i + 1])
            {
                total += int.Parse(input[i].ToString());
            }
        }
        if (input.First() == input.Last())
        {
            total += int.Parse(input.First().ToString());
        }
        return total.ToString();
    }

    protected override string SolvePartTwo()
    {
        //Debug = true;
        var total = 0;
        var lines = Input.SplitByNewline();
        var input = lines.First();
        for (int i = 0; i < input.Length / 2; i++)
        {

            if (input[i] == input[i + input.Length / 2])
            {
                total += (int.Parse(input[i].ToString()) * 2);
            }
        }
        return total.ToString();
    }
}
