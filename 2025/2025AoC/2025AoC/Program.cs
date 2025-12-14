
using System.Data;

namespace _2025AoC
{
    internal class Program
    {
        static void Main(string[] args)
        {   
            
            var dialer = new CombinationDialer();
            
            var input = File.ReadAllLines(@"C:\source\repos\AdventOfCode\2025\input\day1.txt");

            foreach (var line in input)
            {
                if (line.StartsWith("L"))
                {
                    dialer.Left(int.Parse(line.Substring(1)));
                }
                else if (line.StartsWith("R"))
                {
                    dialer.Right(int.Parse(line.Substring(1)));
                }
            }

            Console.WriteLine($"Zeroes encountered: {dialer.ZeroCount}");
            Console.WriteLine($"Secondary Zeroes : {dialer.SecondaryZeroCount}");
            

            /*
            Console.WriteLine("Hello, World!");
            var dialer = new CombinationDialer(50);
            Console.Write($"Left 30 (should be 20):");
            dialer.Left(30);
            Console.WriteLine(dialer.CurrentPosition);
            Console.Write($"Left 20 (should be 0):");
            dialer.Left(20);
            Console.WriteLine(dialer.CurrentPosition);
            dialer.Left(1);
            Console.WriteLine($"Left 1 (should be 99): {dialer.CurrentPosition}");
            dialer.Left(49);
            Console.WriteLine($"Left 49 (should be 50): {dialer.CurrentPosition}");
            dialer.Right(25);
            Console.WriteLine($"Right 25 (should be 75): {dialer.CurrentPosition}");
            dialer.Right(25);
            Console.WriteLine($"Right 25 (should be 0): {dialer.CurrentPosition}");
            dialer.Left(1);
            Console.WriteLine($"Left 1 (should be 99): {dialer.CurrentPosition}");
            dialer.Right(201);
            Console.WriteLine($"Right 201 (should be 0): {dialer.CurrentPosition}");
            */
            var dialer2 = new CombinationDialer(50);
            Console.WriteLine(dialer2.Left(68));
            Console.WriteLine($"zero: {dialer2.ZeroCount}   secondaryZero: {dialer2.SecondaryZeroCount}");
            Console.WriteLine(dialer2.Left(30));
            Console.WriteLine($"zero: {dialer2.ZeroCount}   secondaryZero: {dialer2.SecondaryZeroCount}"); 
            Console.WriteLine(dialer2.Right(48));
            Console.WriteLine($"zero: {dialer2.ZeroCount}   secondaryZero: {dialer2.SecondaryZeroCount}"); 
            Console.WriteLine(dialer2.Left(5));
            Console.WriteLine($"zero: {dialer2.ZeroCount}   secondaryZero: {dialer2.SecondaryZeroCount}"); 
            Console.WriteLine(dialer2.Right(60));
            Console.WriteLine($"zero: {dialer2.ZeroCount}   secondaryZero: {dialer2.SecondaryZeroCount}"); 
            Console.WriteLine(dialer2.Left(55));
            Console.WriteLine($"zero: {dialer2.ZeroCount}   secondaryZero: {dialer2.SecondaryZeroCount}"); 
            Console.WriteLine(dialer2.Left(1));
            Console.WriteLine($"zero: {dialer2.ZeroCount}   secondaryZero: {dialer2.SecondaryZeroCount}"); 
            Console.WriteLine(dialer2.Left(99));
            Console.WriteLine($"zero: {dialer2.ZeroCount}   secondaryZero: {dialer2.SecondaryZeroCount}"); 
            Console.WriteLine(dialer2.Right(14));
            Console.WriteLine($"zero: {dialer2.ZeroCount}   secondaryZero: {dialer2.SecondaryZeroCount}"); 
            Console.WriteLine(dialer2.Left(82));
            Console.WriteLine($"zero: {dialer2.ZeroCount}   secondaryZero: {dialer2.SecondaryZeroCount}");
            Console.Write($"Zeros:  {dialer2.ZeroCount}");
            Console.Write($"  Secondary Zeros: {dialer2.SecondaryZeroCount}");

        }
    }
}
