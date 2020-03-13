using System;
using System.Collections.Generic;
using System.Linq;

namespace Tribonacci_Sequence
{
    public class Program
    {
        private static void Main(string[] args)
        {
        }

        public double[] Tribonacci(double[] signature, int n)
        {
            if (n < 3) return signature.Take(n).ToArray();
            else
            {
                List<double> fibs = signature.ToList();
                Enumerable.Range(0, n - 3)
                    .ToList()
                    .ForEach(i => fibs.Add(fibs[i] + fibs[i + 1] + fibs[i + 2]));
                return fibs.ToArray();
            }
        }
    }
}