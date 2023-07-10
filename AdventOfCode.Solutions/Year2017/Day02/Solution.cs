namespace AdventOfCode.Solutions.Year2017.Day02;

class Solution : SolutionBase
{
    public Solution() : base(02, 2017, "") { }

    protected override string SolvePartOne()
    {
        var lines = Input.SplitByNewline();
        return lines.Select(line =>
        {
            var nums = line.Split(' ', '\t').Select(num => int.Parse(num)).Order();
            return nums.Last() - nums.First();
        }).Sum().ToString();
    }

    protected override string SolvePartTwo()
    {
        var lines = Input.SplitByNewline();
        return lines.Select(line =>
        {
            var nums = line.Split(' ', '\t').Select(num => int.Parse(num)).ToArray();
            for (int i = 0; i < nums.Count(); i++)
            {
                for (int j = 0; j < nums.Count(); j++)
                {
                    if (i != j && nums[i] % nums[j] == 0)
                    {
                        return nums[i] / nums[j];
                    }
                }
            }
            throw new Exception("wrong");
        }).Sum().ToString();
    }
}
