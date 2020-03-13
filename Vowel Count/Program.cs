using System.Linq;

namespace Vowel_Count
{
    public class Program
    {
        static void Main(string[] args)
        {
        }
        public static int GetVowelCount(string str)
        {
            char[] vowels = {'a', 'e', 'i', 'o', 'u'};
            return str.ToCharArray().Count(x => vowels.Contains(x));
        }
    }
}
