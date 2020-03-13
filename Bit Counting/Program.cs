using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bit_Counting
{
    public class Program
    {
        static void Main(string[] args)
        {
        }
        public static int CountBits(int n)
        {
            return Convert
                .ToString(n, 2)
                .Count(c => c == '1');
        }
    }
}
