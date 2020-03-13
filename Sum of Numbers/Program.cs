using System;
using System.Linq;

namespace Sum_of_Numbers
{
    public class SumOfNumbers
    {
        static void Main(string[] args)
        {
        }
        public int GetSum(int a, int b)
        {
            return Enumerable.Range(Math.Min(a, b), Math.Max(a, b) - Math.Min(a, b) + 1)
                .Sum();
        }
    }
}
