using System.Numerics;
using System.Runtime.ExceptionServices;
using System.Runtime.InteropServices;

namespace Day02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int max = 0;
            var inputList = new List<(long, long)>();
            var rawInput = File.ReadAllLines(@"c:\source\repos\AdventOfCode\2025\input\day2.txt")[0];
            var findings = new List<long>();
            BigInteger sumFindings = 0;
            
            var listRanges = rawInput.Split(',');
            foreach (var range in listRanges)
            {
                var hyphen = range.IndexOf('-');
                var first = long.Parse(range.Substring(0, hyphen));
                var last = long.Parse(range.Substring(hyphen + 1));
                inputList.Add((first, last));
            }
            
            foreach(var pair in inputList)
            {
                
                var a = pair.Item1;
                var b = pair.Item2;
                //Console.WriteLine($"Testing range {a} to {b}");

                for (long i = a; i <= b; i++)
                {
                    string strI = i.ToString();
                    var iDigits = i.NumDigits();
                    char firstChar = strI[0];
                    if (strI.All(c => c == firstChar) && strI.Length > 1)
                    {       
                        findings.Add(i);
                        Console.WriteLine($"singles \t {i}");
                        sumFindings += i;
                        continue;
                    }
                    var maxCheck = iDigits / 2;

                    if (maxCheck >= 2  && iDigits%2 ==0)
                    {
                        var half = iDigits / 2; 
                        if (strI.Substring(0, half) == strI.Substring(half, half))
                        {
                            findings.Add(i);
                            Console.WriteLine($"doubles \t {i}");
                            sumFindings += i;
                            continue;
                        }
                    }
                    
                    if(maxCheck >= 3 && iDigits %3 ==0)
                    {
                        var third = iDigits / 3;
                        if(strI.Substring(0, third) == strI.Substring(third, third) && 
                           strI.Substring(0, third) == strI.Substring(2*third, third))
                        {
                            findings.Add(i);
                            Console.WriteLine($"triples \t {i}");
                            sumFindings += i;
                            continue;
                        }
                    }

                    if(maxCheck >=4 && iDigits %4 ==0)
                    {
                        var fourth = iDigits / 4;
                        if(strI.Substring(0, fourth) == strI.Substring(fourth, fourth) && 
                           strI.Substring(0, fourth) == strI.Substring(2*fourth, fourth) &&
                           strI.Substring(0, fourth) == strI.Substring(3*fourth, fourth))
                        {
                            findings.Add(i);
                            Console.WriteLine($"quadruples \t {i}");
                            sumFindings += i;
                            continue;
                        }
                    }

                    if(maxCheck >=5 && iDigits %5 ==0)
                    {
                        var fifth = iDigits / 5;
                        if(strI.Substring(0, fifth) == strI.Substring(fifth, fifth) && 
                           strI.Substring(0, fifth) == strI.Substring(2*fifth, fifth) &&
                           strI.Substring(0, fifth) == strI.Substring(3*fifth, fifth) &&
                           strI.Substring(0, fifth) == strI.Substring(4*fifth, fifth))
                        {
                            findings.Add(i);
                            Console.WriteLine($"quintuples \t {i}");
                            sumFindings += i;
                            continue;
                        }
                    }
                }
            }
            
            //findings.ForEach(a => { Console.WriteLine(a); });
            Console.WriteLine($"Sum of findings: {findings.Sum()}");
            Console.WriteLine($"BigInteger Sum of findings: {sumFindings}");
            
        }
    }
}
