using System.Linq;

namespace Split_Strings
{
    public class Program
    {
        static void Main(string[] args)
        {
        }

        public static string[] Solution(string str)
        {
            if (str.Length % 2 != 0) str += "_";

            return str
                .Select((x, i) => i)
                .Where(i => i % 2 == 0)
                .Select(i => str.Substring(i, 2)).ToArray();
        }
    }
}
