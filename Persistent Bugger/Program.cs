using System;
using System.Linq;

namespace Persistent_Bugger
{
    public class Program
    {
        static void Main(string[] args)
        {
        }
        public static int Persistence(long n)
        {
            int totalTimes = 0;
            while (n > 9)
            {
                n = n.ToString()
                    .ToCharArray()
                    .Select(x => x - 48)
                    .Aggregate((total, next) => total * next);
                totalTimes++;
            }

            return totalTimes;
        }
    }
}
