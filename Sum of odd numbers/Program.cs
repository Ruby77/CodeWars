using System;
using System.Linq;

namespace Sum_of_odd_numbers
{
    public class SumOfOddNumbers
    {
        static void Main(string[] args)
        {
        }
        public static long rowSumOddNumbers(long n)
        {
            return Enumerable
                .Range(0, Convert.ToInt32(n))
                .Select(i => n * n - (n - 1) + (2 * i))
                .Sum();
        }
    }
}