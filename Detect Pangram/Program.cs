using System.Linq;

namespace Detect_Pangram
{
    public class Program
    {
        static void Main(string[] args)
        {
        }

        public static bool IsPangram(string str)
        {
            return "abcdefghijklmnopqrstuvwxyz".All(str.ToLower().Contains);
        }
    }
}
