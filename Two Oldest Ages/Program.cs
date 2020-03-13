using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Two_Oldest_Ages
{
    public class Program
    {
        static void Main(string[] args)
        {
        }
        public static int[] TwoOldestAges(int[] ages)
        {
            return ages.OrderByDescending(i => i).Take(2).Reverse().ToArray();
        }
    }
}
