using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Multiples_of_3_or_5
{
    public class Program
    {
        static void Main(string[] args)
        {
        }

        public static int Solution(int value)
        {
            return Enumerable.Range(0, value)
                .Where(x => x % 3 == 0 || x % 5 == 0)
                .Sum();
        }
    }
}
