using System;
using System.Linq;

namespace IQ_Test
{
    public class Program
    {
        static void Main(string[] args)
        {
        }
        public static int Test(string numbers)
        {
            string[] numberList = numbers.Split(' ');
            var odds = numberList.Where(c => Convert.ToInt32(c) % 2 != 0);
            var even = numberList.Where(c => Convert.ToInt32(c) % 2 == 0);
            return Array.IndexOf(numberList, odds.Count() == 1
                       ? odds.FirstOrDefault()
                       : even.FirstOrDefault()) + 1;
        }
    }
}
