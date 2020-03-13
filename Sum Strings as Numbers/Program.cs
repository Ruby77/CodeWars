using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;

namespace Sum_Strings_as_Numbers
{
    public class Program
    {
        static void Main(string[] args)
        {
        }
        public static string sumStrings(string a, string b)
        {
            if (a.Length < b.Length) a = a.PadLeft(b.Length, '0');
            else b = b.PadLeft(a.Length, '0');

            int carry = 0;
            var listA = a.Reverse().ToArray();
            var listB = b.Reverse().ToArray();

            List<int> solution = new List<int>();

            Enumerable.Range(0, Math.Min(a.Length, b.Length)).ToList().ForEach(i =>
                {
                    int answer = (listA[i] - '0') + (listB[i] - '0') + carry;
                    solution.Add(answer % 10);
                    carry = answer / 10;
                });

            if(carry > 0)solution.Add(carry);
            solution.Reverse();

            return string.Concat(solution).TrimStart('0');
        }
    }
}
