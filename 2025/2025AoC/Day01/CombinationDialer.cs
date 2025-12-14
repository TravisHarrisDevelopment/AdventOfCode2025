using System;
using System.Collections.Generic;
using System.Text;

namespace Day01
{
    public class CombinationDialer
    {
        public int CurrentPosition { get; set; }

        public int ZeroCount { get; set; } = 0;
        public int SecondaryZeroCount { get; set; } = 0;
        
        public CombinationDialer() : this (50)
        {}

        public CombinationDialer(int start)
        {
            CurrentPosition = start;
        }

        public string Left(int increment)
        {
            var simpleIncrement = IncrementSimplifier(increment);
            if (CurrentPosition > simpleIncrement)
            {
                CurrentPosition = CurrentPosition - simpleIncrement;
            }
            else if (CurrentPosition == simpleIncrement)
            {
                CurrentPosition = 0;
                ZeroCount++;
                SecondaryZeroCount++;
            }
            else if(CurrentPosition < simpleIncrement)
            {
                if (!(CurrentPosition == 0))
                    SecondaryZeroCount++;
                int temp = CurrentPosition - simpleIncrement;
                CurrentPosition = 100 + temp;
                
            }

            return $"The dial is rotated L{increment} to point at {CurrentPosition}";
        }

        public string Right(int increment)
        {
            var simpleIncrement = IncrementSimplifier(increment);

            if (CurrentPosition == 0)
            {
                CurrentPosition = simpleIncrement;
            }
            else if (CurrentPosition + simpleIncrement > 100)
            {
                CurrentPosition = (CurrentPosition + simpleIncrement) - 100;
                SecondaryZeroCount++;
            }
            else if (CurrentPosition + simpleIncrement == 100)
            {
                CurrentPosition = 0;
                ZeroCount++;
                SecondaryZeroCount++;
            }
            else if (CurrentPosition + simpleIncrement < 100)
            {
                var temp = CurrentPosition;
                CurrentPosition = CurrentPosition + simpleIncrement;
                
            }

            return $"The dial is rotated R{increment} to point at {CurrentPosition}";
        }

        private int IncrementSimplifier(int increment)
        {
            if (increment > 100)
            {
                SecondaryZeroCount+= increment/100;
                increment = increment % 100;
                
            }

            return increment;
        }

    }
}
