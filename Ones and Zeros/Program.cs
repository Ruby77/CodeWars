using System;
using System.Linq;

namespace Ones_and_Zeros
{
    public class Program
    {
        static void Main(string[] args)
        {
        }
        public static int binaryArrayToNumber(int[] BinaryArray)
        {
            return BinaryArray
                .Reverse()
                .Select((s, i) => s * Convert.ToInt32(Math.Pow(2f, i)))
                .Sum();
        }
    }
}
