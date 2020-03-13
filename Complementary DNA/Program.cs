using System;
using System.Linq;

namespace Complementary_DNA
{
    public class Program
    {
        static void Main(string[] args)
        {
        }
        public static string MakeComplement(string dna)
        {
            return new string(dna
                .Select(x => x == 'A' ? 'T' : (x == 'T' ? 'A' : x))
                .Select(x => x == 'C' ? 'G' : (x == 'G' ? 'C' : x))
                .ToArray());
        }
    }
}
