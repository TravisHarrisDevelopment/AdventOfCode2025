namespace Day02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var inputList = new List<(long, long)>();
            var rawInput = File.ReadAllLines(@"c:\source\repos\AdventOfCode\2025\input\day2.txt")[0];
            
            var listRanges = rawInput.Split(',');
            foreach (var range in listRanges)
            {
                var hyphen = range.IndexOf('-');
                var first = long.Parse(range.Substring(0, hyphen));
                var last = long.Parse(range.Substring(hyphen + 1));
                inputList.Add((first, last));
            }
            inputList.ForEach(a => { Console.WriteLine(a); });
        }
    }
}
