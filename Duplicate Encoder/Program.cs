using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Duplicate_Encoder
{
    public class Program
    {
        static void Main(string[] args)
        {
        }

        public static string DuplicateEncode(string word)
        {
            return string.Join("", word
                .ToLower()
                .Select(x => word
                    .GroupBy(g => g)
                    .Where(c => c.Count() > 1)
                    .Select(g => g.Key)
                    .Contains(x) ? ')' : '('));
        }
    }
}