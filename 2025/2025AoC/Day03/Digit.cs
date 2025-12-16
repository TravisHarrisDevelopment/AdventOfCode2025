using System;
using System.Collections.Generic;
using System.Text;

namespace Day03
{
    public class Digit
    {
        public int Value { get; set; }
        public int Position { get; set; }
        public Digit(int value, int position)
        {
            Value = value;
            Position = position;
        }
    }
}
