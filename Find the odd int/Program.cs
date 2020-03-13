using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Find_the_odd_int
{
    public class Program
    {
        static void Main(string[] args)
        {
        }

        public static int find_it(int[] seq)
        {
            return Convert.ToInt32(seq
                .GroupBy(x => x)
                .Where(x => x.Count() % 2 != 0)
                .Select(x => x.Key)
                .SingleOrDefault());
        }
    }
}
