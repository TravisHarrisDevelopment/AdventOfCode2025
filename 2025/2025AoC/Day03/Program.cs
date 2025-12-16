using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace Day03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var rawInput = File.ReadAllLines(@"c:\source\repos\AdventOfCode\2025\input\day3.tst");
            var joltage = new List<int>();
            foreach (var line in rawInput)
            {
                /*
                 * 987654321111111
                 * 811111111111119
                 * 234234234234278
                 * 818181911112111
                 */
                Digit biggest = new Digit ((int)Char.GetNumericValue(line[0]), 0 );
                Digit second = new Digit (-1,-1 );
                var length = line.Length;
                for(int i = 1; i < length-1; i++)
                {
                    if ((int)Char.GetNumericValue(line[i]) > biggest.Value)
                    {
                        biggest.Position = i; 
                        biggest.Value = (int)Char.GetNumericValue(line[i]);
                    }
                }
                for (int i = biggest.Position + 1; i < length; i++)
                {
                    if ((int)Char.GetNumericValue(line[i]) > second.Value)
                    {
                        second.Position = i;
                        second.Value = (int)Char.GetNumericValue(line[i]);
                    }
                }
                var bankJoltage = int.Parse(biggest.Value.ToString() + second.Value.ToString());
                Console.WriteLine(bankJoltage);
                joltage.Add(bankJoltage);
            }

            Console.WriteLine($"The total joltage:  {joltage.Sum(a=>a)}");

            /*-------------------------------------------------------------------------------------------
             * Need to find the largest 12 digit number.
             * Find the biggest digit in the first length -11 characters
             * Find the biggest digit in the first biggest.location to -10 characters
             * sounds like a job for recursion
             ------------------------------------------------------------------------------------------*/
            var bigJoltages = new List<long>();
            foreach (var line in rawInput)
            {
                var digitArray = new Digit[12];
                digitArray[0] = new Digit((int)Char.GetNumericValue(line[0]), 0);
                for (int i =1; i < 12; i++)
                {
                    digitArray[i] = new Digit((int)Char.GetNumericValue(line[i]), i);
                }
                var length = line.Length;
                var offset = 11;
                for (int outer = 0; outer < 11; outer++)
                {
                    for (int i = 1; i < length - (outer+1); i++)
                    {
                        if ((int)Char.GetNumericValue(line[i]) > digitArray[outer].Value)
                        {
                            digitArray[outer].Position = i;
                            digitArray[outer].Value = (int)Char.GetNumericValue(line[i]);
                        }
                        offset--;
                    }
                }
                var joltageSB = new StringBuilder();
                for (int i = 0; i < digitArray.Length; i++)
                {
                    joltageSB.Append(digitArray[i].Value.ToString());
                }

                long joltage2 = long.Parse(joltageSB.ToString());
                bigJoltages.Add(joltage2);
            }

        }
    }
}
