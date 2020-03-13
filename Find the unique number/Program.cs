using System;
using System.Collections.Generic;
using System.Linq;

namespace Find_the_unique_number
{
    public class FindTheUniqueNumber
    {
        static void Main(string[] args)
        {
        }
        public static int GetUnique(IEnumerable<int> numbers)
        {
            return numbers.GroupBy(s => s)
                .Where(x => x.Count() == 1)
                .Select(x => x.Key)
                .FirstOrDefault();
        }
    }
}
