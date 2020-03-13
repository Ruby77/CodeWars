using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace Categorize_new_member
{
    public class Program
    {
        static void Main(string[] args)
        {
        }
        public static IEnumerable<string> OpenOrSenior(int[][] data)
        {
            return data
                .Select(x => x[0] >= 55 && x[1] > 7 ? "Senior" : "Open" );
        }
    }
}
