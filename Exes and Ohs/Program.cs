using System.Linq;

namespace Exes_and_Ohs
{
    public class ExesAndOhs
    {
        static void Main(string[] args)
        {
        }
        public static bool XO(string input)
        {
            return input.ToLower().Count(c => c == 'x') == input.ToLower().Count(c => c == 'o');
        }
    }
}
