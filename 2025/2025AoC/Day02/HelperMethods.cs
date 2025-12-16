using System;
using System.Collections.Generic;
using System.Text;

namespace Day02
{
    public static class HelperMethods
    {
        public static int NumDigits(this long number)
        {
            var strNum = number.ToString();
            return strNum.Length;
        }
    }
}
