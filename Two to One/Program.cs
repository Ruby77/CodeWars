using System.Linq;

namespace Two_to_One
{
    public class Program
    {
        static void Main(string[] args)
        {
        }
        public static string Longest(string s1, string s2)
        {
            return string.Join("", s1.Union(s2).OrderBy(x=>x));
        }
    }
}
