using System.Linq;

namespace Break_camelCase
{
    public class Program
    {
        static void Main(string[] args)
        {
        }

        public static string BreakCamelCase(string str)
        {
            return string.Concat(str.Select(c => char.IsUpper(c) ? " " + c : c.ToString()));
        }
    }
}
